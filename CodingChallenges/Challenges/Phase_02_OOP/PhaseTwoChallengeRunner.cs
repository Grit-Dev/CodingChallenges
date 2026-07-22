using CodingChallenges.Challenges.Phase_02_OOP.shared;

namespace CodingChallenges.Challenges.Phase_02_OOP
{
    // PMG TO DO: Big Refactor into its on seperate Folders/files.
    // have a new Class called PhaseTwoChallengeRunner - Run all files
    internal class PhaseTwoChallengeRunner
    {
        public static void CardShopSellingAndStockChallenges_Run_23_07_2026()
        {
            // To Do
        }
        public static void CardShopSellingAndStockChallenges_Run_22_07_2026()
        {
            // Setup
            Player player = new("V", 100);

            Card johnny = new("Johnny Silverhand", "Iconic", 95, 400);
            Card judy = new("Judy Alvarez", "Rare", 70, 250);

            player.AddCard(johnny);
            player.AddCard(judy);

            CardShop shop = new();

            // 4. HasCard
            // Case-insensitive match, invalid input, and card not owned
            Console.WriteLine(player.HasCard("johnny silverhand"));
            Console.WriteLine(!player.HasCard("Adam Smasher"));
            Console.WriteLine(!player.HasCard(null!));
            Console.WriteLine(!player.HasCard(""));
            Console.WriteLine(!player.HasCard("   "));

            // 5. RemoveCardByName
            // Remove card, return removed card, card no longer owned, invalid input
            Player removePlayer = new("Remove", 1000);

            removePlayer.AddCard(new Card("Johnny Silverhand", "Iconic", 95, 400));

            Console.WriteLine(removePlayer.RemoveCardByName("johnny silverhand")?.Name == "Johnny Silverhand");
            Console.WriteLine(removePlayer.OwnedCards.Count == 0);
            Console.WriteLine(removePlayer.RemoveCardByName("Adam Smasher") == null);
            Console.WriteLine(removePlayer.RemoveCardByName(null!) == null);

            // 6. BuyCardFromPlayer
            // Successful sale, credits increase by half price, card moved to shop
            Player seller = new("Seller", 100);

            seller.AddCard(new Card("Johnny Silverhand", "Iconic", 95, 400));

            Console.WriteLine(shop.BuyCardFromPlayer(seller, "johnny silverhand"));

            Console.WriteLine(seller.Credits == 300);
            Console.WriteLine(seller.OwnedCards.Count == 0);
            Console.WriteLine(shop.Inventory.Count == 1);
            Console.WriteLine(!shop.BuyCardFromPlayer(seller, "Adam Smasher"));
            Console.WriteLine(!shop.BuyCardFromPlayer(null!, "Johnny Silverhand"));

            // 7. CountTotalCardsInSystem
            CardShop countShop = new();

            countShop.AddCard(new Card("Johnny", "Iconic", 95, 400));
            countShop.AddCard(new Card("Judy", "Rare", 70, 250));
            countShop.AddCard(new Card("Adam", "Legendary", 99, 700));

            Player countPlayer = new("Count", 1000);

            countPlayer.AddCard(new Card("Panam", "Epic", 80, 300));
            countPlayer.AddCard(new Card("River", "Rare", 75, 200));

            Console.WriteLine(countShop.CountTotalCardsInSystem(null!) == 3);
            Console.WriteLine(countShop.CountTotalCardsInSystem(countPlayer) == 5);

            // 8. FindMostValuableCardInSystem
            CardShop valueShop = new();

            valueShop.AddCard(new Card("Johnny", "Iconic", 95, 400));
            valueShop.AddCard(new Card("Judy", "Rare", 70, 250));

            Player valuePlayer = new("Value", 1000);

            valuePlayer.AddCard(new Card("Adam", "Legendary", 99, 700));

            Console.WriteLine(valueShop.FindMostValuableCardInSystem(valuePlayer)?.Name == "Adam");
            Console.WriteLine(valueShop.FindMostValuableCardInSystem(null!)?.Name == "Johnny");

            CardShop emptyShop = new();

            Console.WriteLine(emptyShop.FindMostValuableCardInSystem(null!) == null);

            // 9. TransferCardTo
            // Card transferred, removed from sender, added to receiver
            Player sender = new("Sender", 1000);
            Player destination = new("Destination", 1000);

            sender.AddCard(new Card("Johnny Silverhand", "Iconic", 95, 400));

            Console.WriteLine(sender.TransferCardTo(destination,"johnny silverhand"));
            Console.WriteLine(sender.OwnedCards.Count == 0);
            Console.WriteLine(destination.OwnedCards.Count == 1);
            Console.WriteLine(destination.OwnedCards[0].Name == "Johnny Silverhand");
            Console.WriteLine(!sender.TransferCardTo(destination,"Adam Smasher"));
            Console.WriteLine(!sender.TransferCardTo(null!,"Johnny Silverhand"));
        }

