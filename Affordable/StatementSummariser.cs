using System;
using System.Linq;

namespace Affordable
{
    public static class StatementSummariser
    {
        public static StatementRecurringSummary GetSummary(IQueryable<BankStatementItem> recurringItems)
        {
            var income = recurringItems.Select(ri => ri.AmountIn).Sum();
            var expenses = recurringItems.Select(ri => ri.AmountOut).Sum();

            return new StatementRecurringSummary
            {
                TotalIncome = income,
                TotalExpenses = expenses
            };
        }
    }
}
