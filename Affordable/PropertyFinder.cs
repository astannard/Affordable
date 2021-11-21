using System;
using System.Linq;
using System.Collections.Generic;

namespace Affordable
{
    public static class PropertyFinder
    {

        public static List<Property> FindProperties(List<BankStatementItem> bankStatement, List<Property> properties)
        {
            var query = properties.AsQueryable();
            var statementSummary = StatementSummariser.GetSummary(RecurringItemsSpotter.FindRecurring(bankStatement.AsQueryable()));
            var affordableProperties =  query.Where(p => AffordabilityCalc.CanAfford(statementSummary, p.RentPerMonthPence) == true);
            return affordableProperties.ToList();
        }
    }
}
