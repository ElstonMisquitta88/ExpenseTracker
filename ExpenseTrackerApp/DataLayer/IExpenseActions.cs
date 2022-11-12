using DataLayer.Models;

namespace DataLayer
{
    public interface IExpenseActions
    {
        Task AddExpenseDetails(ExpenseDetail _param);
        Task<List<ExpenseDetail>> GetExpenseDetails();
    }
}