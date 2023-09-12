using Expense.DataAccess.Repository;
using Expenses.Models;
using Microsoft.AspNetCore.Mvc;

namespace Expenses.Web.Controllers
{
    public class ExpensesController : Controller
    {
        private readonly IExpenseRespository _expenses;

        public ExpensesController(IExpenseRespository expenses)
        {
            _expenses = expenses;
        }

        [HttpPost]
        public IActionResult AddDetails(ExpenseModel models)
        {
            _expenses.Add(models);
            var expensesList = _expenses.GetAllExpenses();
            return View("List", expensesList);
        }

        public IActionResult NavigateToOtherView()
        {
            return View("Index");
        }

        public IActionResult Index() 
        {
            var expensesList = _expenses.GetAllExpenses();
            return View("List", expensesList);
        }
    }
}
