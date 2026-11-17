# Game Backlog API

The backend for a video game backlog tracker. A REST API for keeping track of the games you own, with the aim of helping you actually finish more of them

## Tech stack

- C# / .NET 10
- ASP.NET Core Web API (controllers)
- Swagger UI

## Getting started

Requires the [.NET 10 SDK](https://dotnet.microsoft.com/download).

```
git clone https://github.com/tendinitis/game-backlog-api.git
cd game-backlog-api
dotnet run --project GameBacklog.Api
```

Then open http://localhost:5275/swagger to try the API in Swagger UI

## Endpoints

| Method | Route | Description | Success | Errors |
|---|---|---|---|---|
| GET | /games | List all games | 200 | - |
| GET | /games/{id} | Get a game by ID | 200 | 404 |
| POST | /games | Post a new game | 201 | 400 |
| PUT | /games/{id} | Update an existing game | 204 | 400, 404 |
| DELETE | /games/{id} | Delete a game | 204 | 404 |

## Roadmap

- **Filter by status.** For example `GET /games?status=Playing`
- **Persistent storage.** A database, so games survive a restart
- **User accounts.** Each user gets their own backlog
- **Automated tests.** Unit and integration tests with xUnit
- **Deployment.** Docker, cloud hosting, and tests running on every push
- **Steam library import.** Pull in your whole Steam library with one click
- **Game recommendations.** Suggestions based on your ratings and choices