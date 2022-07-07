using media_bot.Entities;
using media_bot.Services;
using Microsoft.EntityFrameworkCore;
using Telegram.Bot;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<BotDbContext>(
    options => {
        options.UseSqlite(builder.Configuration.GetConnectionString("DbConnection"));
    },
    ServiceLifetime.Singleton);

builder.Services.AddSingleton<TelegramBotClient>(b => new TelegramBotClient(builder.Configuration.GetConnectionString("Token")));
builder.Services.AddHostedService<Bot>();
builder.Services.AddTransient<BotHandlers>();

var app = builder.Build();

app.Run();