        // public static void RunTodaysTest_21_07_2026()
        // {
        //     // Setup
        //     CardShop shop = new();

        //     shop.AddCard(new Card("Johnny Silverhand", "Iconic", 95, 400));
        //     shop.AddCard(new Card("Adam Smasher", "Iconic", 99, 700));
        //     shop.AddCard(new Card("Judy Alvarez", "Rare", 70, 250));

        //     Player richPlayer = new("V", 500);
        //     Player poorPlayer = new("Poor", 100);

        //     // 3. FindCardsByRarity
        //     Console.WriteLine(shop.FindCardsByRarity("iconic").Count == 2);
        //     Console.WriteLine(shop.FindCardsByRarity("RARE").Count == 1);
        //     Console.WriteLine(shop.FindCardsByRarity(" ").Count == 0);
        //     Console.WriteLine(shop.FindCardsByRarity("Legendary").Count == 0);

        //     // 4. FindAffordableCards
        //     Console.WriteLine(shop.FindAffordableCards(null!).Count == 0);
        //     Console.WriteLine(shop.FindAffordableCards(richPlayer).Count == 2);
        //     Console.WriteLine(shop.FindAffordableCards(poorPlayer).Count == 0);

        //     // 5. CalculateTotalInventoryValue
        //     CardShop emptyShop = new();

        //     Console.WriteLine(emptyShop.CalculateTotalInventoryValue() == 0);
        //     Console.WriteLine(shop.CalculateTotalInventoryValue() == 1350);

        //     // 6. FindHighestAttackCardPlayerCanAfford
        //     Console.WriteLine(shop.FindHighestAttackCardPlayerCanAfford(null!) == null);
        //     Console.WriteLine(shop.FindHighestAttackCardPlayerCanAfford(richPlayer)?.Name == "Johnny Silverhand");
        //     Console.WriteLine(shop.FindHighestAttackCardPlayerCanAfford(poorPlayer) == null);

        //     // 7. BuyHighestAttackAffordableCard
        //     CardShop purchaseShop = new();

        //     purchaseShop.AddCard(new Card("Johnny Silverhand", "Iconic", 95, 400));
        //     purchaseShop.AddCard(new Card("Adam Smasher", "Iconic", 99, 700));
        //     purchaseShop.AddCard(new Card("Judy Alvarez", "Rare", 70, 250));

        //     Player buyer = new("Buyer", 500);

        //     Console.WriteLine(purchaseShop.BuyHighestAttackAffordableCard(buyer));
        //     Console.WriteLine(buyer.Credits == 100);
        //     Console.WriteLine(buyer.OwnedCards.Count == 1);
        //     Console.WriteLine(buyer.OwnedCards[0].Name == "Johnny Silverhand");
        //     Console.WriteLine(purchaseShop.Inventory.Count == 2);
        //     Console.WriteLine(!purchaseShop.BuyHighestAttackAffordableCard(poorPlayer));

        //     // 8. CalculateAveragePriceByRarity
        //     Console.WriteLine(shop.CalculateAveragePriceByRarity(null!) == 0);
        //     Console.WriteLine(shop.CalculateAveragePriceByRarity("Legendary") == 0);
        //     Console.WriteLine(shop.CalculateAveragePriceByRarity("iconic") == 550);
        // }

