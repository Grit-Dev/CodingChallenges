namespace CodingChallenges.Challenges.Phase_02_OOP.shared
{
    public class CardShop
    {
        public List<Card> Inventory { get; } = [];

        public void AddCard(Card card)
        {
            if (card == null)
            {
                return;
            }

            Inventory.Add(card);
        }

        private Card? FindCardByName(string pCardName)
        {
            if(string.IsNullOrWhiteSpace(pCardName))
            {
                return null;
            }

            foreach(Card card in Inventory)
            {
                if(card.Name.Equals(pCardName, StringComparison.OrdinalIgnoreCase))
                {
                    return card;
                }
            }

            return null;
        }    

        public double CalculateAveragePriceByRarity(string pRarity)
        {
            if(string.IsNullOrWhiteSpace(pRarity))
            {
                return 0;
            }

            int total = 0;
            int counter = 0;

            foreach(Card card in Inventory)
            {
                if(card.Rarity.Equals(pRarity, StringComparison.OrdinalIgnoreCase))
                {
                    total += card.Price;
                    counter++;
                }
            }

            if(counter == 0)
            {
                return 0;
            }

            return (double)total / counter;


        }

        public bool BuyHighestAttackAffordableCard(Player pPlayer)
        {
            if(pPlayer == null)
            {
                return false;
            }

            Card? buyHighestAttackAffordableCard = FindHighestAttackCardPlayerCanAfford(pPlayer);

            if(buyHighestAttackAffordableCard == null)
            {
                return false;
            }

            if(!pPlayer.BuyCard(buyHighestAttackAffordableCard))
            {
                return false;
            }

            Inventory.Remove(buyHighestAttackAffordableCard);

            return true;
        }

        public int CalculateTotalInventoryValue()
        {
            int total = 0;

            foreach(Card card in Inventory)
            {
                total += card.Price;
            }

            return total;
        }

        public List<Card> FindAffordableCards(Player pPlayer)
        {
            if(pPlayer == null)
            {
                return [];
            }

            List<Card> affordableCardsList = [];

            foreach(Card card in Inventory)
            {
                if(card.Price <= pPlayer.Credits)
                {
                    affordableCardsList.Add(card);
                }
            }

            return affordableCardsList;
        }

        public Card? FindHighestAttackCardPlayerCanAfford(Player pPlayer)
        {
            if(pPlayer == null || Inventory.Count == 0)
            {
                return null;
            }

            int HighestAttack = 0;
            Card? highestAttackCardAffordable = null;
            List<Card> affordableCardsList = [];

            foreach(Card card in Inventory)
            {
                if(card.Price <= pPlayer.Credits)
                {
                    affordableCardsList.Add(card);
                }
            }

            if(affordableCardsList.Count == 0)
            {
                return null;
            }

            foreach(Card card in affordableCardsList)
            {
                if(card.Attack > HighestAttack)
                {
                    HighestAttack = card.Attack;
                    highestAttackCardAffordable = card;
                }
            }

            return highestAttackCardAffordable;
        }

        public List<Card> FindCardsByRarity(string pRarity)
        {
            if(string.IsNullOrWhiteSpace(pRarity))
            {
                return [];
            }

            List<Card> cardsList = [];

            foreach(Card card in Inventory)
            {
                if(card.Rarity.Equals(pRarity, StringComparison.OrdinalIgnoreCase))
                {
                    cardsList.Add(card);
                }
            }

            return cardsList;

        }

        public bool BuyCheapestAffordableCard(Player pPlayer)
        {
            if(pPlayer == null)
            {
                return false;
            }

            Card? cheapestCard = FindCheapestCardPlayerCanAfford(pPlayer);

            if(cheapestCard == null)
            {
                return false;
            }

            if(!pPlayer.BuyCard(cheapestCard))
            {
                return false;
            }
            
            Inventory.Remove(cheapestCard);

            return true;
        }
           
        public bool BuyCard(Player pPlayer, string pCardName)
        {
            if(pPlayer == null || string.IsNullOrEmpty(pCardName) 
            || string.IsNullOrWhiteSpace(pCardName))
            {
                return false;
            }

            Card? targetedCardInInventory = FindCardByName(pCardName);

            if(targetedCardInInventory == null)
            {
                return false;
            }

            if(!pPlayer.BuyCard(targetedCardInInventory))
            {
                return false;
            }

            Inventory.Remove(targetedCardInInventory);
            return true;
        }

        public bool HasCard(string pCardName)
        {
            if(string.IsNullOrWhiteSpace(pCardName))
            {
                return false;
            }

            Card? targetedCardInInventory = FindCardByName(pCardName);

            if(targetedCardInInventory == null)
            {
                return false;
            }

            return true;
        }

        public int CountCardsByRarity(string pRarity)
        {
            if(string.IsNullOrWhiteSpace(pRarity))
            {
                return 0;
            }

            int counter = 0;

            foreach(Card card in Inventory)
            {
                if(card.Rarity.Equals(pRarity, StringComparison.OrdinalIgnoreCase))
                {   
                    counter++;
                }
            }

            return counter;
        }

        public Card? FindCheapestCardPlayerCanAfford(Player player)
        {
            if (player == null)
            {
                return null;
            }

            Card? cheapestAffordableCard = null;

            foreach (Card card in Inventory)
            {
                if (card.Price <= player.Credits)
                {
                    if (cheapestAffordableCard == null ||
                        card.Price < cheapestAffordableCard.Price)
                    {
                        cheapestAffordableCard = card;
                    }
                }
            }

            return cheapestAffordableCard;
        }
        public Card? FindMostExpensiveCard()
        {
            if (Inventory.Count == 0)
            {
                return null;
            }

            Card mostExpensiveCard = Inventory[0];

            for (int index = 1; index < Inventory.Count; index++)
            {
                if (Inventory[index].Price > mostExpensiveCard.Price)
                {
                    mostExpensiveCard = Inventory[index];
                }
            }

            return mostExpensiveCard;
        }
    }
}