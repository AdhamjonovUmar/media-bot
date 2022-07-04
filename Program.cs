using Telegram.Bot;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<TelegramBotClient>(b => new TelegramBotClient(builder.Configuration.GetConnectionString("Token")));

var app = builder.Build();

app.Run();
