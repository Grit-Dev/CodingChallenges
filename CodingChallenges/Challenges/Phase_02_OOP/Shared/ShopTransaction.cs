namespace CodingChallenges.Challenges.Phase_02_OOP.shared
{
    public class ShopTransaction
    {
        public string PlayerName {get;set;} = string.Empty;

        public string CardName {get;set;} = string.Empty;

        public string TransactionType {get;set;} = string.Empty;

        public int Amount {get;set;}

        public ShopTransaction()
        {
        }
        public ShopTransaction(string pPlayName, string pCardName, string pTransactionType, int pAmount)
        {
            PlayerName = pPlayName;
            CardName = pCardName;
            TransactionType = pTransactionType;
            Amount = pAmount;
        }
    }
}