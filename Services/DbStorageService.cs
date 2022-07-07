using media_bot.Entities;
using Microsoft.EntityFrameworkCore;

namespace media_bot.Services;

public class DbStorageService : IStorageService
{
    private readonly BotDbContext _context;
    private readonly ILogger<DbStorageService> _logger;

    public DbStorageService(BotDbContext context, ILogger<DbStorageService> logger)
    {
        _context = context;
        _logger = logger;
    }
    public async Task<bool> ExistAsync(long chatId)
        => await _context.Users.AnyAsync();

    public async Task<(List<User> users, bool IsSuccess, Exception exception)> GetAllAsync(User user)
        => (_context.Users.ToList<User>(), true, null);

    public async Task<(User user, bool IsSuccess, Exception exception)> GetAsync(long chatId)
    {
        try
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.ChatId == chatId);
            if(user == default) return (null, false, new Exception("User doesn't exist"));
            return (user, true, null);
        }
        catch (Exception e)
        {
            return (null, false, e);
        }
    }

    public async Task<(bool IsSuccess, Exception exception)> InsertAsync(User user)
    {
        try
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return (true,null);
        }
        catch (Exception e)
        {
            return (false, e);
        }
    }

    public async Task<(bool IsSuccess, Exception exception)> RemoveAsync(long chatId)
    {
        try
        {
            _context.Remove((await GetAsync(chatId)).user);
            await _context.SaveChangesAsync();
            return (true, null);
        }
        catch (Exception e)
        {
            return (false, e);
        }
    }

    public async Task<(bool IsSuccess, Exception exception)> UpdateAsync(User user)
    {
        try
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
            return (true, null);
        }
        catch (Exception e)
        {
            return(false, e); 
        }
    }
}