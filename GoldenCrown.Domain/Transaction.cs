namespace GoldenCrown.Domain;

public class Transaction
{
    public int TransactionId { get; }
    public int SenderId { get; }
    public int ReceiverId { get; }
    public decimal Amount { get; }
    DateTime Date;

    public Transaction(User senderId, User receiverId, decimal amount)
    {
        TransactionId = new Random().Next(0, int.MaxValue);
        SenderId = senderId.Id;
        ReceiverId = receiverId.Id;
        Amount = amount;
        Date = DateTime.Now;
    }
}
