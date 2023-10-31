using System.ComponentModel.DataAnnotations;

namespace GameStore.Api.Dtos;

public record GameDto(
    int Id,
    string Name,
    string Genre,
    decimal Price,
    DateTime ReleaseDate,
    string? ImageUri
    );

public record CreateGameDto(
    [Required][StringLength(50)] int Id,
    [Required][StringLength(20)] string Name,
    [Range(1, 100)] string Genre,
    decimal Price,
    DateTime ReleaseDate,
    [Url][StringLength(100)] string? ImageUri
    );

public record UpdateGameDto(
    [Required][StringLength(50)] int Id,
    [Required][StringLength(20)] string Name,
    [Range(1, 100)] string Genre,
    decimal Price,
    DateTime ReleaseDate,
    [Url][StringLength(100)] string? ImageUri
    );

