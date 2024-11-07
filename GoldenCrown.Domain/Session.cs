namespace GoldenCrown.Domain;

public class Session
{
    private int userId { get; set; }
    private string token = "someRandomToken";
    private static DateTime date = DateTime.Now;
    
    private DateTime expiresOn = date.AddHours(1);
}