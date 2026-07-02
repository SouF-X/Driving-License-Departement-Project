# Driving License Department System

A Windows Forms desktop application for managing driving license department operations.

This project was built as a C# / SQL Server practice project and represents one of my larger desktop database applications. It follows a layered structure with a presentation layer, business layer, and data access layer.

## Features

### Authentication and Users

- Login screen for system users
- User management
- Add, update, delete, and search users
- Change password
- Account settings

### People and Drivers

- Manage people records
- Add and update personal information
- Search/filter people
- Manage drivers
- View driver license history

### License Services

- Issue new local driving licenses
- Issue international driving licenses
- Renew local licenses
- Replace lost or damaged licenses
- Detain licenses
- Release detained licenses

### Applications and Tests

- Manage local driving license applications
- Manage international license applications
- Schedule tests
- Take/update test results
- Manage application types
- Manage test types

## Architecture

The solution is separated into three main projects:

```txt
DVLD                  -> Windows Forms presentation layer
SFX-DVLD-Business     -> Business logic layer
SFX-DVLD-DataAccess   -> Data access layer using ADO.NET
```

## Concepts Practiced

- C# Windows Forms
- SQL Server database access
- ADO.NET
- Layered architecture
- CRUD operations
- Business rules
- User controls
- Form navigation
- Input validation
- Desktop UI design

## Tech Stack

- C#
- .NET Framework 4.7.2
- Windows Forms
- SQL Server
- ADO.NET
- Krypton Toolkit

## How to Run

1. Open `DVLD/DVLD.sln` in Visual Studio.
2. Restore or create a SQL Server database named `DVLD`.
3. Update the `DBConnection` connection string in `DVLD/App.config` if needed.
4. Make sure Krypton Toolkit references are available.
5. Build and run the project.

## Notes

- This is an educational portfolio project.
- The repository contains the application source code, but database setup may need to be configured locally.
- Build artifacts and local Visual Studio files are intentionally excluded from the repository.

## Project Status

Completed educational project.

This project was built during my C# learning path to practice desktop application development, SQL Server integration, and multi-layer architecture.
