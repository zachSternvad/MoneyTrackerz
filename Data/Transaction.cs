namespace MoneyTrackerz.Data;

public enum TransactionType
{
    Income,
    Expense
}

public class Transaction
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public DateTime Date { get; set; } = DateTime.Now;
    public string Description { get; set; } = String.Empty;
    public decimal Amount { get; set; }
    public TransactionType Type { get; set; }
}