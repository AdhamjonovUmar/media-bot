using Telegram.Bot.Types.ReplyMarkups;

namespace media_bot.Services;

public class Buttons
{
    public static IReplyMarkup Choices()
        => new ReplyKeyboardMarkup(new List<List<KeyboardButton>>()
        {
            new List<KeyboardButton>()
            {
                new KeyboardButton("Video"){},
                new KeyboardButton("Photo"){}
            }
        })
        {
            ResizeKeyboard = true
        };
}