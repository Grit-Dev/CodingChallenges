using CodingChallenges.Challenges.Phase_02_OOP.shared;

namespace CodingChallenges.Challenges.Phase_02_OOP
{
    public class CardShopOperationResultChallenges
    {
        // Entry point for running the challenges
        public static void Run()
        {
            // Challenge 4 - CardShopResult class

            CardShopResult emptyResult = new();

            Console.WriteLine(emptyResult.Success == false);
            Console.WriteLine(emptyResult.Message == "");
            Console.WriteLine(emptyResult.CardName == "");
            Console.WriteLine(emptyResult.Amount == 0);

            CardShopResult purchaseResult = new(true, "Purchase successful", "Johnny Silverhand", 400);

            Console.WriteLine(purchaseResult.Success == true);
            Console.WriteLine(purchaseResult.Message == "Purchase successful");
            Console.WriteLine(purchaseResult.CardName == "Johnny Silverhand");
            Console.WriteLine(purchaseResult.Amount == 400);


            // Challenge 5 - BuyCardWithResult

            CardShop buyShop = new();
            Player buyer = new("V", 1000);

            buyShop.AddCard(new Card("Johnny Silverhand", "Iconic", 95, 400));

            CardShopResult nullPlayerBuyResult = buyShop.BuyCardWithResult(null!, "Johnny Silverhand");

            Console.WriteLine(nullPlayerBuyResult.Success == false);
            Console.WriteLine(nullPlayerBuyResult.Message == "Player is required");
            Console.WriteLine(nullPlayerBuyResult.CardName == "");
            Console.WriteLine(nullPlayerBuyResult.Amount == 0);

            CardShopResult emptyCardNameBuyResult = buyShop.BuyCardWithResult(buyer, " ");

            Console.WriteLine(emptyCardNameBuyResult.Success == false);
            Console.WriteLine(emptyCardNameBuyResult.Message == "Card name is required");
            Console.WriteLine(emptyCardNameBuyResult.CardName == "");
            Console.WriteLine(emptyCardNameBuyResult.Amount == 0);

            CardShopResult cardNotFoundBuyResult = buyShop.BuyCardWithResult(buyer, "Adam Smasher");

            Console.WriteLine(cardNotFoundBuyResult.Success == false);
            Console.WriteLine(cardNotFoundBuyResult.Message == "Card not found");
            Console.WriteLine(cardNotFoundBuyResult.CardName == "Adam Smasher");
            Console.WriteLine(cardNotFoundBuyResult.Amount == 0);

            Player poorBuyer = new("Poor", 100);

            CardShopResult insufficientCreditsResult = buyShop.BuyCardWithResult(poorBuyer, "Johnny Silverhand");

            Console.WriteLine(insufficientCreditsResult.Success == false);
            Console.WriteLine(insufficientCreditsResult.Message == "Insufficient credits");
            Console.WriteLine(insufficientCreditsResult.CardName == "Johnny Silverhand");
            Console.WriteLine(insufficientCreditsResult.Amount == 400);
            Console.WriteLine(buyShop.Transactions.Count == 0);

            CardShopResult successfulBuyResult = buyShop.BuyCardWithResult(buyer, "johnny silverhand");

            Console.WriteLine(successfulBuyResult.Success == true);
            Console.WriteLine(successfulBuyResult.Message == "Purchase successful");
            Console.WriteLine(successfulBuyResult.CardName == "Johnny Silverhand");
            Console.WriteLine(successfulBuyResult.Amount == 400);
            Console.WriteLine(buyer.HasCard("Johnny Silverhand"));
            Console.WriteLine(buyShop.Inventory.Count == 0);
            Console.WriteLine(buyShop.Transactions.Count == 1);
            Console.WriteLine(buyShop.Transactions[0].TransactionType == "Purchase");


            // Challenge 6 - BuyCardFromPlayerWithResult

            CardShop saleShop = new();
            Player seller = new("Seller", 100);

            seller.AddCard(new Card("Judy Alvarez", "Rare", 80, 200));

            CardShopResult nullPlayerSaleResult = saleShop.BuyCardFromPlayerWithResult(null!, "Judy Alvarez");

            Console.WriteLine(nullPlayerSaleResult.Success == false);
            Console.WriteLine(nullPlayerSaleResult.Message == "Player is required");
            Console.WriteLine(nullPlayerSaleResult.CardName == "");
            Console.WriteLine(nullPlayerSaleResult.Amount == 0);

            CardShopResult emptyCardNameSaleResult = saleShop.BuyCardFromPlayerWithResult(seller, " ");

            Console.WriteLine(emptyCardNameSaleResult.Success == false);
            Console.WriteLine(emptyCardNameSaleResult.Message == "Card name is required");
            Console.WriteLine(emptyCardNameSaleResult.CardName == "");
            Console.WriteLine(emptyCardNameSaleResult.Amount == 0);

            CardShopResult playerDoesNotOwnCardResult = saleShop.BuyCardFromPlayerWithResult(seller, "Adam Smasher");

            Console.WriteLine(playerDoesNotOwnCardResult.Success == false);
            Console.WriteLine(playerDoesNotOwnCardResult.Message == "Player does not own card");
            Console.WriteLine(playerDoesNotOwnCardResult.CardName == "Adam Smasher");
            Console.WriteLine(playerDoesNotOwnCardResult.Amount == 0);
            Console.WriteLine(saleShop.Transactions.Count == 0);

            CardShopResult successfulSaleResult = saleShop.BuyCardFromPlayerWithResult(seller, "judy alvarez");

            Console.WriteLine(successfulSaleResult.Success == true);
            Console.WriteLine(successfulSaleResult.Message == "Sale successful");
            Console.WriteLine(successfulSaleResult.CardName == "Judy Alvarez");
            Console.WriteLine(successfulSaleResult.Amount == 100);
            Console.WriteLine(seller.Credits == 200);
            Console.WriteLine(seller.OwnedCards.Count == 0);
            Console.WriteLine(saleShop.Inventory.Count == 1);
            Console.WriteLine(saleShop.Transactions.Count == 1);
            Console.WriteLine(saleShop.Transactions[0].TransactionType == "Sale");


            // Challenge 7 - GetLastTransaction

            CardShop lastTransactionShop = new();

            Console.WriteLine(lastTransactionShop.GetLastTransaction() == null);

            lastTransactionShop.Transactions.Add(new ShopTransaction("V", "Johnny", "Purchase", 400));
            lastTransactionShop.Transactions.Add(new ShopTransaction("V", "Judy", "Sale", 125));
            lastTransactionShop.Transactions.Add(new ShopTransaction("V", "Adam", "Purchase", 700));

            Console.WriteLine(lastTransactionShop.GetLastTransaction()?.TransactionType == "Purchase");
            Console.WriteLine(lastTransactionShop.GetLastTransaction()?.CardName == "Adam");
            Console.WriteLine(lastTransactionShop.GetLastTransaction()?.Amount == 700);
            Console.WriteLine(lastTransactionShop.Transactions.Count == 3);


            // Challenge 8 - BuildResultSummary

            CardShop summaryShop = new();

            Console.WriteLine(CardShop.BuildResultSummary(null!) == "");

            CardShopResult summaryResult = new(true, "Purchase successful", "Johnny Silverhand", 400);
            Console.WriteLine(CardShop.BuildResultSummary(summaryResult) == "Success:True Message:Purchase successful Card:Johnny Silverhand Amount:400");
        }
    }
}