namespace CodingChallenges.Challenges.Phase_02_OOP.shared
{
    public class BuyCardRequest
    {
        public string PlayerName {get;set;} = string.Empty;

        public string CardName {get;set;} = string.Empty;

        public BuyCardRequest()
        {
        }

        public BuyCardRequest(string playerName, string cardName)
        {
            PlayerName = playerName;
            CardName = cardName;
        }


    }
}