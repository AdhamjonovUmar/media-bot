using Microsoft.EntityFrameworkCore;

namespace media_bot.Entities;

public class BotDbContext : DbContext
{
    public DbSet<User> Users { get; set; }

    public BotDbContext(DbContextOptions<BotDbContext> options): base(options) {}
}