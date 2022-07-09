using System.Text.Json.Serialization;

namespace media_bot.DTO.Video;

public class Videos
{
    [JsonPropertyName("large")]
    public Large large { get; set; }
    [JsonPropertyName("medium")]
    public Medium Medium { get; set; }
    [JsonPropertyName("small")]
    public Small Small { get; set; }
    [JsonPropertyName("tiny")]
    public Tiny Tiny { get; set; }
}