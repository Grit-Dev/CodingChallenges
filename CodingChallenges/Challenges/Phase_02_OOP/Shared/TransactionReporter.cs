using CodingChallenges.Challenges.Phase_02_OOP.shared;
using Microsoft.VisualBasic;

namespace CodingChallenges.Challenges.Phase_02_OOP
{
    public class TransactionReporter
    {
        public int CalculateTotalTransactionValue(List<ShopTransaction> transactions)
        {
            if(transactions is null || transactions.Count == 0)
            {
                return 0;
            }

            int total = 0;

            foreach(var value in transactions)
            {
                total += value.Amount;
            }
            
            return total;
        }

        public int CalculateTotalValueByTransactionType(List<ShopTransaction> transactions, string transactionType)
        {
            if(transactions is null || transactions.Count == 0)
            {
                return 0;
            }

            int total = 0;

            if(string.IsNullOrWhiteSpace(transactionType))
            {
                return 0;
            }

            foreach(var value in transactions)
            {
                if(value.TransactionType.Equals(transactionType, StringComparison.OrdinalIgnoreCase))
                {
                    total += value.Amount;
                }
            }

            return total;
        }

        public ShopTransaction? FindHighestValueTransaction(List<ShopTransaction> transactions)
        {
            if(transactions is null || transactions.Count == 0)
            {
                return null;
            }

            ShopTransaction? HighestTransaction = transactions[0];

            foreach(var value in transactions)
            {
                if(value.Amount > HighestTransaction.Amount)
                {
                    HighestTransaction = value;
                }
            }

            return HighestTransaction;
        }
    }
}