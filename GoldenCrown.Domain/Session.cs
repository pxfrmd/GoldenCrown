namespace GoldenCrown.Domain;

public class Session
{   
    public int UserId { get;}
    public string token { get; set; }
    public DateTime timeOfSession { get;}
    public DateTime sessionExpiresOn { get; }

    public Session(User user)
    {
        UserId = user.Id;
        token = "someRandomToken";
        timeOfSession = DateTime.Now;
        sessionExpiresOn = timeOfSession.AddHours(1);
    }

}

