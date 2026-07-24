using CodingChallenges.Challenges.Phase_02_OOP.shared;

namespace CodingChallenges.Challenges.Phase_02_OOP
{
    public class CardShopTransactionHistoryChallenge
    {
        public static void TransactionHistoryChallenges_Run_23_07_2026()
        {
            // Challenge 4 - ShopTransaction

            ShopTransaction transaction1 = new();

            Console.WriteLine(transaction1.PlayerName == "");
            Console.WriteLine(transaction1.CardName == "");
            Console.WriteLine(transaction1.TransactionType == "");
            Console.WriteLine(transaction1.Amount == 0);

            ShopTransaction transaction2 = new("V", "Johnny Silverhand", "Purchase", 400);

            Console.WriteLine(transaction2.PlayerName == "V");
            Console.WriteLine(transaction2.CardName == "Johnny Silverhand");
            Console.WriteLine(transaction2.TransactionType == "Purchase");
            Console.WriteLine(transaction2.Amount == 400);


            // Challenge 5 - Transactions Property

            CardShop emptyShop = new();

            Console.WriteLine(emptyShop.Transactions.Count == 0);


            // Challenge 6 - BuyCard Transaction Recording

            Player buyer = new("V", 1000);

            CardShop purchaseShop = new();

            purchaseShop.Inventory.Add(new Card("Johnny Silverhand", "Iconic", 95, 400));

            Console.WriteLine(purchaseShop.BuyCard(buyer, "johnny silverhand"));
            Console.WriteLine(buyer.HasCard("Johnny Silverhand"));
            Console.WriteLine(purchaseShop.Inventory.Count == 0);
            Console.WriteLine(purchaseShop.Transactions.Count == 1);
            Console.WriteLine(purchaseShop.Transactions[0].PlayerName == "V");
            Console.WriteLine(purchaseShop.Transactions[0].CardName == "Johnny Silverhand");
            Console.WriteLine(purchaseShop.Transactions[0].TransactionType == "Purchase");
            Console.WriteLine(purchaseShop.Transactions[0].Amount == 400);

            Console.WriteLine(!purchaseShop.BuyCard(buyer, "Adam Smasher"));
            Console.WriteLine(purchaseShop.Transactions.Count == 1);


            // Challenge 7 - BuyCardFromPlayer Transaction Recording

            Player seller = new("Seller", 100);

            seller.AddCard(new Card("Judy Alvarez", "Rare", 80, 200));

            CardShop saleShop = new();

            Console.WriteLine(saleShop.BuyCardFromPlayer(seller, "judy alvarez"));
            Console.WriteLine(seller.Credits == 200);
            Console.WriteLine(seller.OwnedCards.Count == 0);
            Console.WriteLine(saleShop.Inventory.Count == 1);
            Console.WriteLine(saleShop.Transactions.Count == 1);
            Console.WriteLine(saleShop.Transactions[0].PlayerName == "Seller");
            Console.WriteLine(saleShop.Transactions[0].CardName == "Judy Alvarez");
            Console.WriteLine(saleShop.Transactions[0].TransactionType == "Sale");
            Console.WriteLine(saleShop.Transactions[0].Amount == 100);

            Console.WriteLine(!saleShop.BuyCardFromPlayer(seller, "Adam Smasher"));
            Console.WriteLine(saleShop.Transactions.Count == 1);


            // Challenge 8 - CalculateTotalTransactionValue

            CardShop valueShop = new();

            Console.WriteLine(valueShop.CalculateTotalTransactionValue() == 0);

            valueShop.Transactions.Add(new ShopTransaction("V", "Johnny", "Purchase", 400));
            valueShop.Transactions.Add(new ShopTransaction("V", "Judy", "Sale", 125));
            valueShop.Transactions.Add(new ShopTransaction("V", "Adam", "Purchase", 700));

            Console.WriteLine(valueShop.CalculateTotalTransactionValue() == 1225);


            // Challenge 9 - CountTransactionsByType

            CardShop countShop = new();

            countShop.Transactions.Add(new ShopTransaction("V", "Johnny", "Purchase", 400));
            countShop.Transactions.Add(new ShopTransaction("V", "Judy", "Sale", 125));
            countShop.Transactions.Add(new ShopTransaction("V", "Adam", "Purchase", 700));

            Console.WriteLine(countShop.CountTransactionsByType("purchase") == 2);
            Console.WriteLine(countShop.CountTransactionsByType("PURCHASE") == 2);
            Console.WriteLine(countShop.CountTransactionsByType("sale") == 1);
            Console.WriteLine(countShop.CountTransactionsByType("refund") == 0);
            Console.WriteLine(countShop.CountTransactionsByType("") == 0);
            Console.WriteLine(countShop.CountTransactionsByType("   ") == 0);
            Console.WriteLine(countShop.CountTransactionsByType(null!) == 0);
        }
    }
}