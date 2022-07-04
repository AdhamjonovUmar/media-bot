using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace media_bot.Services;

public class BotHandlers
{
    private readonly ILogger<BotHandlers> _logger;

    public BotHandlers(ILogger<BotHandlers> logger)
    {
        _logger = logger;
    }

    public Task HandleErrorAsync(ITelegramBotClient client, Exception exception, CancellationToken ctoken)  
    {
        var errorMessage = exception switch
        {
            ApiRequestException => $"Error occured with Telegram Client: {exception.Message}",
            _ => exception.Message
        };
        _logger.LogCritical(errorMessage);
        return Task.CompletedTask;
    } 

    public async Task HandleUpdateAsync(ITelegramBotClient client, Update update, CancellationToken ctoken)
    {
        var handler = update.Type switch
        {
            UpdateType.Message => BotOnMessageRecieved(client, update.Message),
            
        };
    }
}