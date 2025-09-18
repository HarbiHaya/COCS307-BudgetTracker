namespace BudgetTracker.App.Models;
public abstract class Transaction
{
    public DateTime Date { get; init; }
    public string Description { get; init; } = "";
    public decimal Amount { get; init; }
    public string Category { get; init; } = "";
    public abstract string Type { get; }
}
