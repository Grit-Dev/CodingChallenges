using CodingChallenges.Challenges.Phase_02_OOP.shared;

namespace CodingChallenges.Challenges.Phase_02_OOP
{
    public class CardShopCompositionChallenges
    {
        public static void Run()
        {
            var cardShop = new CardShop();

            cardShop.Transactions.Add(
                new ShopTransaction(
                    "Derek",
                    "Neon Blade",
                    "Purchase",
                    100));

            cardShop.Transactions.Add(
                new ShopTransaction(
                    "Derek",
                    "Ghost Signal",
                    "Purchase",
                    200));

            cardShop.Transactions.Add(
                new ShopTransaction(
                    "V",
                    "Chrome Jacket",
                    "Sale",
                    50));

            Console.WriteLine(cardShop.CalculateTotalTransactionValue() == 350);
            Console.WriteLine(cardShop.CalculateTotalValueByTransactionType("Purchase") == 300);
            Console.WriteLine(cardShop.CalculateTotalValueByTransactionType("Sale") == 50);
            Console.WriteLine(cardShop.CountTransactionsByType("Purchase") == 2);
            Console.WriteLine(cardShop.CountTransactionsByType("Sale") == 1);
            Console.WriteLine(cardShop.FindHighestValueTransaction()?.CardName == "Ghost Signal");
            Console.WriteLine(cardShop.BuildTransactionSummary() == "Transactions:3 Purchases:300 Sales:50 Total:350");
        }
    }
}