# ScholorHat_api

ScholorHat_api is a small ASP.NET Core (.NET 8) Web API for managing Products and Categories (EF Core). It includes basic models, a migration, and CRUD-ready endpoints.

Quick start
- Requirements: .NET 8 SDK, SQL Server (or update connection string).
- Configure connection string in appsettings.json.
- Run database migrations:
  dotnet ef database update
- Start the API:
  dotnet run

What it provides
- Product and Category models with EF Core relationships.
- Ready-to-use migrations and DI setup for extension.

License
- Add a LICENSE file as needed.
