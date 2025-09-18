using BudgetTracker.App.Models;
namespace BudgetTracker.App.Storage;
public interface IStorage { IEnumerable<Transaction> Load(); void Save(IEnumerable<Transaction> txns); }
