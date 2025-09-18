using BudgetTracker.App.Models;

namespace BudgetTracker.App.Storage;

public class CsvStorage : IStorage
{
    private string filePath;

    public CsvStorage(string path)
    {
        filePath = path;
    }

    public IEnumerable<Transaction> Load()
    {
        // later: check file, read lines, parse
        return new List<Transaction>();
    }

    public void Save(IEnumerable<Transaction> transactionsList)
    {
        // later: open file, write header + rows
    }
}