        // public void RunTodaysTest_20_07_2026()
        // {
        //     // Setup
        //     Player player = new("V", 500);

        //     Card johnny = new("Johnny Silverhand", "Iconic", 95, 400);
        //     Card adam = new("Adam Smasher", "Iconic", 99, 700);
        //     Card judy = new("Judy Alvarez", "Rare", 70, 250);

        //     CardShop shop = new();

        //     shop.AddCard(johnny);
        //     shop.AddCard(adam);
        //     shop.AddCard(judy);


        //     // 4. BuyCard - case-insensitive lookup, successful purchase, inventory removal
        //     Console.WriteLine(shop.BuyCard(player, "johnny silverhand")); // Expected: True
        //     Console.WriteLine(player.Credits);                            // Expected: 100
        //     Console.WriteLine(player.OwnedCards.Count);                   // Expected: 1
        //     Console.WriteLine(shop.Inventory.Count);                      // Expected: 2

        //     // BuyCard validation and no match
        //     Console.WriteLine(shop.BuyCard(null!, "Adam Smasher"));        // Expected: False
        //     Console.WriteLine(shop.BuyCard(player, "Unknown Card"));      // Expected: False


        //     // 5. HasCard - valid match, no match, invalid input
        //     Console.WriteLine(shop.HasCard("adam smasher"));              // Expected: True
        //     Console.WriteLine(shop.HasCard("Unknown Card"));              // Expected: False
        //     Console.WriteLine(shop.HasCard(" "));                         // Expected: False


        //     // 6. CountCardsByRarity - case-insensitive count and invalid input
        //     Console.WriteLine(shop.CountCardsByRarity("iconic"));         // Expected: 1
        //     Console.WriteLine(shop.CountCardsByRarity("rare"));           // Expected: 1
        //     Console.WriteLine(shop.CountCardsByRarity(null!));             // Expected: 0


        //     // 7. FindCheapestCardPlayerCanAfford - cheapest affordable card and no affordable card
        //     Player richPlayer = new("Rich", 500);
        //     Player poorPlayer = new("Poor", 100);

        //     Console.WriteLine(
        //         shop.FindCheapestCardPlayerCanAfford(richPlayer)?.Name
        //     ); // Expected: Judy Alvarez

        //     Console.WriteLine(
        //         shop.FindCheapestCardPlayerCanAfford(poorPlayer) == null
        //     ); // Expected: True


        //     // 8. BuyCheapestAffordableCard - buys cheapest affordable card and removes from inventory
        //     CardShop secondShop = new();

        //     secondShop.AddCard(new Card("Johnny Silverhand", "Iconic", 95, 400));
        //     secondShop.AddCard(new Card("Adam Smasher", "Iconic", 99, 700));
        //     secondShop.AddCard(new Card("Judy Alvarez", "Rare", 70, 250));

        //     Player buyer = new("Buyer", 500);

        //     Console.WriteLine(
        //         secondShop.BuyCheapestAffordableCard(buyer)
        //     ); // Expected: True

        //     Console.WriteLine(buyer.Credits);                  // Expected: 250
        //     Console.WriteLine(buyer.OwnedCards.Count);         // Expected: 1
        //     Console.WriteLine(buyer.OwnedCards[0].Name);       // Expected: Judy Alvarez
        //     Console.WriteLine(secondShop.Inventory.Count);     // Expected: 2
        // }
        // public void RunTodaydsTest_16_07_2026()
        // {

        //     /*
        //         ============================================================
        //         3. CREATE PLAYER
        //         ============================================================
        //     */

        //     Player player = new Player("V", 1000);

        //     Console.WriteLine(
        //         player.Name == "V"
        //     );

        //     Console.WriteLine(
        //         player.Credits == 1000
        //     );

        //     Console.WriteLine(
        //         player.OwnedCards.Count == 0
        //     );

        //     /*
        //         ============================================================
        //         4. ADD CARD TO PLAYER
        //         ============================================================
        //     */

