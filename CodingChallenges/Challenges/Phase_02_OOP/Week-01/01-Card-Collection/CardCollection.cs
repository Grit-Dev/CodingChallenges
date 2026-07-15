namespace CodingChallenges.Challenges.Phase_02_OOP.Week_01._01_Card_Collection
{
    public class CardCollection : Card
    {
        public List<Card> Cards = [];

        public Card? FindHighestAttackCard()
        {
            int highestAttack = int.MinValue;
            Card highestCard = new();

            if (cards.Count == 0)
            {
                return null;
            }

            foreach (Card card in cards)
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

            cards.Add(pAddCard);
        }

        public List<Card> FindCardsByRarity(string pRarity)
        {
            if (string.IsNullOrEmpty(pRarity))
            {
                return [];
            }

            List<Card> cardListsWithRarity = new();

            foreach (Card card in cards)
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

            for (int index = 0; index < cards.Count; index++)
            {
                if (cards[index].Name.Equals(
                    pName,
                    StringComparison.OrdinalIgnoreCase))
                {
                    cards.RemoveAt(index);
                    return true;
                }
            }

            return false;
        }

        public double CalculateAverageAttack()
        {
            if (cards.Count == 0)
            {
                return 0;
            }

            int total = 0;

            foreach (Card card in cards)
            {
                total += card.Attack;
            }

            return (double)total / cards.Count;
        }
    }
}
