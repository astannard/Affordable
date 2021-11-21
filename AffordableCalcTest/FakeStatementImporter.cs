//Given time I would have this implementing an interface and configure DI to use this version in tests 
using System;
using System.Collections.Generic;
using System.Linq;
using Affordable;

namespace AffordableCalcTest
{
    public static class FakeStatementImporter
    {
        public static IQueryable<BankStatementItem> GetBankStatement()
        {
            var bankStatement = new List<BankStatementItem>();
            bankStatement.Add(new BankStatementItem
            {
                Date = new DateTime(2021, 01, 01),
                Description = "London flat",
                AmountIn = 0,
                AmountOut = 500.00m
            });

            bankStatement.Add(new BankStatementItem
            {
                Date = new DateTime(2021, 01, 02),
                Description = "Curry",
                AmountIn = 0,
                AmountOut = 50.00m
            });

            bankStatement.Add(new BankStatementItem
            {
                Date = new DateTime(2021, 01, 05),
                Description = "Gym",
                AmountIn = 0,
                AmountOut = 35.00m
            });

            bankStatement.Add(new BankStatementItem
            {
                Date = new DateTime(2021, 01, 30),
                Description = "Wage",
                AmountIn = 5000,
                AmountOut = 0
            });

            bankStatement.Add(new BankStatementItem
            {
                Date = new DateTime(2021, 02, 01),
                Description = "London flat",
                AmountIn = 0,
                AmountOut = 510.00m
            });

            bankStatement.Add(new BankStatementItem
            {
                Date = new DateTime(2021, 02, 05),
                Description = "Gym",
                AmountIn = 0,
                AmountOut = 35.00m
            });

            bankStatement.Add(new BankStatementItem
            {
                Date = new DateTime(2021, 02, 05),
                Description = "Pizza",
                AmountIn = 0,
                AmountOut = 15.00m
            });

            bankStatement.Add(new BankStatementItem
            {
                Date = new DateTime(2021, 02, 28),
                Description = "Wage",
                AmountIn = 5000,
                AmountOut = 0m
            });

            return bankStatement.AsQueryable();
        }
    }
}
