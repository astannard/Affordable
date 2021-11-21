using System;
using System.Collections.Generic;
using System.Linq;
using Affordable;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AffordableCalcTest
{
    [TestClass]
    public class RecurringItemsTest
    {
        [TestMethod]
        public void SpottsRecurringItems()
        {
            var bankStatement = FakeStatementImporter.GetBankStatement();
            var spottedRecurring = RecurringItemsSpotter.FindRecurring(bankStatement)
                .OrderBy(bs => bs.Description);

            Assert.AreEqual(3, spottedRecurring.Count());
            Assert.AreEqual("Gym", spottedRecurring.ToArray()[0].Description);
            Assert.AreEqual("London flat", spottedRecurring.ToArray()[1].Description);
            Assert.AreEqual("Wage", spottedRecurring.ToArray()[2].Description);
        }

        [TestMethod]
        public void UsesLatestCost()
        {
            var bankStatement = FakeStatementImporter.GetBankStatement();
            var spottedRecurring = RecurringItemsSpotter.FindRecurring(bankStatement)
                .OrderBy(bs => bs.Description);

            Assert.AreEqual(510.00m, spottedRecurring.ToArray()[1].AmountOut);
        }

    }
}
