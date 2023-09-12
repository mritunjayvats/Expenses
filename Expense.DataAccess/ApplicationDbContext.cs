using Expenses.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expense.DataAccess
{ 
    public class ApplicationDbContext : DbContext 
    {
        public DbSet<ExpenseModel> ExpensesTable { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { 


        }

    }
}
