using CodingChallenges.Challenges.Phase_02_OOP.shared;

namespace CodingChallenges.Challenges.Phase_02_OOP
{
    public class CardShopTransactionReportsChallenges
    {
        public static void Run()
        {
            // Setup
            var shop = new CardShop();

            shop.Transactions.Add(new ShopTransaction("V", "Johnny", "Purchase", 400));
            shop.Transactions.Add(new ShopTransaction("V", "Judy", "Sale", 125));
            shop.Transactions.Add(new ShopTransaction("Rogue", "Adam", "Purchase", 700));

            // OOP Challenge 4

            Console.WriteLine(shop.GetTransactionsByPlayerName("V").Count); // 2
            Console.WriteLine(shop.GetTransactionsByPlayerName("v").Count); // 2
            Console.WriteLine(shop.GetTransactionsByPlayerName("Rogue").Count); // 1
            Console.WriteLine(shop.GetTransactionsByPlayerName("Nobody").Count); // 0
            Console.WriteLine(shop.GetTransactionsByPlayerName("").Count); // 0

            // OOP Challenge 5

            Console.WriteLine(shop.GetTransactionsByType("Purchase").Count); // 2
            Console.WriteLine(shop.GetTransactionsByType("purchase").Count); // 2
            Console.WriteLine(shop.GetTransactionsByType("Sale").Count); // 1
            Console.WriteLine(shop.GetTransactionsByType("Refund").Count); // 0
            Console.WriteLine(shop.GetTransactionsByType("").Count); // 0

            // OOP Challenge 6

            Console.WriteLine(shop.FindHighestValueTransaction()?.Amount); // 700
            Console.WriteLine(shop.FindHighestValueTransaction()?.PlayerName); // Rogue
            Console.WriteLine(shop.FindHighestValueTransaction()?.TransactionType); // Purchase

            // OOP Challenge 7

            Console.WriteLine(shop.CalculateTotalValueByTransactionType("Purchase")); // 1100
            Console.WriteLine(shop.CalculateTotalValueByTransactionType("purchase")); // 1100
            Console.WriteLine(shop.CalculateTotalValueByTransactionType("Sale")); // 125
            Console.WriteLine(shop.CalculateTotalValueByTransactionType("sale")); // 125
            Console.WriteLine(shop.CalculateTotalValueByTransactionType("Refund")); // 0
            Console.WriteLine(shop.CalculateTotalValueByTransactionType("")); // 0

            // OOP Stretch 8

            Console.WriteLine(shop.BuildTransactionSummary());
            // Transactions:3 Purchases:1100 Sales:125 Total:1225
        }
    }
}