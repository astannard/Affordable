using System;
using System.Collections.Generic;
using System.Linq;
using Affordable;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AffordableCalcTest
{
    [TestClass]
    public class SummaryTest
    {
        [TestMethod]
        public void CorrectlySummarises()
        {
            var bankStatement = FakeStatementImporter.GetBankStatement();
            var spottedRecurring = RecurringItemsSpotter.FindRecurring(bankStatement)
                .OrderBy(bs => bs.Description);

            var summary = StatementSummariser.GetSummary(spottedRecurring);
            Assert.AreEqual(545.00m, summary.TotalExpenses);
            Assert.AreEqual(5000.00m, summary.TotalIncome);
        }


        
    }
}
