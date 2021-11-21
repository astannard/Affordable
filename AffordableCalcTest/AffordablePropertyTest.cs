using System;
using System.Collections.Generic;
using System.Linq;
using Affordable;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AffordableCalcTest
{
    [TestClass]
    public class AffordablePropertyTest
    {
        [TestMethod]
        public void FindAffordableProperties()
        {
            var bankStatement = FakeStatementImporter.GetBankStatement();
            var affordableProperties = PropertyFinder.FindProperties(bankStatement.ToList(), GetProperties());
            Assert.AreEqual(2,affordableProperties.Count);
        }


        public List<Property> GetProperties()
        {
            var properties = new List<Property>();
            properties.Add(new Property(1, "leicester square", 5000));
            properties.Add(new Property(1, "hampton court", 4500));
            properties.Add(new Property(1, "fleet street", 2000));
            properties.Add(new Property(1, "downing street", 1000));

            return properties;

        }


        }
}
