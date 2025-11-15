Library Management System (C# .NET Console App):
A modular, extensible Library Management System built with C# and .NET Core.  
Designed as a multi-phase project to demonstrate clean architecture, object-oriented design (OOP), repository pattern, and layered separation of concerns.

Goals:
- Showcase professional-grade code for backend-focused positions.
- Practice clean, testable, and maintainable architecture.
- Gradually evolve from CLI to Web API and database integration.
- Follow SOLID principles and separation of concerns.

Features (Current Phase: CLI + In-Memory):
- Manage books (title, author, category..).
- Manage users.
- Loan and return books with date tracking.
- Enforce rules like availability checks.
- Modular repository interfaces for easy extension (e.g. JSON or DB).
- Business logic encapsulated in service layer (LibraryService).
- Fully testable in-memory data layer.

In the newar future i'll add:
- JSON-based persistence
- ASP.NET Core Web API
- Authentication and roles (Admin, Reader)
- Reporting & statistics (popular books, late returns)
- Unit tests
