namespace UserManagementServiceApi.Models
{
    public class User
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Birthdate { get; set; }
        public bool Active { get; set; }
    }
}
