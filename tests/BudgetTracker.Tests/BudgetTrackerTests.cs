using BudgetTracker.App.Services;
using Xunit;
public class BudgetTrackerTests {
    [Fact] public void Compiles(){ var bt=new BudgetTracker(); Assert.NotNull(bt); }
}
