using Microsoft.AspNetCore.Mvc;
using UserManagementServiceApi.Models;

namespace UserManagementServiceApi.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UsersController(UserContext context) : ControllerBase
    {
        private readonly UserContext _context = context;

        [HttpPost]
        public async Task<ActionResult<User>> CreateNewUser(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return Ok(user);
        }

        [HttpPatch("{id}")]
        public IActionResult UpdateUserState(Guid id, User userModel)
        {
            if (id != userModel.Id)
            {
                return BadRequest();
            }

            var user = _context.Users.Find(userModel.Id);

            if (user == null)
            {
                return NotFound();
            }

            user.Active = userModel.Active;
            _context.Update(user);
            _context.SaveChanges();

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(Guid id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpGet]
        public IEnumerable<User> ListAllActiveUsers()
        {
            var allActiveUsers = _context.Users.Where(u => u.Active == true);
            return allActiveUsers;
        }
    }
}
