using Expenses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expense.DataAccess.Repository
{ 
    public class ExpenseRespository : IExpenseRespository
    {

        public readonly ApplicationDbContext _context;

        public ExpenseRespository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(ExpenseModel expense)
        {
            try
            {
                _context.ExpensesTable.Add(expense);
                _context.SaveChanges();
            }
            catch(Exception ex) {
                throw;
            }
        }

        public void Delete(ExpenseModel expense)
        {
            try
            {
                _context.ExpensesTable.Remove(expense);
            } 
            catch(Exception ex) { }
        }

        public IEnumerable<ExpenseModel> GetAllExpenses()
        {
            try
            {
                var expenses = _context.ExpensesTable.ToList();
                return expenses;
            }
            catch(Exception ex) {
                throw;
            }
        }

        public ExpenseModel GetExpenseById(int id)
        {
            try
            {
                var Expense = _context.ExpensesTable.Find(id);
                return Expense;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public IEnumerable<ExpenseModel> Serach(string sreachString)
        {
            try
            {
                var searchVal = GetAllExpenses().Where(x => x.Title.Contains("sreachString"));
                return searchVal;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public int Update(ExpenseModel expense)
        {
            try
            {
                _context.Entry(expense).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();
                return 1;
            }
            catch {
                throw;
            }
        }
    }
}
