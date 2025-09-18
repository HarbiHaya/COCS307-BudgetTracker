using BudgetTracker.App.Models;

namespace BudgetTracker.App.Storage;

// contract for saving and loading data
public interface IStorage
{
    IEnumerable<Transaction> Load();         // load from file
    void Save(IEnumerable<Transaction> txns); // save to file
}
