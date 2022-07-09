using System.Text.Json.Serialization;

namespace media_bot.DTO.Video;

public class Video
{
    [JsonPropertyName("total")]
    public int Total { get; set; }
    [JsonPropertyName("totalHits")]
    public int TotalHits { get; set; }
    [JsonPropertyName("hits")]
    public List<Hit> Hits { get; set; }
}