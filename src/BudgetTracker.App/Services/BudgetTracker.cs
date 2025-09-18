using BudgetTracker.App.Models;
namespace BudgetTracker.App.Services;
public sealed class BudgetTracker
{
    private readonly List<Transaction> _txns = new();
    public IReadOnlyList<Transaction> All => _txns;
    public void Load(IEnumerable<Transaction> items){ _txns.Clear(); _txns.AddRange(items); }
    public void AddIncome(DateTime d,string desc,decimal a,string c)=>_txns.Add(new Income{Date=d,Description=desc,Amount=a,Category=c});
    public void AddExpense(DateTime d,string desc,decimal a,string c)=>_txns.Add(new Expense{Date=d,Description=desc,Amount=a,Category=c});
}
