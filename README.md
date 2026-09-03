# CollegeFestMVC

ASP.NET Core MVC application for AMTICS College Technical Fest registration.

## Requirements
- .NET SDK 7.0.400
- VS Code (optional)

## Run from Terminal
```bash
dotnet restore
dotnet run
```

The project is configured for:
- HTTP: http://localhost:5000
- HTTPS: https://localhost:5001

If the HTTPS development certificate is not trusted:
```bash
dotnet dev-certs https --trust
```

## Run in VS Code
Open this folder in VS Code and press `F5`, or use:
```bash
dotnet run
```

## Main routes
- `/Fest/Index`
- `/Fest/Register`
- `/Fest/Details/{id}`
- `/Fest/Welcome`

## Notes
Participant data is stored temporarily in a static `List<Participant>` as required by the task. Data is lost when the application restarts.