        //     Player addCardPlayer = new Player("V", 1000);

        //     Card johnny = new Card(
        //         "Johnny Silverhand",
        //         "Iconic",
        //         95,
        //         400
        //     );

        //     addCardPlayer.AddCard(johnny);

        //     Console.WriteLine(
        //         addCardPlayer.OwnedCards.Count == 1
        //     );

        //     Console.WriteLine(
        //         addCardPlayer.OwnedCards[0] == johnny
        //     );

        //     addCardPlayer.AddCard(null!);

        //     Console.WriteLine(
        //         addCardPlayer.OwnedCards.Count == 1
        //     );

        //     /*
        //         ============================================================
        //         5. FIND PLAYER'S STRONGEST CARD
        //         ============================================================
        //     */

        //     Player emptyPlayer = new Player("V", 1000);

        //     Console.WriteLine(
        //         emptyPlayer.FindStrongestCard() == null
        //     );

        //     Player oneCardPlayer = new Player("V", 1000);

        //     oneCardPlayer.AddCard(
        //         new Card(
        //             "Johnny Silverhand",
        //             "Iconic",
        //             95,
        //             400
        //         )
        //     );

        //     Console.WriteLine(
        //         oneCardPlayer.FindStrongestCard()?.Name
        //         == "Johnny Silverhand"
        //     );

        //     Player strongestPlayer = new Player("V", 1000);

        //     strongestPlayer.AddCard(
        //         new Card(
        //             "Johnny Silverhand",
        //             "Iconic",
        //             95,
        //             400
        //         )
        //     );

        //     strongestPlayer.AddCard(
        //         new Card(
        //             "Judy Alvarez",
        //             "Rare",
        //             70,
        //             250
        //         )
        //     );

        //     strongestPlayer.AddCard(
        //         new Card(
        //             "Adam Smasher",
        //             "Legendary",
        //             100,
        //             700
        //         )
        //     );

        //     Console.WriteLine(
        //         strongestPlayer.FindStrongestCard()?.Name
        //         == "Adam Smasher"
        //     );

        //     Player tiePlayer = new Player("V", 1000);

        //     tiePlayer.AddCard(
        //         new Card(
        //             "Johnny Silverhand",
        //             "Iconic",
        //             100,
        //             400
        //         )
        //     );

        //     tiePlayer.AddCard(
        //         new Card(
        //             "Adam Smasher",
        //             "Legendary",
        //             100,
        //             700
        //         )
        //     );

        //     Console.WriteLine(
        //         tiePlayer.FindStrongestCard()?.Name
        //         == "Johnny Silverhand"
        //     );

        //     /*
        //         ============================================================
        //         6. BUY CARD
        //         ============================================================
        //     */

        //     Player nullCardBuyer = new Player("V", 1000);

        //     Console.WriteLine(
        //         nullCardBuyer.BuyCard(null!) == false
        //     );

        //     Console.WriteLine(
        //         nullCardBuyer.Credits == 1000
        //     );

        //     Console.WriteLine(
        //         nullCardBuyer.OwnedCards.Count == 0
        //     );

        //     Player poorPlayer = new Player("V", 100);

        //     Card expensiveJohnny = new Card(
        //         "Johnny Silverhand",
        //         "Iconic",
        //         95,
        //         400
        //     );

        //     Console.WriteLine(
        //         poorPlayer.BuyCard(expensiveJohnny) == false
        //     );

        //     Console.WriteLine(
        //         poorPlayer.Credits == 100
        //     );

        //     Console.WriteLine(
        //         poorPlayer.OwnedCards.Count == 0
        //     );

        //     Player richPlayer = new Player("V", 1000);

        //     Console.WriteLine(
        //         richPlayer.BuyCard(expensiveJohnny) == true
        //     );

        //     Console.WriteLine(
        //         richPlayer.Credits == 600
        //     );

        //     Console.WriteLine(
        //         richPlayer.OwnedCards.Count == 1
        //     );

        //     Console.WriteLine(
        //         richPlayer.OwnedCards[0] == expensiveJohnny
        //     );

