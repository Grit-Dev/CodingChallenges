using CodingChallenges.Challenges.Phase_02_OOP.shared;

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
    }
}