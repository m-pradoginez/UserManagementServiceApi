# ASP.NET Core User Management Service WebApi with Swagger

This project is part of a technical test for ENG. The task was to create a API service capable of managing user data.

This repository contains a controller which is dealing with users. You can GET/POST/PATCH and DELETE them.

## Versions
```https://localhost:44339/swagger/index.html```

![image](https://github.com/m-pradoginez/UserManagementServiceApi/assets/62036356/15094eae-b769-494c-8142-168003d1112e)

## Post a User
```https://localhost:44339/api/user```

```javascript
  {
      "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
      "name": "string",
      "birthdate": "string",
      "active": true
  }
```

![image](https://github.com/m-pradoginez/UserManagementServiceApi/assets/62036356/1bc3d45a-22a1-4910-81f6-b089272297fb)

## Get All Active Users
```https://localhost:44339/api/user```

![image](https://github.com/m-pradoginez/UserManagementServiceApi/assets/62036356/01437bc3-28ee-45d1-b29c-3d086762fcc9)

## Update User State
```https://localhost:44339/api/user/3fa85f64-5717-4562-b3fc-2c963f66afa6```

```javascript
  {
      "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
      "name": "string",
      "birthdate": "string",
      "active": false
  }
```

![image](https://github.com/m-pradoginez/UserManagementServiceApi/assets/62036356/752fdc9d-d010-4d76-8762-88eaa09c3b7e)

## Delete User
```https://localhost:44339/api/user/3fa85f64-5717-4562-b3fc-2c963f66afa6```

![image](https://github.com/m-pradoginez/UserManagementServiceApi/assets/62036356/d72b25ec-31ec-42a6-8219-69437b048385)

## Set Up and Run the Project

The project was built in .Net Core framework and utilizes the Entity Framework as in-memory database. To run the project, just clone the project and open the solution in visual studio, after that run the project with IIS Express.
