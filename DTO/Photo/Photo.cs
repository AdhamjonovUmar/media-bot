using System.Text.Json.Serialization;

namespace media_bot.DTO.Photo;

public class Photo
{
    [JsonPropertyName("total")]
    public int Total { get; set; }

    [JsonPropertyName("totalHits")]
    public int TotalHits { get; set; }
    
    [JsonPropertyName("hits")]
    public List<Hit> Hits { get; set; }
}