# ResourceBookingService

A resource booking service built with ASP.NET Core Web API.

The project is intended as a backend service for managing bookable resources such as meeting rooms, projectors, and other shared equipment.

## Tech Stack

- C#
- .NET 10
- ASP.NET Core Web API
- Entity Framework Core
- SQLite
- REST API
- Swagger / OpenAPI
- Git

## Current Features

- Resource domain model
- CRUD operations for resources
- Persistent storage with Entity Framework Core and SQLite
- Database migrations
- Request DTOs for create and update operations
- Input validation
- HTTP endpoints for managing resources
- Manual API testing with `.http` requests
- JSON serialization of enum values as strings
- Swagger UI in the Development environment

## API Endpoints

| Method | Endpoint | Description |
| --- | --- | --- |
| `GET` | `/api/resources` | Get all resources |
| `GET` | `/api/resources/{id}` | Get a resource by ID |
| `POST` | `/api/resources` | Create a new resource |
| `PUT` | `/api/resources/{id}` | Update an existing resource |
| `DELETE` | `/api/resources/{id}` | Delete a resource |

## Resource Model

```json
{
  "id": 1,
  "name": "Meeting Room A",
  "type": "MeetingRoom",
  "capacity": 8,
  "description": "Meeting room with a projector",
  "isActive": true
}
```

## Database Setup

The project uses SQLite for persistent storage.

Apply the existing Entity Framework Core migrations before running the API:

```bash
dotnet ef database update --project ResourceBooking.Api
```

The local SQLite database file is excluded from version control.

## API Testing

Example requests are available in:

`ResourceBooking.Api/ResourceBooking.Api.http`

## Project Structure

```text
ResourceBookingService/
├── ResourceBooking.Api/
│   ├── Contracts/
│   │   └── Resources/
│   ├── Controllers/
│   ├── Data/
│   ├── Domain/
│   │   ├── Entities/
│   │   └── Enums/
│   ├── Migrations/
│   ├── Program.cs
│   └── ResourceBooking.Api.http
├── ResourceBookingService.slnx
└── README.md
```

## Planned Development

- Booking domain model
- Booking conflict validation
- Automated tests
