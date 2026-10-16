// A place and moment worth photographing. Kept in the global namespace on purpose,
// so every component can use it without a using line.
public class ShootSpot
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public required string Mood { get; set; }
    public int DurationMinutes { get; set; }

    // When null the card shows a placeholder instead of a photo.
    public string? ImageUrl { get; set; }
}
