namespace GoldenCrown.Domain;

public class Account
{
    private int accountId { get; set; }
    private int userId { get; set; }
    private decimal balance { get; set; }

    public Account(User user, decimal balance)
    {
        accountId = new Random().Next(0, int.MaxValue);
        userId = user.Id;
        this.balance = balance;
    }
    
}