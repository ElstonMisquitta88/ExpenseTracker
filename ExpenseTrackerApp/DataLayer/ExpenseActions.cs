using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ExpenseActions : IExpenseActions
    {
        private readonly ISqlDataAccess _db;
        public ExpenseActions(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<ExpenseDetail>> GetExpenseDetails()
        {
            string sql = "GetExpenseDetails"; //TODO  -- Add Parameters to filter data
            return _db.LoadData<ExpenseDetail, dynamic>(sql, new { });
        }

        public Task AddExpenseDetails(ExpenseDetail _param)
        {
            var sql = "EXEC Proc_AddList @TaskName";
            // TODO
            // var values = new { TaskName = _param.TaskName };
            var values = "";
            return _db.SaveData(sql, values);
        }
    }
}
