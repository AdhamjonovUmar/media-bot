using Telegram.Bot;

namespace media_bot.Services;

public class Bot : BackgroundService
{
    public Bot(TelegramBotClient client, ILogger<Bot> logger, BotHandlers handlers)
    {
        
    }

    protected override Task ExecuteAsync(CancellationToken stoppingToken)
    {
        throw new NotImplementedException();
    }
}