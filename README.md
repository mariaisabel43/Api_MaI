# Api_Maria Isabel
Este proyecto es una API RESTful desarrollada en ASP.NET Core para gestionar tareas, con operaciones CRUD y LINQ.

Instalación y Configuración
dotnet tool install --global dotnet-ef --version 9.0.6
dotnet ef migrations add Inicial
dotnet ef database update

Nugget:
Install-Package Microsoft.EntityFrameworkCore.SqlServer
Install-Package Microsoft.EntityFrameworkCore.Tools

Endpoints:
Get: Obtiene tareas
Get: Obtiene tarea especifica
Post: Crea
Put: Actualiza
Delete: Elimina

LINQ:
Filtra tareas por estado y prioridad
