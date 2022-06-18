using Microsoft.AspNetCore.Mvc;
using MoneyService.Dto;
using MoneyService.Services;

namespace MoneyService.Controllers
{
    [Route("api/expenses")]
    public class ExpensesController
    {
        public IExpensesService ExpensesService { get; }

        public ExpensesController(IExpensesService expensesService)
        {
            ExpensesService = expensesService;
        }

        [HttpGet]
        public List<ExpenseDto> GetExpenses()
        {
            return ExpensesService.GetExpenses();
        }
    }
}
