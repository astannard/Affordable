using System;
using System.Collections.Generic;

namespace Affordable
{
    public static class AffordabilityCalc
    {

        public static bool CanAfford(StatementRecurringSummary summary, decimal rent)
        {
            var availableCash = summary.TotalIncome - summary.TotalExpenses;
            decimal rentalTestValue = rent * 1.25m;

            return availableCash >= rentalTestValue;
        }
    }
}
