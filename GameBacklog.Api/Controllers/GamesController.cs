using GameBacklog.Api.Dtos;
using GameBacklog.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameBacklog.Api.Controllers;

[ApiController]
[Route("games")]
public class GamesController : ControllerBase
{
    private static readonly List<Game> _games =
    [
        new Game { Id = 1, Title = "Where Winds Meet", Platform = "Steam", Status = GameStatus.Finished, Rating = 4 },
        new Game { Id = 2, Title = "Old School Runescape", Platform = "Jagex Launcher", Status = GameStatus.Playing, Rating = 10, Notes = "Top 2 games in the world..." }
    ];

    private static int _nextGameId = 3;

    [HttpGet]
    public ActionResult<List<Game>> GetAll()
    {
        return Ok(_games);
    }

    [HttpGet("{id:int}")]
    public ActionResult<Game> GetById(int id)
    {
        var game = _games.FirstOrDefault(g => g.Id == id);
        if (game is null)
        {
            return NotFound("Game not found.");
        }
        return Ok(game);
    }

    [HttpPost]
    public ActionResult<Game> CreateGame(CreateGameRequest request)
    {
        var gameId = _nextGameId++;
        var game = new Game { Id = gameId, Title = request.Title, Platform = request.Platform, Status = request.Status, Rating = request.Rating, Notes = request.Notes };
        _games.Add(game);
        return CreatedAtAction(nameof(GetById), new { id = gameId }, game);
    }
}
