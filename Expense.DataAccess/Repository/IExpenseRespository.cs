using Expenses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expense.DataAccess.Repository
{
    public interface IExpenseRespository
    {
        IEnumerable<ExpenseModel> GetAllExpenses();
        
        IEnumerable<ExpenseModel> Serach(String sreachString);

        void Add(ExpenseModel expense);

        int Update(ExpenseModel expense);

        ExpenseModel GetExpenseById(int id);

        void Delete(ExpenseModel expense);

    }
}
