namespace GoldenCrown.Domain;

public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }

    public User(string username, string login, string password)
    { 
        Username = username;
        Login = login;
        Password = password;
        Id = new Random().Next(0, int.MaxValue);
    }
}