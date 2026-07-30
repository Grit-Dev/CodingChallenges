using CodingChallenges.Challenges.Phase_02_OOP.shared;

namespace CodingChallenges.Challenges.Phase_02_OOP
{
    public class CardShopRequestObjectChallenges
    {
        public static void Run()
        {
            // ============================================================
            // OOP CHALLENGE 4
            // REQUEST CLASSES
            // ============================================================

            BuyCardRequest buyRequest1 = new BuyCardRequest();
            Console.WriteLine(buyRequest1.PlayerName == "");
            Console.WriteLine(buyRequest1.CardName == "");

            BuyCardRequest buyRequest2 = new BuyCardRequest("V", "Johnny Silverhand");
            Console.WriteLine(buyRequest2.PlayerName == "V");
            Console.WriteLine(buyRequest2.CardName == "Johnny Silverhand");

            SellCardRequest sellRequest1 = new SellCardRequest();
            Console.WriteLine(sellRequest1.PlayerName == "");
            Console.WriteLine(sellRequest1.CardName == "");

            SellCardRequest sellRequest2 = new SellCardRequest("V", "Johnny Silverhand");
            Console.WriteLine(sellRequest2.PlayerName == "V");
            Console.WriteLine(sellRequest2.CardName == "Johnny Silverhand");


            // ============================================================
            // OOP CHALLENGE 5
            // BUY CARD WITH REQUEST
            // ============================================================

            CardShop buyShop = new CardShop();
            Player buyer = new Player("V", 1000);

            buyShop.AddCard(new Card("Johnny Silverhand", "Iconic", 95, 400));

            CardShopResult buyResult1 = buyShop.BuyCardWithRequest(null, new BuyCardRequest());
            Console.WriteLine(buyResult1.Success == false);
            Console.WriteLine(buyResult1.Message == "Player is required");
            Console.WriteLine(buyResult1.CardName == "");
            Console.WriteLine(buyResult1.Amount == 0);

            CardShopResult buyResult2 = buyShop.BuyCardWithRequest(buyer, null);
            Console.WriteLine(buyResult2.Success == false);
            Console.WriteLine(buyResult2.Message == "Request is required");
            Console.WriteLine(buyResult2.CardName == "");
            Console.WriteLine(buyResult2.Amount == 0);

            CardShopResult buyResult3 = buyShop.BuyCardWithRequest(buyer, new BuyCardRequest("", "Johnny Silverhand"));
            Console.WriteLine(buyResult3.Success == false);
            Console.WriteLine(buyResult3.Message == "Player name is required");
            Console.WriteLine(buyResult3.CardName == "");
            Console.WriteLine(buyResult3.Amount == 0);

            CardShopResult buyResult4 = buyShop.BuyCardWithRequest(buyer, new BuyCardRequest("WrongPlayer", "Johnny Silverhand"));
            Console.WriteLine(buyResult4.Success == false);
            Console.WriteLine(buyResult4.Message == "Player mismatch");
            Console.WriteLine(buyResult4.CardName == "Johnny Silverhand");
            Console.WriteLine(buyResult4.Amount == 0);

            CardShopResult buyResult5 = buyShop.BuyCardWithRequest(buyer, new BuyCardRequest("V", ""));
            Console.WriteLine(buyResult5.Success == false);
            Console.WriteLine(buyResult5.Message == "Card name is required");
            Console.WriteLine(buyResult5.CardName == "");
            Console.WriteLine(buyResult5.Amount == 0);

            Player poorPlayer = new Player("Poor", 100);

            CardShopResult buyResult6 = buyShop.BuyCardWithRequest(poorPlayer, new BuyCardRequest("Poor", "Johnny Silverhand"));
            Console.WriteLine(buyResult6.Success == false);
            Console.WriteLine(buyResult6.Message == "Insufficient credits");
            Console.WriteLine(buyResult6.CardName == "Johnny Silverhand");
            Console.WriteLine(buyResult6.Amount == 400);

            CardShopResult buyResult7 = buyShop.BuyCardWithRequest(buyer, new BuyCardRequest("V", "Johnny Silverhand"));
            Console.WriteLine(buyResult7.Success == true);
            Console.WriteLine(buyResult7.Message == "Purchase successful");
            Console.WriteLine(buyResult7.CardName == "Johnny Silverhand");
            Console.WriteLine(buyResult7.Amount == 400);


            // ============================================================
            // OOP CHALLENGE 6
            // SELL CARD WITH REQUEST
            // ============================================================

            CardShop sellShop = new CardShop();
            Player seller = new Player("Seller", 100);

            seller.AddCard(new Card("Judy Alvarez", "Rare", 80, 200));

            CardShopResult sellResult1 = sellShop.BuyCardFromPlayerWithRequest(null, new SellCardRequest());
            Console.WriteLine(sellResult1.Success == false);
            Console.WriteLine(sellResult1.Message == "Player is required");
            Console.WriteLine(sellResult1.CardName == "");
            Console.WriteLine(sellResult1.Amount == 0);

            CardShopResult sellResult2 = sellShop.BuyCardFromPlayerWithRequest(seller, null);
            Console.WriteLine(sellResult2.Success == false);
            Console.WriteLine(sellResult2.Message == "Request is required");
            Console.WriteLine(sellResult2.CardName == "");
            Console.WriteLine(sellResult2.Amount == 0);

            CardShopResult sellResult3 = sellShop.BuyCardFromPlayerWithRequest(seller, new SellCardRequest("", "Judy Alvarez"));
            Console.WriteLine(sellResult3.Success == false);
            Console.WriteLine(sellResult3.Message == "Player name is required");
            Console.WriteLine(sellResult3.CardName == "");
            Console.WriteLine(sellResult3.Amount == 0);

            CardShopResult sellResult4 = sellShop.BuyCardFromPlayerWithRequest(seller, new SellCardRequest("WrongSeller", "Judy Alvarez"));
            Console.WriteLine(sellResult4.Success == false);
            Console.WriteLine(sellResult4.Message == "Player mismatch");
            Console.WriteLine(sellResult4.CardName == "Judy Alvarez");
            Console.WriteLine(sellResult4.Amount == 0);

            CardShopResult sellResult5 = sellShop.BuyCardFromPlayerWithRequest(seller, new SellCardRequest("Seller", ""));
            Console.WriteLine(sellResult5.Success == false);
            Console.WriteLine(sellResult5.Message == "Card name is required");
            Console.WriteLine(sellResult5.CardName == "");
            Console.WriteLine(sellResult5.Amount == 0);

            CardShopResult sellResult6 = sellShop.BuyCardFromPlayerWithRequest(seller, new SellCardRequest("Seller", "Adam Smasher"));
            Console.WriteLine(sellResult6.Success == false);
            Console.WriteLine(sellResult6.Message == "Player does not own card");
            Console.WriteLine(sellResult6.CardName == "Adam Smasher");
            Console.WriteLine(sellResult6.Amount == 0);

            CardShopResult sellResult7 = sellShop.BuyCardFromPlayerWithRequest(seller, new SellCardRequest("Seller", "Judy Alvarez"));
            Console.WriteLine(sellResult7.Success == true);
            Console.WriteLine(sellResult7.Message == "Sale successful");
            Console.WriteLine(sellResult7.CardName == "Judy Alvarez");
            Console.WriteLine(sellResult7.Amount == 100);

            // ============================================================
            // OPTIONAL STRETCH 7
            // BUILD REQUEST SUMMARY
            // ============================================================

            CardShop summaryShop = new CardShop();

            Console.WriteLine(summaryShop.BuildBuyRequestSummary(null) == "");

            Console.WriteLine(summaryShop.BuildBuyRequestSummary(new BuyCardRequest("V", "Johnny Silverhand")) == "Player:V Card:Johnny Silverhand");    
        }
    }
}