        //     Player exactCreditsPlayer = new Player("V", 400);

        //     Console.WriteLine(
        //         exactCreditsPlayer.BuyCard(expensiveJohnny) == true
        //     );

        //     Console.WriteLine(
        //         exactCreditsPlayer.Credits == 0
        //     );

        //     Console.WriteLine(
        //         exactCreditsPlayer.OwnedCards.Count == 1
        //     );

        //     /*
        //         ============================================================
        //         7. TRANSFER CARD BETWEEN PLAYERS
        //         ============================================================
        //     */

        //     Player senderOne = new Player("V", 1000);
        //     Player receiverOne = new Player("Jackie", 1000);

        //     Console.WriteLine(
        //         senderOne.TransferCardTo(null!, receiverOne) == false
        //     );

        //     Console.WriteLine(
        //         senderOne.TransferCardTo("", receiverOne) == false
        //     );

        //     Console.WriteLine(
        //         senderOne.TransferCardTo("   ", receiverOne) == false
        //     );

        //     Console.WriteLine(
        //         senderOne.TransferCardTo("Johnny Silverhand", null!) == false
        //     );

        //     Console.WriteLine(
        //         senderOne.TransferCardTo("Johnny Silverhand", receiverOne)
        //         == false
        //     );

        //     Card transferJohnny = new Card(
        //         "Johnny Silverhand",
        //         "Iconic",
        //         95,
        //         400
        //     );

        //     senderOne.AddCard(transferJohnny);

        //     Console.WriteLine(
        //         senderOne.TransferCardTo("johnny silverhand", receiverOne)
        //         == true
        //     );

        //     Console.WriteLine(
        //         senderOne.OwnedCards.Count == 0
        //     );

        //     Console.WriteLine(
        //         receiverOne.OwnedCards.Count == 1
        //     );

        //     Console.WriteLine(
        //         receiverOne.OwnedCards[0] == transferJohnny
        //     );

        //     Console.WriteLine(
        //         receiverOne.OwnedCards[0].Name == "Johnny Silverhand"
        //     );

        //     Player senderTwo = new Player("V", 1000);
        //     Player receiverTwo = new Player("Jackie", 1000);

        //     Card johnnyOne = new Card(
        //         "Johnny Silverhand",
        //         "Rare",
        //         50,
        //         200
        //     );

        //     Card johnnyTwo = new Card(
        //         "Johnny Silverhand",
        //         "Iconic",
        //         95,
        //         400
        //     );

        //     senderTwo.AddCard(johnnyOne);
        //     senderTwo.AddCard(johnnyTwo);

        //     Console.WriteLine(
        //         senderTwo.TransferCardTo("Johnny Silverhand", receiverTwo)
        //         == true
        //     );

        //     Console.WriteLine(
        //         senderTwo.OwnedCards.Count == 1
        //     );

        //     Console.WriteLine(
        //         receiverTwo.OwnedCards.Count == 1
        //     );

        //     Console.WriteLine(
        //         receiverTwo.OwnedCards[0] == johnnyOne
        //     );

        //     Console.WriteLine(
        //         senderTwo.OwnedCards[0] == johnnyTwo
        //     );

        //     Console.WriteLine("========================================");
        //     Console.WriteLine("TODAY'S TESTS COMPLETE");
        //     Console.WriteLine("========================================");
        // }

        // public void Run()
        // {
        //     Console.WriteLine("========================================");
        //     Console.WriteLine("OOP SET 1 - CARD COLLECTION CHALLENGES");
        //     Console.WriteLine("========================================");


        //     /*
        //         ============================================================
        //         OOP CHALLENGE 2: CREATE A CARD CLASS
        //         ============================================================
        //     */

        //     Card cardChallengeTwo = new Card(
        //         "Johnny Silverhand",
        //         "Iconic",
        //         95
        //     );

        //     Console.WriteLine(
        //         cardChallengeTwo.Name == "Johnny Silverhand"
        //     );

        //     Console.WriteLine(
        //         cardChallengeTwo.Rarity == "Iconic"
        //     );

