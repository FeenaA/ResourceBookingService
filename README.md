# ResourceBookingService

A resource booking service built with ASP.NET Core Web API.

The project is intended as a backend service for managing bookable resources such as meeting rooms, projectors, and other shared equipment.

## Tech Stack

- C#
- .NET 10
- ASP.NET Core Web API
- REST API
- Git

## Current Features

- Resource domain model
- CRUD operations for resources
- Request DTOs for create and update operations
- HTTP endpoints for managing resources
- Manual API testing with `.http` requests
- JSON serialization of enum values as strings

At the current stage, resources are stored in memory.

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
│   ├── Domain/
│   │   ├── Entities/
│   │   └── Enums/
│   ├── Program.cs
│   └── ResourceBooking.Api.http
├── ResourceBookingService.sln
└── README.md
```

## Planned Development

- Input validation
- Persistent storage with Entity Framework Core
- Database migrations
- Booking domain model
- Booking conflict validation
- Automated tests
