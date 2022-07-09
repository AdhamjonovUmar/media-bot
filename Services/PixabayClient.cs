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
        
    }

    public async Task<(Photo photo, bool IsSuccess, Exception e)> GetPhotoAsync(string theme)
    {
        
    }
}