        //     Console.WriteLine(
        //         cardChallengeTwo.Attack == 95
        //     );


        //     /*
        //         ============================================================
        //         OOP CHALLENGE 3: CREATE A CARD COLLECTION
        //         ============================================================
        //     */

        //     CardCollection cardChallengeThree = new CardCollection();

        //     cardChallengeThree.AddCard(cardChallengeTwo);

        //     Console.WriteLine(
        //         cardChallengeThree.Cards.Count == 1
        //     );


        //     /*
        //         ============================================================
        //         OOP CHALLENGE 4: FIND HIGHEST ATTACK CARD
        //         ============================================================
        //     */


        //     // Empty collection.
        //     // Expected result: null.

        //     CardCollection collectionOne = new CardCollection();

        //     Console.WriteLine(
        //         collectionOne.FindHighestAttackCard() == null
        //     );


        //     // One card only.
        //     // Expected result: Johnny Silverhand.

        //     CardCollection collectionTwo = new CardCollection();

        //     collectionTwo.AddCard(
        //         new Card(
        //             "Johnny Silverhand",
        //             "Epic",
        //             95
        //         )
        //     );

        //     Console.WriteLine(
        //         collectionTwo.FindHighestAttackCard()?.Name
        //         == "Johnny Silverhand"
        //     );


        //     // Normal scenario.
        //     // Expected result: Adam Smasher.

        //     CardCollection collectionThree = new CardCollection();

        //     collectionThree.AddCard(
        //         new Card(
        //             "Johnny Silverhand",
        //             "Epic",
        //             95
        //         )
        //     );

        //     collectionThree.AddCard(
        //         new Card(
        //             "Judy Alvarez",
        //             "Rare",
        //             70
        //         )
        //     );

        //     collectionThree.AddCard(
        //         new Card(
        //             "Adam Smasher",
        //             "Legendary",
        //             100
        //         )
        //     );

        //     collectionThree.AddCard(
        //         new Card(
        //             "Panam Palmer",
        //             "Rare",
        //             85
        //         )
        //     );

        //     Console.WriteLine(
        //         collectionThree.FindHighestAttackCard()?.Name
        //         == "Adam Smasher"
        //     );


        //     // Two cards tie for highest attack.
        //     // Must return the FIRST card encountered.
        //     // Expected result: Johnny Silverhand.

        //     CardCollection collectionFour = new CardCollection();

        //     collectionFour.AddCard(
        //         new Card(
        //             "Johnny Silverhand",
        //             "Epic",
        //             100
        //         )
        //     );

        //     collectionFour.AddCard(
        //         new Card(
        //             "Adam Smasher",
        //             "Legendary",
        //             100
        //         )
        //     );

        //     collectionFour.AddCard(
        //         new Card(
        //             "Panam Palmer",
        //             "Rare",
        //             85
        //         )
        //     );

        //     Console.WriteLine(
        //         collectionFour.FindHighestAttackCard()?.Name
        //         == "Johnny Silverhand"
        //     );


        //     /*
        //         ============================================================
        //         OOP CHALLENGE 5: FIND CARDS BY RARITY
        //         ============================================================
        //     */


        //     // No matching rarity.
        //     // Expected Count: 0.

        //     CardCollection rarityCollectionOne = new CardCollection();

        //     rarityCollectionOne.AddCard(
        //         new Card(
        //             "Johnny Silverhand",
        //             "Iconic",
        //             95
        //         )
        //     );

        //     Console.WriteLine(
        //         rarityCollectionOne
        //             .FindCardsByRarity("Legendary")
        //             .Count == 0
        //     );


        //     // One matching card.
        //     // Expected Count: 1.

        //     CardCollection rarityCollectionTwo = new CardCollection();

        //     rarityCollectionTwo.AddCard(
        //         new Card(
        //             "Johnny Silverhand",
        //             "Iconic",
        //             95
        //         )
        //     );

        //     rarityCollectionTwo.AddCard(
        //         new Card(
        //             "Panam Palmer",
        //             "Epic",
        //             85
        //         )
        //     );

