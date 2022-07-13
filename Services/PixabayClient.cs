using System.Text.Json;
using media_bot.DTO.Photo;
using media_bot.DTO.Video;

namespace media_bot.Services;

public class PixabayClient
{
    private readonly HttpClient _client;
    private readonly ILogger<PixabayClient> _logger;

    public PixabayClient(HttpClient client, ILogger<PixabayClient> logger)
    {
        _client = client;
        _logger = logger;
    }

    public async Task<(Video video, bool IsSuccess, Exception e)> GetVideoAsync(string theme)
    {
        theme = theme.Replace(" ", "+");
        var query = $"videos/?key=28518000-50df4de24956c7d54939e78d7={theme}&pretty=true";
        using var httpResponse = await _client.GetAsync(query);
        if(httpResponse.IsSuccessStatusCode)
        {
            var json = await httpResponse.Content.ReadAsStringAsync();
            var data = JsonSerializer.Deserialize<Video>(json);
            return (data, true, null);
        }
        
    }

    public async Task<(Photo photo, bool IsSuccess, Exception e)> GetPhotoAsync(string theme)
    {
        
    }
}