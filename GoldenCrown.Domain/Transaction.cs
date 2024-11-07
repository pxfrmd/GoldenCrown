namespace GoldenCrown.Domain;

public class Transaction
{
    private int transactionId { get; set; }
    private int senderId { get; set; }
    private int receiverId { get; set; }
    private decimal amount { get; set; }
    private DateTime date { get; set; }
}