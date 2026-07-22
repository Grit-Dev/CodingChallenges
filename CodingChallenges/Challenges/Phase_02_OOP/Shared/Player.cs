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

        public bool HasCard(string pCardName)
        {
            if(string.IsNullOrWhiteSpace(pCardName))
            {
                return false;
            }

            foreach(Card card in OwnedCards)
            {
                if(card.Name.Equals(pCardName, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }

        public Card? RemoveCardByName(string pCardName)
        {
            if(string.IsNullOrWhiteSpace(pCardName))
            {
                return null;
            }

            Card? cardFound = null;
            int targetIndex = 0;

            for(int outterIndex = 0; outterIndex <= OwnedCards.Count -1; outterIndex++)
            {
                Card currentCard = OwnedCards[outterIndex];

                if(currentCard.Name.Equals(pCardName, StringComparison.OrdinalIgnoreCase))
                {
                    cardFound = currentCard;
                    targetIndex = outterIndex;
                    break;
                }
            }

            if(cardFound == null)
            {
                return null;
            }

            OwnedCards.RemoveAt(targetIndex);
            return cardFound;
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

        public bool TransferCardTo(string pCardName, Player pReceivingPlayer)
        {
            if(pCardName is null || pReceivingPlayer is null)
            {
                return false;
            }

            bool isCardFound = false;

            foreach(Card card in OwnedCards)
            {
                if(card.Name.Equals(pCardName, StringComparison.OrdinalIgnoreCase))
                {
                    OwnedCards.Remove(card);
                    pReceivingPlayer.OwnedCards.Add(card);
                    isCardFound = true;

                    break;        
                }
                else
                {
                    isCardFound = false;
                }
            }

            if(!isCardFound)
            {
                return false;
            }

            return true;
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
    }
}