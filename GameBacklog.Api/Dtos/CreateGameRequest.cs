using System.ComponentModel.DataAnnotations;
using GameBacklog.Api.Models;

namespace GameBacklog.Api.Dtos;

public class CreateGameRequest
{
    [Required(ErrorMessage = "Title must not be empty.")]
    public required string Title { get; set; }

    public string? Platform { get; set; }
    public GameStatus Status { get; set; }

    [Range(1, 10, ErrorMessage = "{0} must be between {1} and {2}.")]
    public int? Rating { get; set; }

    public string? Notes { get; set; }
}