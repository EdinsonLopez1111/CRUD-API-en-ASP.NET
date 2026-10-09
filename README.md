# Web API CRUD - C# & Entity Framework Core

Este repositorio contiene la implementación de una Web API RESTful desarrollada en .NET 8 utilizando Controllers, Entity Framework Core y SQL Server.

## Estructura del Proyecto

- **Controllers/**: Controladores de la API (`CategoriasController`, `ProductosController`) con verbos HTTP (`GET`, `POST`, `PUT`, `DELETE`).
- **Entities/**: Entidades de dominio (`Categoria`, `Producto`) con relación 1 a N.
- **DTOs/**: Objetos de transferencia de datos para desacoplar el dominio (`CategoriaDto`, `ProductoDto`, etc.).
- **Context/**: Contexto de base de datos (`ApplicationDbContext`) configurado con EF Core.
- **appsettings.json**: Cadena de conexión y configuraciones.
- **Program.cs**: Configuración de servicios, inyección de dependencias y Swagger.

