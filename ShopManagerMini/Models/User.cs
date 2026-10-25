namespace ShopManagerMini.Models;

public class User
{
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string FullName { get; set; } = string.Empty;
    public string Role { get; set; } = string.Empty;

    public User() { }

    public User(string username, string password, string fullName, string role)
    {
        Username = username;
        Password = password;
        FullName = fullName;
        Role = role;
    }
}
