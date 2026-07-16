namespace CodingChallenges.Challenges.Phase_02_OOP.Week_01._01_Card_Collection
{
    public class CardCollection
    {
        public List<Card> Cards { get; } = [];

        public Card? FindHighestAttackCard()
        {
            if (Cards.Count == 0)
            {
                return null;
            }

            Card highestCard = Cards[0];

            for (int index = 1; index < Cards.Count; index++)
            {
                if (Cards[index].Attack > highestCard.Attack)
                {
                    highestCard = Cards[index];
                }
            }

            return highestCard;
        }

        public void AddCard(Card pAddCard)
        {
            if (pAddCard == null)
            {
                throw new ArgumentNullException(nameof(pAddCard));
            }

            Cards.Add(pAddCard);
        }
        z

        public List<Card> FindCardsByRarity(string pRarity)
        {
            if (string.IsNullOrEmpty(pRarity))
            {
                return [];
            }

            List<Card> cardListsWithRarity = new();

            foreach (Card card in Cards)
            {
                if (card.Rarity.Equals(pRarity, StringComparison.OrdinalIgnoreCase))
                {
                    cardListsWithRarity.Add(card);
                }
            }

            return cardListsWithRarity;
        }

        public bool RemoveCardByName(string pName)
        {
            if (string.IsNullOrEmpty(pName))
            {
                return false;
            }

            for (int index = 0; index < Cards.Count; index++)
            {
                if (Cards[index].Name.Equals(
                    pName,
                    StringComparison.OrdinalIgnoreCase))
                {
                    Cards.RemoveAt(index);
                    return true;
                }
            }

            return false;
        }

        public double CalculateAverageAttack()
        {
            if (Cards.Count == 0)
            {
                return 0;
            }

            int total = 0;

            foreach (Card card in Cards)
            {
                total += card.Attack;
            }

            return (double)total / Cards.Count;
        }
    }
}
