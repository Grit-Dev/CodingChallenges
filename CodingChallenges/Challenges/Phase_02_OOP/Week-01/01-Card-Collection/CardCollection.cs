namespace CodingChallenges.Challenges.Phase_02_OOP.Week_01._01_Card_Collection
{
    public class CardCollection : Card
    {
        public List<Card> Cards { get; } = [];

        public Card? FindHighestAttackCard()
        {
            int highestAttack = int.MinValue;
            Card highestCard = new();

            if (Cards.Count == 0)
            {
                return null;
            }

            foreach (Card card in Cards)
            {
                if (card.Attack > highestAttack)
                {
                    highestAttack = card.Attack;
                    highestCard = card;
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
