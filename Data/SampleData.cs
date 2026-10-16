// All the site's content is hardcoded here. No database.
//
// TO CHANGE A PICTURE: replace the Pexels(...) call with your own link in quotes,
// or with a file you saved in wwwroot/images, e.g. ImageUrl = "images/train.jpg"
public static class SampleData
{
    // Builds a Pexels image link from a photo's number and name. Any normal image link works too.
    private static string Pexels(long id, string slug, int width = 900) =>
        $"https://images.pexels.com/photos/{id}/pexels-photo-{id}/free-photo-of-{slug}.jpeg?auto=compress&cs=tinysrgb&w={width}";

    // Hero pictures at the top of the page.
    public static readonly string HeroMainImage = "images/header.png";
    public static readonly string HeroAccentImage = "images/accent.png";

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
            Description = "Soft window light and passing scenery, shot on a slow ride.",
            ImageUrl = "images/train.png"
        },
        new()
        {
            Id = 2, Name = "Window Seat at Sunset", Mood = "last light", DurationMinutes = 45,
            Description = "Warm light across the carriage as the day slows to a stop.",
            ImageUrl = Pexels(33873942, "young-woman-relaxing-on-train-at-sunset")
        },
        new()
        {
            Id = 3, Name = "Golden Hour on the Tracks", Mood = "golden hour", DurationMinutes = 60,
            Description = "Long shadows and empty rails, framed as the sun drops.",
            ImageUrl = "images/golden_hour.jpg"
        },
        new()
        {
            Id = 4, Name = "Wheat Field Wander", Mood = "warm twilight", DurationMinutes = 90,
            Description = "Walk through tall grass while the sun drops behind the hills.",
            ImageUrl = Pexels(33786721, "golden-wheat-field-during-sunset")
        },
        new()
        {
            Id = 5, Name = "Platform in Winter Light", Mood = "soft morning", DurationMinutes = 45,
            Description = "A quiet station, pale light, and the wait before the train.",
            ImageUrl = Pexels(35677515, "kyoto-train-station-platform-in-winter-light")
        },
        new()
        {
            Id = 6, Name = "Misty Rails", Mood = "first light", DurationMinutes = 60,
            Description = "Fog, long lines, and stillness at the edge of town.",
            ImageUrl = Pexels(36712525, "foggy-railway-tracks-leading-into-the-distance")
        }
    };
}
