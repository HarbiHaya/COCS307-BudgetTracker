using System.Globalization;
using BudgetTracker.App.Models;
namespace BudgetTracker.App.Storage;
public sealed class CsvStorage(string path) : IStorage
{
    private readonly string _path = path;
    public IEnumerable<Transaction> Load(){ if(!File.Exists(_path)) yield break; foreach(var _ in new string[0]) yield break; }
    public void Save(IEnumerable<Transaction> txns){ Directory.CreateDirectory(Path.GetDirectoryName(_path)!); using var sw=new StreamWriter(_path,false); sw.WriteLine("Date,Type,Description,Category,Amount"); }
}
