### 🔄 Project Awareness & Context
- **Always read `PLANNING.md`** at the start of a new conversation to understand the project's architecture, goals, style, and constraints.
- **Check `TASK.md`** before starting a new task. If the task isn't listed, add it with a brief description and today's date.
- **Use consistent naming conventions, file structure, and architecture patterns** as described in `PLANNING.md`.
- **Follow .NET project conventions** including proper solution/project structure and package management with NuGet.

### 🧱 Code Structure & Modularity
- **Never create a file longer than 500 lines of code.** If a file approaches this limit, refactor by splitting it into separate classes or helper files.
- **Organize code into clearly separated projects and namespaces**, grouped by feature or responsibility.
  For applications this looks like:
    - `Domain/` - Core business logic and entities
    - `Application/` - Use cases and application services
    - `Infrastructure/` - Data access and external services
    - `Presentation/` - Controllers, APIs, or UI components
- **Use proper namespace organization** following project structure.
- **Use dependency injection** for loose coupling and testability.
- **Use appsettings.json and IConfiguration** for configuration management.

### 🧪 Testing & Reliability
- **Always create unit tests using xUnit** for new features (methods, classes, controllers, etc).
- **After updating any logic**, check whether existing unit tests need to be updated. If so, do it.
- **Tests should live in separate test projects** with `.Tests` suffix matching the main project structure.
  - Include at least:
    - 1 test for expected behavior
    - 1 edge case
    - 1 failure case
- **Use appropriate mocking frameworks** like Moq or NSubstitute for dependencies.

### ✅ Task Completion
- **Mark completed tasks in `TASK.md`** immediately after finishing them.
- Add new sub-tasks or TODOs discovered during development to `TASK.md` under a "Discovered During Work" section.

### 📎 Style & Conventions
- **Use C#** as the primary language with .NET as the framework.
- **Follow Microsoft C# coding conventions** and use nullable reference types.
- **Use Entity Framework Core** for ORM when applicable.
- **Use ASP.NET Core** for web APIs and applications.
- **Use record types** for immutable data transfer objects where appropriate.
- Write **XML documentation comments** for every public member:
  ```csharp
  /// <summary>
  /// Brief summary of what the method does.
  /// </summary>
  /// <param name="parameter">Description of parameter.</param>
  /// <returns>Description of return value.</returns>
  public ReturnType ExampleMethod(ParameterType parameter)
  {
      // Implementation
  }
