# ToDoCRUDRestApi
A REST Api to manager a ToDo list.

How it was builded.
Steps:
1 - A WebApi project was created in .Net Core.
2 - The dependencies of the Entity Framework have been established.
3 - The connection string has been configured in appsettings.
4 - The ToDo template was created.
5 - The DataContext class was created.
6 - The service interface that will handle requests has been created.
7 - The service to handle the requests has been created.
8 - The service and the DataContext class were included in the services container.
9 - The controller has been changed to, through dependency injection, call the service that will handle the requests.
10 - The dependencies have been configured to use the JwtBearer.
11 - SecurityKey was created in appsettings.
12 - A controller (AuthController) was created to generate the token.
13 - The ToDoController has been configured to require token authentication.
14 - The Authentication service was included in the service container
