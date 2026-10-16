// All the site's content is hardcoded here. No database.
public static class SampleData
{
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
