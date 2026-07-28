using CodingChallenges.Challenges.Phase_02_OOP.shared;

namespace CodingChallenges.Challenges.Phase_02_OOP
{
    public class CardShopResultRefactorChallenges
    {
        public static void Run()
        {
           CardShop shop = new();

            Card blueEyes = new("Blue Eyes", "Rare", 3000, 400);
            Card darkMagician = new("Dark Magician", "Rare", 2500, 500);

            shop.AddCard(blueEyes);
            shop.AddCard(darkMagician);

            Player richPlayer = new("Paul", 1000);
            Player poorPlayer = new("Bob", 100);

            Player playerWithCard = new("John", 0);
            playerWithCard.AddCard(new Card("Blue Eyes", "Rare", 3000, 400));

            Player playerWithoutCard = new("Steve", 0);

            Console.WriteLine(CardShop.BuildResultSummary(shop.BuyCardWithResult(null!, "Blue Eyes"))); // Success:False Message:Player is required
            Console.WriteLine(CardShop.BuildResultSummary(shop.BuyCardWithResult(richPlayer, ""))); // Success:False Message:Card name is required
            Console.WriteLine(CardShop.BuildResultSummary(shop.BuyCardWithResult(richPlayer, "Unknown"))); // Success:False Message:Card not found
            Console.WriteLine(CardShop.BuildResultSummary(shop.BuyCardWithResult(poorPlayer, "Blue Eyes"))); // Success:False Message:Insufficient credits
            Console.WriteLine(CardShop.BuildResultSummary(shop.BuyCardWithResult(richPlayer, "Blue Eyes"))); // Success:True Message:Purchase successful

            Console.WriteLine(CardShop.BuildResultSummary(shop.BuyCardFromPlayerWithResult(null!, "Blue Eyes"))); // Success:False Message:Player is required
            Console.WriteLine(CardShop.BuildResultSummary(shop.BuyCardFromPlayerWithResult(playerWithCard, ""))); // Success:False Message:Card name is required
            Console.WriteLine(CardShop.BuildResultSummary(shop.BuyCardFromPlayerWithResult(playerWithoutCard, "Blue Eyes"))); // Success:False Message:Player does not own card
            Console.WriteLine(CardShop.BuildResultSummary(shop.BuyCardFromPlayerWithResult(playerWithCard, "Blue Eyes"))); // Success:True Message:Sale successful

            CardShop emptyShop = new();
            Console.WriteLine(emptyShop.HasTransactions()); // False

            emptyShop.Transactions.Add(new ShopTransaction("Paul", "Blue Eyes", "Purchase", 400));
            Console.WriteLine(emptyShop.HasTransactions()); // True

            Console.WriteLine(emptyShop.GetLastTransaction()?.PlayerName); // Paul
            Console.WriteLine(emptyShop.GetLastTransaction()?.CardName); // Blue Eyes
            Console.WriteLine(emptyShop.GetLastTransaction()?.TransactionType); // Purchase
            Console.WriteLine(emptyShop.GetLastTransaction()?.Amount); // 400
        }
    }
}