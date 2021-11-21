using System;
using System.Collections.Generic;
using System.Linq;
using Affordable;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AffordableCalcTest
{
    [TestClass]
    public class AffordabilityCalcTests
    {
        [TestMethod]
        public void AfforableTest()
        {
            var summary = new StatementRecurringSummary
            {
                TotalExpenses = 535.00m,
                TotalIncome = 5000.00m
            };

            var affordable = AffordabilityCalc.CanAfford(summary, 600.00m);
            Assert.AreEqual(true, affordable);
        }

        [TestMethod]
        public void UnafforableTest()
        {
            var summary = new StatementRecurringSummary
            {
                TotalExpenses = 535.00m,
                TotalIncome = 1000.00m
            };

            var affordable = AffordabilityCalc.CanAfford(summary, 800.00m);
            Assert.AreEqual(false, affordable);
        }


    }
}