        //     Console.WriteLine(
        //         rarityCollectionTwo
        //             .FindCardsByRarity("Epic")
        //             .Count == 1
        //     );


        //     // Two matches.
        //     // Expected Count: 2.

        //     CardCollection rarityCollectionThree = new CardCollection();

        //     rarityCollectionThree.AddCard(
        //         new Card(
        //             "Johnny Silverhand",
        //             "Iconic",
        //             95
        //         )
        //     );

        //     rarityCollectionThree.AddCard(
        //         new Card(
        //             "Adam Smasher",
        //             "Iconic",
        //             100
        //         )
        //     );

        //     rarityCollectionThree.AddCard(
        //         new Card(
        //             "Judy Alvarez",
        //             "Rare",
        //             70
        //         )
        //     );

        //     Console.WriteLine(
        //         rarityCollectionThree
        //             .FindCardsByRarity("Iconic")
        //             .Count == 2
        //     );


        //     // Case-insensitive check.
        //     // Expected Count: 2.

        //     Console.WriteLine(
        //         rarityCollectionThree
        //             .FindCardsByRarity("ICONIC")
        //             .Count == 2
        //     );


        //     /*
        //         ============================================================
        //         OOP CHALLENGE 6: REMOVE CARD BY NAME
        //         ============================================================
        //     */


        //     // Null input.
        //     // Expected result: false.

        //     CardCollection removeCollectionOne = new CardCollection();

        //     Console.WriteLine(
        //         removeCollectionOne.RemoveCardByName(null!) == false
        //     );


        //     // Empty input.
        //     // Expected result: false.

        //     CardCollection removeCollectionTwo = new CardCollection();

        //     Console.WriteLine(
        //         removeCollectionTwo.RemoveCardByName("") == false
        //     );


        //     // Card doesn't exist.
        //     // Expected result: false.

        //     CardCollection removeCollectionThree = new CardCollection();

        //     Console.WriteLine(
        //         removeCollectionThree
        //             .RemoveCardByName("Johnny Silverhand") == false
        //     );


        //     // Remove existing card.
        //     // Expected:
        //     // true
        //     // Count == 1.

        //     CardCollection removeCollectionFour = new CardCollection();

        //     removeCollectionFour.AddCard(
        //         new Card(
        //             "Johnny Silverhand",
        //             "Iconic",
        //             95
        //         )
        //     );

        //     removeCollectionFour.AddCard(
        //         new Card(
        //             "Adam Smasher",
        //             "Legendary",
        //             100
        //         )
        //     );

        //     Console.WriteLine(
        //         removeCollectionFour
        //             .RemoveCardByName("Johnny Silverhand") == true
        //     );

        //     Console.WriteLine(
        //         removeCollectionFour.Cards.Count == 1
        //     );


        //     // Case-insensitive removal.
        //     // Expected:
        //     // true
        //     // Count == 1.

        //     CardCollection removeCollectionFive = new CardCollection();

        //     removeCollectionFive.AddCard(
        //         new Card(
        //             "Johnny Silverhand",
        //             "Iconic",
        //             95
        //         )
        //     );

        //     removeCollectionFive.AddCard(
        //         new Card(
        //             "Adam Smasher",
        //             "Legendary",
        //             100
        //         )
        //     );

        //     Console.WriteLine(
        //         removeCollectionFive
        //             .RemoveCardByName("johnny silverhand") == true
        //     );

        //     Console.WriteLine(
        //         removeCollectionFive.Cards.Count == 1
        //     );


        //     // Card not found.
        //     // Expected:
        //     // false
        //     // Count remains 2.

        //     CardCollection removeCollectionSix = new CardCollection();

        //     removeCollectionSix.AddCard(
        //         new Card(
        //             "Johnny Silverhand",
        //             "Iconic",
        //             95
        //         )
        //     );

        //     removeCollectionSix.AddCard(
        //         new Card(
        //             "Adam Smasher",
        //             "Legendary",
        //             100
        //         )
        //     );

