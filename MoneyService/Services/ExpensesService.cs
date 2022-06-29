using MoneyService.Database;
using MoneyService.Database.Entities;
using MoneyService.Dto;

namespace MoneyService.Services
{
    public class ExpensesService : IExpensesService
    {
        private readonly IMoneyRepository moneyRepository;

        public ExpensesService(IMoneyRepository moneyRepository)
        {
            this.moneyRepository = moneyRepository;
        }

        public List<ExpenseDto> GetExpenses()
        {
            return moneyRepository.GetExpenses()
                .Select(e => new ExpenseDto(e.Name, e.Cost))
                .ToList();
        }

        public void CreateExpense(ExpenseDto expense)
        {
            var expenseEntity = new ExpenseEntity
            {
                Name = expense.Name,
                Cost = expense.Cost
            };

            moneyRepository.CreateExpense(expenseEntity);
        }
    }
}