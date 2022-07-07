using System.ComponentModel.DataAnnotations;

namespace media_bot.Entities;

public class User
{
    [Key]
    public long ChatId { get; set; }
    
    public string Username { get; set; }
    
    public string Fullname { get; set; }
    
    public string ContentType { get; set; }
    
    public bool InProcess { get; set; }

    [Obsolete("Used only entity binding.")]
    public User() { }
    public User(long chatId, string username, string fullname)
    {
        ChatId = chatId;
        Username = username;
        Fullname = fullname;
        ContentType = string.Empty;
        InProcess = false;
    }
}