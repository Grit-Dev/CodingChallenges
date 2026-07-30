namespace CodingChallenges.Challenges.Phase_02_OOP.shared
{
    public class SellCardRequest
    {
        public string PlayerName {get;set;} = string.Empty;

        public string CardName {get;set;} = string.Empty;

        public SellCardRequest()
        {
        }

        public SellCardRequest(string playerName, string cardName)
        {
            PlayerName = playerName;
            CardName = cardName;
        }
    }
}