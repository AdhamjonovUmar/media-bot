using System.Text.Json.Serialization;

namespace media_bot.DTO.Video;

public class Hit
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("pageURL")]
    public string PageURL { get; set; }
    [JsonPropertyName("type")]
    public string Type { get; set; }
    [JsonPropertyName("tags")]
    public string Tags { get; set; }
    [JsonPropertyName("duration")]
    public int Duration { get; set; }
    [JsonPropertyName("pictureId")]
    public string PictureId { get; set; }
    [JsonPropertyName("videos")]
    public Videos Videos { get; set; }
    [JsonPropertyName("views")]
    public int Views { get; set; }
    [JsonPropertyName("downloads")]
    public int Downloads { get; set; }
    [JsonPropertyName("likes")]
    public int Likes { get; set; }
    [JsonPropertyName("comments")]
    public int Comments { get; set; }
    [JsonPropertyName("userId")]
    public int UserId { get; set; }
    [JsonPropertyName("user")]
    public string User { get; set; }
    [JsonPropertyName("userImageURL")]
    public string UserImageURL { get; set; }
}