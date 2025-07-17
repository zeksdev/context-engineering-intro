### 🔄 Project Awareness & Context
- **Always read `PLANNING.md`** at the start of a new conversation to understand the project's architecture, goals, style, and constraints.
- **Check `TASK.md`** before starting a new task. If the task isn’t listed, add it with a brief description and today's date.
- **Use consistent naming conventions, file structure, and architecture patterns** as described in `PLANNING.md`.

### 🧱 Code Structure & Modularity
- **Never create a file longer than 500 lines of code.** If a file approaches this limit, refactor by splitting it into modules or helper files.
- **Organize code into clearly separated modules**, grouped by feature or responsibility.
- **Use clear, consistent imports**
- **Always** put a solution file (.sln) in the /src folder
- **Group** endpoints by feature in the `Endpoints` folder. E.g.: `Endpoints/Vehicles/`, `Endpoints/Brands/` 
- **Create .http files** for each endpoint group in the `Endpoints/<Feature>` folder to test them easily.
- **Do not forget** to reference Api.Contracts project in the API project. This is needed to use DTOs in the API project.

### 🧪 Testing & Reliability
- **After updating any logic**, check whether existing unit tests need to be updated. If so, do it.
- **Tests should live in a `/tests` folder** mirroring the main app structure.
  - Include at least:
    - 1 test for expected use
    - 1 edge case
    - 1 failure case

### ✅ Task Completion
- **Mark completed tasks in `TASK.md`** immediately after finishing them.
- Add new sub-tasks or TODOs discovered during development to `TASK.md` under a “Discovered During Work” section.

### 📎 Style & Conventions
- **Use C#** as the primary language.
- **Use latest stable .NET**
- For developing backends, I always use **ASP.NET Core** or in some cases **Service Workers**
- **I always name projects with prefix of main solution** Here is example: Bookstore.Api, Bookstore.Web, Bookstore.Api.Contracts etc.
- Usually **I don't use Clean Architecture**. I prefer a simpler solution. I use standard projects such as *.API (for endpoints and web api), *.Web (for hosting UI—typically Blazor Server), *.API.Contracts (for DTOs)
- **Use `FluentValidation` for data validation**. I prefer to put validation class in the same file as my DTO—This is because I can reuse same validation logic on backend and frontend
- **Use `FastEndpoints`** for APIs. Put all endpoints in the `Endpoints` folder.
- **Use `EntityFrameworkCore`** for ORM. Put inherited DbContext into Persistence folder. Be careful with relationships in EF Core. If you think that related entity is **owned** by parent and cannot exist without it, then use Owned Entity. If you think that related entity can exist without a parent, then use regular relationship.
- Entity classes should be in the **Domain** folder.
- Migrations should be in the **Persistence/Migrations** folder.
- Write **documentation comment for every method** using the C# style: (https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/xmldoc/?redirectedfrom=MSDN)
- **Use `Serilog` for logging** and ensure all logs are structured.
- User separate project for DTOs and shared code. Usually I like to name this class library project as <Project name>.Api.Contracts
- **Do not use any of the mapping libraries** like AutoMapper. Instead, use **manual mapping** for DTOs and entities. **Create extension methods** for mapping from DTO to Entity and vice versa.
- On frontend, I usually **bind forms directly to DTO**, I don't use separate models in a UI project. This is to avoid repetitions
- My DTO class usually has Clone() method
- When I import DTO into Endpoint, or anywhere in the API project, I prefer to use named imports. For example: `using BikeDto = BitsBikeRental.Api.Contracts.DTOs.Bike;` instead of `using BitsBikeRental.Api.Contracts.DTOs`. This helps to avoid name conflicts and makes it clear which DTO is being used.
- When my entity has a navigation property in DTO which represents this Entity I usually include related Id and Name properties. Here is an example: Vehicle entity has VehicleBrand(Id, Name) navigation property. Then my DTO for Vehicle contains 2 properties: VehicleBrandId and VechileBrandName
- I put DTOs into Api.Contracts project into the folder DTOs. When I name DTO, I don't add any suffix
- I prefer to use **Primary constructors** [Documentation](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/instance-constructors)
- For endpoints, you don't need to inject logger. Logger is provided by FastEndpoints automatically.
- I **very rarely use pagination** in "GetAll" Endpoints. So if you need to implement pagination, please ask me first.
- For database, I use SQL Server running in Docker. You can use **User=sa, Password=S3cretP@ssw0rd**
- Error handling in Endpoint should be done using this example: [Example](examples/ErrorHandlingInEndpoint.cs)

### 📚 Documentation & Explainability
- **Update `README.md`** when new features are added, dependencies change, or setup steps are modified.
- **Comment non-obvious code** and ensure everything is understandable to a mid-level developer.
- When writing complex logic, **add an inline `# Reason:` comment** explaining the why, not just the what.
- Here are links to documentation for libraries I like to use:
  - FastEndpoints: [Getting Started](https://fast-endpoints.com/docs/get-started), [Validation](https://fast-endpoints.com/docs/validation#request-dto-validation), [Dependency Injection](https://fast-endpoints.com/docs/validation#request-dto-validation), [Exception handling](https://fast-endpoints.com/docs/exception-handler#unhandled-exception-handler), [Pre/Post processors](https://fast-endpoints.com/docs/pre-post-processors#pre-processors), [Event Bus](https://fast-endpoints.com/docs/event-bus#_1-define-an-event-model-dto), [Command Bus](https://fast-endpoints.com/docs/command-bus#_1-define-a-command)
  - Swagger: use implementation from FastEndpoints [Swagger](https://fast-endpoints.com/docs/swagger-support)
  - FluentValidation: (https://docs.fluentvalidation.net/en/latest/), [Built-in validators](https://docs.fluentvalidation.net/en/latest/built-in-validators.html), [Collections](https://docs.fluentvalidation.net/en/latest/collections.html)

### 🧠 AI Behavior Rules
- **Never assume missing context. Ask questions if uncertain.**
- **Never hallucinate libraries or functions** – only use known, verified Nuget packages.
- **Always confirm file paths and module names** exist before referencing them in code or tests.
- **Never delete or overwrite existing code** unless explicitly instructed to or if part of a task from `TASK.md`.