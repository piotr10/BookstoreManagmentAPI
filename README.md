# Bookstore Management API

A REST API for running a bookstore's back office: **authors, books, customers and orders**. It's built with **ASP.NET Core 6** and **Clean Architecture + CQRS**, and stores its data in **Microsoft SQL Server**.

I built this project to practise how production-grade .NET APIs are structured: a separate domain model, MediatR request pipelines, validation, auditing, token-based security, logging, and a unit and integration test suite.

---

## ✨ Features

- **REST endpoints** for `Authors`, `Books`, `Customers` and `Orders`: list, details, create and delete
- **CQRS with MediatR:** every use case is a separate command or query with its own handler
- **Pipeline behaviours** that run on every request:
  - **Validation** with FluentValidation
  - **Logging** of every request
  - **Performance** monitoring, which logs slow requests
- **Audit trail:** `CreatedBy`, `Created`, `ModifiedBy`, `Modified`, `InactivatedBy` and `Inactivated` are filled in automatically in `SaveChanges`. Deletes are soft deletes (status change), so no history is lost
- **Rich domain model:** value objects (`PersonName`, `Email`, `Address`), normalised contact and detail types, and custom domain exceptions
- **Security:**
  - JWT bearer authentication against a separate **IdentityServer4** project;
  - Swagger UI with OAuth2 authorisation
- **Observability:** structured logging with **Serilog** (console, file and **Seq**), and a health check endpoint at `/hc`
- **External integration:** typed `HttpClient` for the **Google Books API**
- **Blazor WebAssembly client** (`BookstoreManagement/Client`) consuming the API

## 🗄️ Database

- **Microsoft SQL Server** with **Entity Framework Core 6** (code-first)
- Main entities:
  - `Author`, `AuthorBiography`, `AuthorContactDetail`
  - `Book`, `Genre`
  - `Customer`, `CustomerDetail`, `CustomerContactDetail`
  - `Order`, `OrderTransportType`, `PaymentMethod`
- Entity configuration kept in separate `IEntityTypeConfiguration` classes (Fluent API)
- Seed data for development, and 30+ migrations documenting how the schema evolved
- The database diagram is in [`DatabaseMap.drawio`](DatabaseMap.drawio)

## 🏗️ Architecture

```
BookstoreManagement.Domain          → entities, value objects, domain exceptions
BookstoreManagement.Application     → CQRS commands/queries, handlers, validators, DTOs, mappings, behaviours
BookstoreManagement.Persistance     → BookstoreDbContext, entity configurations, migrations, seed
BookstoreManagement.Infrastructure  → Google Books client, file store, date/time service, Identity
BookstoreManagement.Api             → controllers, Swagger, authentication, health checks
BookstoreManagement/Client          → Blazor WebAssembly front-end
BookstoreManagement.UnitTests       → handler and mapping tests
WebApi.IntegrationTests             → API tests with WebApplicationFactory
IdentityServer/                     → IdentityServer4 token server
```

## 🧪 Tests

- **Unit tests** for command and query handlers of every aggregate, plus AutoMapper configuration tests. They run against EF Core InMemory using **xUnit**, **Shouldly** and **Moq**
- **Integration tests** for the API with `WebApplicationFactory` and a fake current-user service

```bash
dotnet test BookstoreManagment.API/BookstoreManagement.sln
```

## 🧰 Tech stack

| Area | Technology |
|---|---|
| Framework | .NET 6, ASP.NET Core Web API, Blazor WebAssembly |
| Architecture | Clean Architecture, CQRS, MediatR, AutoMapper, FluentValidation |
| Data | SQL Server, Entity Framework Core 6, Fluent API, Migrations, Seed data |
| Security | IdentityServer4, JWT Bearer, Swagger OAuth2 |
| Observability | Serilog, Seq, Health Checks |
| Tests | xUnit, Shouldly, Moq, EF Core InMemory, WebApplicationFactory |

---

## 🚀 Running locally

**Prerequisites:** .NET 6 SDK, SQL Server Express (or any SQL Server instance), `dotnet-ef` tool. Seq is optional.

1. Set the connection string `ConnectionStrings:BookstoreDatabase5` in `BookstoreManagment.API/BookstoreManagment/appsettings.json`.
2. Create the database:
   ```bash
   cd BookstoreManagment.API
   dotnet ef database update --project BookstoreManagment.Persistance --startup-project BookstoreManagment
   ```
3. Start the token server (listens on `https://localhost:5001`):
   ```bash
   dotnet run --project IdentityServer
   ```
4. Start the API and open Swagger at `/swagger`:
   ```bash
   dotnet run --project BookstoreManagment.API/BookstoreManagment
   ```

## 🗺️ Roadmap

- Update endpoints (PUT) for all aggregates
- Paging and filtering on list queries
- Sales reporting (best-selling books, revenue per customer) as SQL views
- Migrate IdentityServer4 to Duende IdentityServer or Microsoft Entra ID
