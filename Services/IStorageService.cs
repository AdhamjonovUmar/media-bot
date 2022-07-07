using media_bot.Entities;

namespace media_bot.Services;

public interface IStorageService
{
    Task<(bool IsSuccess, Exception exception)> InsertAsync(User user);
    Task<(bool IsSuccess, Exception exception)> UpdateAsync(User user);
    Task<bool> ExistAsync(long chatId);
    Task<(User user, bool IsSuccess, Exception exception)> GetAsync(long chatId);
    Task<(List<User> users, bool IsSuccess, Exception exception)> GetAllAsync(User user);
    Task<(bool IsSuccess, Exception exception)> RemoveAsync(long chatId);
}