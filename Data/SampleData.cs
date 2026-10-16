// All the site's content is hardcoded here. No database.
public static class SampleData
{
    public static readonly List<PhotoPackage> Packages = new()
    {
        new()
        {
            Id = 1, Name = "Stills", Tagline = "Photographs only. Quiet, honest frames.",
            IncludesVideo = false, BasePrice = 1500, HourlyRate = 2500
        },
        new()
        {
            Id = 2, Name = "Stills + Motion", Tagline = "Photographs and a short film of your day.",
            IncludesVideo = true, BasePrice = 2500, HourlyRate = 4000
        },
        new()
        {
            Id = 3, Name = "Full Story", Tagline = "Photographs, film, and a printed keepsake.",
            IncludesVideo = true, BasePrice = 4000, HourlyRate = 5500
        }
    };

    public static readonly List<ShootSpot> Spots = new()
    {
        new()
        {
            Id = 1, Name = "Train Window Portraits", Mood = "quiet commute", DurationMinutes = 60,
            Description = "Soft window light and passing scenery, shot on a slow ride."
        },
        new()
        {
            Id = 2, Name = "Sunrise at the Crossing", Mood = "first light", DurationMinutes = 45,
            Description = "The rail crossing at dawn: long shadows and a still town."
        },
        new()
        {
            Id = 3, Name = "Wheat Field Wander", Mood = "golden hour", DurationMinutes = 90,
            Description = "Walk through tall grass while the sun drops behind the hills."
        },
        new()
        {
            Id = 4, Name = "Sunflower Rows", Mood = "midday warmth", DurationMinutes = 60,
            Description = "Bright, honest frames among the flowers, with no stiff poses."
        },
        new()
        {
            Id = 5, Name = "Old Town Evening Walk", Mood = "blue hour", DurationMinutes = 75,
            Description = "Lantern light and quiet streets as the day winds down."
        },
        new()
        {
            Id = 6, Name = "Rooftop Dusk", Mood = "last light", DurationMinutes = 45,
            Description = "Clouds, wires, and the sky turning colour above the city."
        }
    };
}
