using System;
namespace Affordable
{
    public class BankStatementItem
    {
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public decimal AmountIn { get; set; }
        public decimal AmountOut { get; set; }
        public TransactionType type { get; set; }
    }

    public enum TransactionType
    {

    }
}
