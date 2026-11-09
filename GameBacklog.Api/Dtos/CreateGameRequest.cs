using GameBacklog.Api.Models;

namespace GameBacklog.Api.Dtos;

public class CreateGameRequest
{
    public required string Title { get; set; }
    public string? Platform { get; set; }
    public GameStatus Status { get; set; }
    public int? Rating { get; set; }
    public string? Notes { get; set; }
}