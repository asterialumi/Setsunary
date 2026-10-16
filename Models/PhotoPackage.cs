// What the visitor is buying. The price depends on the package AND the chosen spots.
public class PhotoPackage
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Tagline { get; set; }
    public bool IncludesVideo { get; set; }
    public decimal BasePrice { get; set; }
    public decimal HourlyRate { get; set; }
}
