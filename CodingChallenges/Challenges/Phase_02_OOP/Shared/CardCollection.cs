namespace CodingChallenges.Challenges.Phase_02_OOP.shared
{
    public class CardCollection
    {
        public List<Card> Cards { get; } = [];

        public void AddCard(Card card)
        {
            if (card == null)
            {
                return;
            }

            Cards.Add(card);
        }

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

        public List<Card> FindCardsByRarity(string rarity)
        {
            if (string.IsNullOrWhiteSpace(rarity))
            {
                return [];
            }

            List<Card> matchingCards = [];

            foreach (Card card in Cards)
            {
                if (card.Rarity.Equals(
                    rarity,
                    StringComparison.OrdinalIgnoreCase))
                {
                    matchingCards.Add(card);
                }
            }

            return matchingCards;
        }

        public bool RemoveCardByName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return false;
            }

            for (int index = 0; index < Cards.Count; index++)
            {
                if (Cards[index].Name.Equals(
                    name,
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