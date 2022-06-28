using Microsoft.AspNetCore.Mvc;
using MoneyService.Dto;
using MoneyService.Services;

namespace MoneyService.Controllers
{
    [ApiController]
    [Route("api/expenses")]
    public class ExpensesController : ControllerBase
    {
        public IExpensesService ExpensesService { get; }

        public ExpensesController(IExpensesService expensesService)
        {
            ExpensesService = expensesService;
        }

        [HttpGet]
        public List<ExpenseDto> GetExpenses()
        {
            return ExpensesService.GetExpenses().Select(e => new ExpenseDto(e.Name, e.Cost)).ToList();
        }

        [HttpPost]
        public void CreateExpense(ExpenseDto expense)
        {
            ExpensesService.CreateExpense(expense);
            Ok();
        }
    }
}
