using System.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Affordable;
using CsvHelper;

namespace PropertyFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            var bankstatement = GetBankStatement();
            var properties = GetProperties();
            //So this bank statement tool is basic, It should remove current rental income from the calculation
            //as they wont be paying rent twice. The CSV tool does not work and would need to be done differently with error handling for the import 
            var found = Affordable.PropertyFinder.FindProperties(bankstatement, properties);
            foreach(var prop in found)
            {
                Console.WriteLine(prop.Address);
            }

        }

        private static List<BankStatementItem> GetBankStatement()
        {
            using (var reader = new StreamReader("../../../Files/bank_statement.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<BankStatementItem>();
                return records.ToList();
            }
        }

        private static List<Property> GetProperties()
        {
            using (var reader = new StreamReader("../../..Files/properties.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Property>();
                return records.ToList();
            }
        }
    }
}
