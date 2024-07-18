using Microsoft.EntityFrameworkCore;

namespace HaveFun02.Models
{
    public class ExpenseContext :DbContext //繼承自DbContext
    {   #region 建構函式constructor
                
        public ExpenseContext (DbContextOption<ExpenseContext> options)
        
        #endregion
        
        #region 注入DbSet
         public DbSet <Expense> Expenses {get; set;}
        #endregion
    }
}
