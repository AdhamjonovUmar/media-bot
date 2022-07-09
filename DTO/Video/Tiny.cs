using System.Text.Json.Serialization;

namespace media_bot.DTO.Video;
public class Tiny
{
    [JsonPropertyName("url")]
    public string url { get; set; }
    public int width { get; set; }
    public int height { get; set; }
    public int size { get; set; }
}
