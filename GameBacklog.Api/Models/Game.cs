namespace GameBacklog.Api.Models;

public class Game
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public string? Platform { get; set; }
    public GameStatus Status { get; set; }
    public int? Rating { get; set; }
    public string? Notes { get; set; }
    public DateTime DateAdded { get; set; } = DateTime.UtcNow;
}   