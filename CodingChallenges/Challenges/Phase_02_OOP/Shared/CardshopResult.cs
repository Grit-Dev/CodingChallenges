namespace CodingChallenges.Challenges.Phase_02_OOP.shared
{
    public class CardShopResult
    {
        public bool Success {get; set;}

        public string Message {get; set;} = string.Empty;

        public string? CardName {get;set;} = string.Empty;

        public int Amount {get; set;}

        public CardShopResult()
        {     
        }

        public CardShopResult(bool success, string message, string? cardName, int amount)
        {
            Success = success;
            Message = message;
            CardName = cardName;
            Amount = amount;
        }
    }
}