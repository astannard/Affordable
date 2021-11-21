using System;
using System.Collections.Generic;
using System.Linq;

namespace Affordable
{
    public static class RecurringItemsSpotter
    {

        public static IQueryable<BankStatementItem> FindRecurring(IQueryable<BankStatementItem> bankstatement)
        {
            var repeats = bankstatement.GroupBy(s => s.Description)
                             .Where(g => g.Count() > 1);

            var recurringItems = new List<BankStatementItem>();

            foreach(var repeater in repeats)
            {
                recurringItems.Add(bankstatement.OrderByDescending(s => s.Date)
                    .First(s => s.Description == repeater.Key));
            }   

            return recurringItems.AsQueryable();
        }
    }
}
