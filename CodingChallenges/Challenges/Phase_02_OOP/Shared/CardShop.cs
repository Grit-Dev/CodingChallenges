namespace CodingChallenges.Challenges.Phase_02_OOP.shared
{
    public class CardShop
    {
        public List<Card> Inventory { get; } = [];

        public List<ShopTransaction> Transactions { get; } = [];

        public bool HasTransactions() => Transactions.Count > 0;

        private readonly TransactionReporter _transactionReporter = new();
        private static CardShopResult CreateFailureResult(string message, string cardName, int amount) => new(false, message, cardName, amount);
        private static CardShopResult CreateSuccessResult(string message, string cardName, int amount) => new(true, message, cardName, amount);
        private bool DoesPlayerMatchRequest(Player player, string playerName)
        {
            if (player is null)
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(playerName))
            {
                return false;
            }

            return player.Name.Equals(playerName, StringComparison.OrdinalIgnoreCase);
        }

        private void RecordTransaction(Player player, Card card, string transactionType, int amount) =>
        Transactions.Add(new ShopTransaction(player.Name, card.Name, transactionType, amount));

        private Card? FindCardByName(string pCardName)
        {
            if (string.IsNullOrWhiteSpace(pCardName))
            {
                return null;
            }

            foreach (Card card in Inventory)
            {
                if (card.Name.Equals(pCardName, StringComparison.OrdinalIgnoreCase))
                {
                    return card;
                }
            }

            return null;
        }

        public int CalculateTotalTransactionValue() => _transactionReporter.CalculateTotalTransactionValue(Transactions);

        public int CalculateTotalValueByTransactionType(string pTransactionType) => _transactionReporter.CalculateTotalValueByTransactionType(Transactions, pTransactionType);

        public string BuildTransactionSummary() => _transactionReporter.BuildTransactionSummary(Transactions);

        public int CountTransactionsByType(string transactionType) => _transactionReporter.CountTransactionsByType(Transactions, transactionType);

        public ShopTransaction? FindHighestValueTransaction() => _transactionReporter.FindHighestValueTransaction(Transactions);


        public string BuildSellRequestSummary(SellCardRequest? request)
        {
            if (request is null)
            {
                return "";
            }

            return $"Player:{request.PlayerName} Card:{request.CardName}";
        }

        public string BuildBuyRequestSummary(BuyCardRequest? request)
        {
            if (request == null)
            {
                return "";
            }

            return $"Player:{request.PlayerName} Card:{request.CardName}";

        }

        public CardShopResult BuyCardFromPlayerWithRequest(Player? player, SellCardRequest? request)
        {
            if (player is null)
            {
                return new CardShopResult(false, "Player is required", "", 0);
            }

            if (request is null)
            {
                return new CardShopResult(false, "Request is required", "", 0);
            }

            if (string.IsNullOrWhiteSpace(request.PlayerName))
            {
                return new CardShopResult(false, "Player name is required", "", 0);
            }

            if (!DoesPlayerMatchRequest(player, request.PlayerName))
            {
                return new CardShopResult(false, "Player mismatch", request.CardName, 0);
            }

            if (string.IsNullOrWhiteSpace(request.CardName))
            {
                return new CardShopResult(false, "Card name is required", "", 0);
            }

            return BuyCardFromPlayerWithResult(player, request.CardName);
        }

        public CardShopResult BuyCardWithRequest(Player? player, BuyCardRequest? request)
        {
            if (player is null)
            {
                return new CardShopResult(false, "Player is required", "", 0);
            }

            if (request is null)
            {
                return new CardShopResult(false, "Request is required", "", 0);
            }

            if (string.IsNullOrWhiteSpace(request.PlayerName))
            {
                return new CardShopResult(false, "Player name is required", "", 0);
            }

            if (!DoesPlayerMatchRequest(player, request.PlayerName))
            {
                return new CardShopResult(false, "Player mismatch", request.CardName, 0);
            }

            if (string.IsNullOrWhiteSpace(request.CardName))
            {
                return new CardShopResult(false, "Card name is required", "", 0);
            }

            return BuyCardWithResult(player, request.CardName);
        }

        public void AddCard(Card card)
        {
            if (card == null)
            {
                return;
            }

            Inventory.Add(card);
        }

        public static string BuildResultSummary(CardShopResult result)
        {
            if (result == null)
            {
                return "";
            }

            return $"Success:{result.Success} Message:{result.Message} Card:{result.CardName} Amount:{result.Amount}";
        }

        public ShopTransaction? GetLastTransaction()
        {
            if (Transactions.Count == 0)
            {
                return null;
            }

            return Transactions[^1];
        }

        public CardShopResult BuyCardFromPlayerWithResult(Player player, string cardName)
        {
            if (player == null)
            {
                return CreateFailureResult(
                  "Player is required",
                  "",
                  0);
            }

            if (string.IsNullOrWhiteSpace(cardName))
            {
                return CreateFailureResult(
                  "Card name is required",
                  "",
                  0);
            }

            Card? cardFound = player.RemoveCardByName(cardName);

            if (cardFound == null)
            {
                return CreateFailureResult(
                  "Player does not own card",
                  cardName,
                  0);
            }

            int amount = cardFound.Price / 2;

            Inventory.Add(cardFound);
            player.AddCredits(amount);

            RecordTransaction(
              player,
              cardFound,
              "Sale",
              amount);

            return CreateSuccessResult(
              "Sale successful",
              cardFound.Name,
              amount);
        }

        public CardShopResult BuyCardWithResult(Player player, string cardName)
        {
            if (player == null)
            {
                return CreateFailureResult(
                  "Player is required",
                  "",
                  0);
            }

            if (string.IsNullOrWhiteSpace(cardName))
            {
                return CreateFailureResult(
                  "Card name is required",
                  "",
                  0);
            }

            Card? cardFound = FindCardByName(cardName);

            if (cardFound == null)
            {
                return CreateFailureResult(
                  "Card not found",
                  cardName,
                  0);
            }

            if (!player.BuyCard(cardFound))
            {
                return CreateFailureResult(
                  "Insufficient credits",
                  cardFound.Name,
                  cardFound.Price);
            }

            Inventory.Remove(cardFound);

            RecordTransaction(
              player,
              cardFound,
              "Purchase",
              cardFound.Price);

            return CreateSuccessResult(
              "Purchase successful",
              cardFound.Name,
              cardFound.Price);
        }

        public List<ShopTransaction> GetTransactionsByPlayerName(string pPlayerName)
        {
            if (string.IsNullOrWhiteSpace(pPlayerName))
            {
                return [];
            }

            List<ShopTransaction> listOfShopTransactions = [];

            foreach (ShopTransaction transaction in Transactions)
            {
                if (transaction.PlayerName
                .Equals(pPlayerName, StringComparison.CurrentCultureIgnoreCase))
                {
                    listOfShopTransactions.Add(transaction);
                }
            }

            return listOfShopTransactions;
        }

        public List<ShopTransaction> GetTransactionsByType(string pTransactionType)
        {
            if (string.IsNullOrWhiteSpace(pTransactionType))
            {
                return [];
            }

            List<ShopTransaction> listOfTransaction = [];

            foreach (ShopTransaction transaction in Transactions)
            {
                if (transaction.TransactionType.Equals(pTransactionType, StringComparison.OrdinalIgnoreCase))
                {
                    listOfTransaction.Add(transaction);
                }
            }

            return listOfTransaction;
        }

        public Card? FindMostValuableCardInSystem(Player? pPlayer)
        {
            Card? mostValuableCard = null;

            foreach (Card card in Inventory)
            {
                if (mostValuableCard == null || card.Price > mostValuableCard.Price)
                {
                    mostValuableCard = card;
                }
            }

            if (pPlayer != null)
            {
                foreach (Card card in pPlayer.OwnedCards)
                {
                    if (mostValuableCard == null || card.Price > mostValuableCard.Price)
                    {
                        mostValuableCard = card;
                    }
                }

                return mostValuableCard;
            }

            return mostValuableCard;
        }

        public int CountTotalCardsInSystem(Player pPlayer)
        {
            if (pPlayer == null)
            {
                return Inventory.Count;
            }

            return Inventory.Count + pPlayer.OwnedCards.Count;
        }

        public double CalculateAveragePriceByRarity(string pRarity)
        {
            if (string.IsNullOrWhiteSpace(pRarity))
            {
                return 0;
            }

            int total = 0;
            int counter = 0;

            foreach (Card card in Inventory)
            {
                if (card.Rarity.Equals(pRarity, StringComparison.OrdinalIgnoreCase))
                {
                    total += card.Price;
                    counter++;
                }
            }

            if (counter == 0)
            {
                return 0;
            }

            return (double)total / counter;


        }

        public bool BuyHighestAttackAffordableCard(Player pPlayer)
        {
            if (pPlayer == null)
            {
                return false;
            }

            Card? buyHighestAttackAffordableCard = FindHighestAttackCardPlayerCanAfford(pPlayer);

            if (buyHighestAttackAffordableCard == null)
            {
                return false;
            }

            if (!pPlayer.BuyCard(buyHighestAttackAffordableCard))
            {
                return false;
            }

            Inventory.Remove(buyHighestAttackAffordableCard);

            return true;
        }

        public int CalculateTotalInventoryValue()
        {
            int total = 0;

            foreach (Card card in Inventory)
            {
                total += card.Price;
            }

            return total;
        }

        public List<Card> FindAffordableCards(Player pPlayer)
        {
            if (pPlayer == null)
            {
                return [];
            }

            List<Card> affordableCardsList = [];

            foreach (Card card in Inventory)
            {
                if (card.Price <= pPlayer.Credits)
                {
                    affordableCardsList.Add(card);
                }
            }

            return affordableCardsList;
        }

        public Card? FindHighestAttackCardPlayerCanAfford(Player pPlayer)
        {
            if (pPlayer == null || Inventory.Count == 0)
            {
                return null;
            }

            int HighestAttack = 0;
            Card? highestAttackCardAffordable = null;
            List<Card> affordableCardsList = [];

            foreach (Card card in Inventory)
            {
                if (card.Price <= pPlayer.Credits)
                {
                    affordableCardsList.Add(card);
                }
            }

            if (affordableCardsList.Count == 0)
            {
                return null;
            }

            foreach (Card card in affordableCardsList)
            {
                if (card.Attack > HighestAttack)
                {
                    HighestAttack = card.Attack;
                    highestAttackCardAffordable = card;
                }
            }

            return highestAttackCardAffordable;
        }

        public List<Card> FindCardsByRarity(string pRarity)
        {
            if (string.IsNullOrWhiteSpace(pRarity))
            {
                return [];
            }

            List<Card> cardsList = [];

            foreach (Card card in Inventory)
            {
                if (card.Rarity.Equals(pRarity, StringComparison.OrdinalIgnoreCase))
                {
                    cardsList.Add(card);
                }
            }

            return cardsList;

        }

        public bool BuyCheapestAffordableCard(Player pPlayer)
        {
            if (pPlayer == null)
            {
                return false;
            }

            Card? cheapestCard = FindCheapestCardPlayerCanAfford(pPlayer);

            if (cheapestCard == null)
            {
                return false;
            }

            if (!pPlayer.BuyCard(cheapestCard))
            {
                return false;
            }

            Inventory.Remove(cheapestCard);

            return true;
        }

        public bool BuyCardFromPlayer(Player pPlayer, string pCardName)
        {
            if (pPlayer == null || string.IsNullOrWhiteSpace(pCardName))
            {
                return false;
            }

            Card? cardFound = pPlayer.RemoveCardByName(pCardName);

            if (cardFound == null)
            {
                return false;
            }

            Inventory.Add(cardFound);

            int total = cardFound.Price / 2;

            pPlayer.AddCredits(total);

            return true;

        }

        public bool BuyCard(Player pPlayer, string pCardName)
        {
            if (pPlayer == null || string.IsNullOrWhiteSpace(pCardName))
            {
                return false;
            }

            Card? targetedCardInInventory = FindCardByName(pCardName);

            if (targetedCardInInventory == null)
            {
                return false;
            }

            if (!pPlayer.BuyCard(targetedCardInInventory))
            {
                return false;
            }

            Inventory.Remove(targetedCardInInventory);

            Transactions.Add(new ShopTransaction(
                pPlayer.Name,
                targetedCardInInventory.Name,
                "Purchase",
                targetedCardInInventory.Price));

            return true;
        }

        public bool HasCard(string pCardName)
        {
            if (string.IsNullOrWhiteSpace(pCardName))
            {
                return false;
            }

            Card? targetedCardInInventory = FindCardByName(pCardName);

            if (targetedCardInInventory == null)
            {
                return false;
            }

            return true;
        }

        public int CountCardsByRarity(string pRarity)
        {
            if (string.IsNullOrWhiteSpace(pRarity))
            {
                return 0;
            }

            int counter = 0;

            foreach (Card card in Inventory)
            {
                if (card.Rarity.Equals(pRarity, StringComparison.OrdinalIgnoreCase))
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