        //     Console.WriteLine(
        //         removeCollectionSix
        //             .RemoveCardByName("Panam Palmer") == false
        //     );

        //     Console.WriteLine(
        //         removeCollectionSix.Cards.Count == 2
        //     );


        //     // Two cards have same name.
        //     // Remove first one only.
        //     // Expected:
        //     // true
        //     // Count == 2
        //     // First remaining card with that name has Attack 100.

        //     CardCollection removeCollectionSeven = new CardCollection();

        //     removeCollectionSeven.AddCard(
        //         new Card(
        //             "Johnny Silverhand",
        //             "Iconic",
        //             95
        //         )
        //     );

        //     removeCollectionSeven.AddCard(
        //         new Card(
        //             "Johnny Silverhand",
        //             "Legendary",
        //             100
        //         )
        //     );

        //     removeCollectionSeven.AddCard(
        //         new Card(
        //             "Panam Palmer",
        //             "Epic",
        //             85
        //         )
        //     );

        //     Console.WriteLine(
        //         removeCollectionSeven
        //             .RemoveCardByName("Johnny Silverhand") == true
        //     );

        //     Console.WriteLine(
        //         removeCollectionSeven.Cards.Count == 2
        //     );

        //     Console.WriteLine(
        //         removeCollectionSeven.Cards[0].Attack == 100
        //     );


        //     // Remove only card.
        //     // Expected:
        //     // true
        //     // Count == 0.

        //     CardCollection removeCollectionEight = new CardCollection();

        //     removeCollectionEight.AddCard(
        //         new Card(
        //             "Johnny Silverhand",
        //             "Iconic",
        //             95
        //         )
        //     );

        //     Console.WriteLine(
        //         removeCollectionEight
        //             .RemoveCardByName("Johnny Silverhand") == true
        //     );

        //     Console.WriteLine(
        //         removeCollectionEight.Cards.Count == 0
        //     );


        //     /*
        //         ============================================================
        //         OOP CHALLENGE 7: CALCULATE AVERAGE ATTACK
        //         ============================================================
        //     */


        //     // Empty collection.
        //     // Expected: 0.

        //     CardCollection averageCollectionOne = new CardCollection();

        //     Console.WriteLine(
        //         averageCollectionOne.CalculateAverageAttack() == 0
        //     );


        //     // One card.
        //     // Expected: 95.

        //     CardCollection averageCollectionTwo = new CardCollection();

        //     averageCollectionTwo.AddCard(
        //         new Card(
        //             "Johnny Silverhand",
        //             "Iconic",
        //             95
        //         )
        //     );

        //     Console.WriteLine(
        //         averageCollectionTwo.CalculateAverageAttack() == 95
        //     );


        //     // Challenge example.
        //     // Expected: 80.

        //     CardCollection averageCollectionThree = new CardCollection();

        //     averageCollectionThree.AddCard(
        //         new Card(
        //             "Card1",
        //             "Common",
        //             100
        //         )
        //     );

        //     averageCollectionThree.AddCard(
        //         new Card(
        //             "Card2",
        //             "Common",
        //             80
        //         )
        //     );

        //     averageCollectionThree.AddCard(
        //         new Card(
        //             "Card3",
        //             "Common",
        //             60
        //         )
        //     );

        //     Console.WriteLine(
        //         averageCollectionThree.CalculateAverageAttack() == 80
        //     );


        //     // Decimal result.
        //     // Expected: 10.5.

        //     CardCollection averageCollectionFour = new CardCollection();

        //     averageCollectionFour.AddCard(
        //         new Card(
        //             "Card1",
        //             "Common",
        //             10
        //         )
        //     );

        //     averageCollectionFour.AddCard(
        //         new Card(
        //             "Card2",
        //             "Common",
        //             11
        //         )
        //     );

        //     Console.WriteLine(
        //         averageCollectionFour.CalculateAverageAttack() == 10.5
        //     );


        //     Console.WriteLine("========================================");
        //     Console.WriteLine("OOP SET 1 COMPLETE");
        //     Console.WriteLine("========================================");
        // }
    }
}
