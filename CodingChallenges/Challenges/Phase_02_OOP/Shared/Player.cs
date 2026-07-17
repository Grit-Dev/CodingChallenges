namespace CodingChallenges.Challenges.Phase_02_OOP.shared
{
    public class Player
    {
        public string Name { get; set; } = string.Empty;

        public int Credits { get; private set; }

        public List<Card> OwnedCards { get; } = [];

        public Player()
        {
        }

        public Player(string name, int credits)
        {
            Name = name;
            Credits = credits;
        }

        public void AddCredits(int amount)
        {
            if (amount <= 0)
            {
                return;
            }

            Credits += amount;
        }

        public bool TrySpendCredits(int amount)
        {
            if (amount <= 0)
            {
                return false;
            }

            if (Credits < amount)
            {
                return false;
            }

            Credits -= amount;
            return true;
        }

        public void AddCard(Card card)
        {
            if (card == null)
            {
                return;
            }

            OwnedCards.Add(card);
        }

        public Card? FindStrongestCard()
        {
            if (OwnedCards.Count == 0)
            {
                return null;
            }

            Card strongestCard = OwnedCards[0];

            for (int index = 1; index < OwnedCards.Count; index++)
            {
                if (OwnedCards[index].Attack > strongestCard.Attack)
                {
                    strongestCard = OwnedCards[index];
                }
            }

            return strongestCard;
        }

        public bool BuyCard(Card card)
        {
            if (card == null)
            {
                return false;
            }

            if (!TrySpendCredits(card.Price))
            {
                return false;
            }

            OwnedCards.Add(card);
            return true;
        }

        public bool TransferCardTo(
            string cardName,
            Player receivingPlayer)
        {
            if (string.IsNullOrWhiteSpace(cardName))
            {
                return false;
            }

            if (receivingPlayer == null)
            {
                return false;
            }

            for (int index = 0; index < OwnedCards.Count; index++)
            {
                Card currentCard = OwnedCards[index];

                if (currentCard.Name.Equals(
                    cardName,
                    StringComparison.OrdinalIgnoreCase))
                {
                    OwnedCards.RemoveAt(index);
                    receivingPlayer.AddCard(currentCard);

                    return true;
                }
            }

            return false;
        }
    }
}