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
}
