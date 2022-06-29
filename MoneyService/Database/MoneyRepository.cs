using MoneyService.Database.Entities;

namespace MoneyService.Database
{
    public class MoneyRepository : IMoneyRepository
    {
        private readonly IMoneyContext moneyContext;

        public MoneyRepository(IMoneyContext moneyContext)
        {
            this.moneyContext = moneyContext;
        }

        public List<ExpenseEntity> GetExpenses()
        {
            return moneyContext.Expenses.ToList();
        }

        public void CreateExpense(ExpenseEntity expense)
        {
            moneyContext.Expenses.Add(new ExpenseEntity
            {
                Name = expense.Name,
                Cost = expense.Cost
            });
            moneyContext.SaveChanges();
        }
    }
}