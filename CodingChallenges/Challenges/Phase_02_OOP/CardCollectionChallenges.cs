using CodingChallenges.Challenges.Phase_02_OOP.Week_01._01_Card_Collection;

namespace CodingChallenges.Challenges.Phase_02_OOP
{
    internal class CardCollectionChallenges
    {
        public static void Run()
        {
            Console.WriteLine("========================================");
            Console.WriteLine("OOP SET 1 - CARD COLLECTION CHALLENGES");
            Console.WriteLine("========================================");


            /*
                ============================================================
                OOP CHALLENGE 2: CREATE A CARD CLASS
                ============================================================
            */

            Card cardChallengeTwo = new Card(
                "Johnny Silverhand",
                "Iconic",
                95
            );

            Console.WriteLine(
                cardChallengeTwo.Name == "Johnny Silverhand"
            );

            Console.WriteLine(
                cardChallengeTwo.Rarity == "Iconic"
            );

            Console.WriteLine(
                cardChallengeTwo.Attack == 95
            );


            /*
                ============================================================
                OOP CHALLENGE 3: CREATE A CARD COLLECTION
                ============================================================
            */

            CardCollection cardChallengeThree = new CardCollection();

            cardChallengeThree.AddCard(cardChallengeTwo);

            Console.WriteLine(
                cardChallengeThree.Cards.Count == 1
            );


            /*
                ============================================================
                OOP CHALLENGE 4: FIND HIGHEST ATTACK CARD
                ============================================================
            */


            // Empty collection.
            // Expected result: null.

            CardCollection collectionOne = new CardCollection();

            Console.WriteLine(
                collectionOne.FindHighestAttackCard() == null
            );


            // One card only.
            // Expected result: Johnny Silverhand.

            CardCollection collectionTwo = new CardCollection();

            collectionTwo.AddCard(
                new Card(
                    "Johnny Silverhand",
                    "Epic",
                    95
                )
            );

            Console.WriteLine(
                collectionTwo.FindHighestAttackCard()?.Name
                == "Johnny Silverhand"
            );


            // Normal scenario.
            // Expected result: Adam Smasher.

            CardCollection collectionThree = new CardCollection();

            collectionThree.AddCard(
                new Card(
                    "Johnny Silverhand",
                    "Epic",
                    95
                )
            );

            collectionThree.AddCard(
                new Card(
                    "Judy Alvarez",
                    "Rare",
                    70
                )
            );

            collectionThree.AddCard(
                new Card(
                    "Adam Smasher",
                    "Legendary",
                    100
                )
            );

            collectionThree.AddCard(
                new Card(
                    "Panam Palmer",
                    "Rare",
                    85
                )
            );

            Console.WriteLine(
                collectionThree.FindHighestAttackCard()?.Name
                == "Adam Smasher"
            );


            // Two cards tie for highest attack.
            // Must return the FIRST card encountered.
            // Expected result: Johnny Silverhand.

            CardCollection collectionFour = new CardCollection();

            collectionFour.AddCard(
                new Card(
                    "Johnny Silverhand",
                    "Epic",
                    100
                )
            );

            collectionFour.AddCard(
                new Card(
                    "Adam Smasher",
                    "Legendary",
                    100
                )
            );

            collectionFour.AddCard(
                new Card(
                    "Panam Palmer",
                    "Rare",
                    85
                )
            );

            Console.WriteLine(
                collectionFour.FindHighestAttackCard()?.Name
                == "Johnny Silverhand"
            );


            /*
                ============================================================
                OOP CHALLENGE 5: FIND CARDS BY RARITY
                ============================================================
            */


            // No matching rarity.
            // Expected Count: 0.

            CardCollection rarityCollectionOne = new CardCollection();

            rarityCollectionOne.AddCard(
                new Card(
                    "Johnny Silverhand",
                    "Iconic",
                    95
                )
            );

            Console.WriteLine(
                rarityCollectionOne
                    .FindCardsByRarity("Legendary")
                    .Count == 0
            );


            // One matching card.
            // Expected Count: 1.

            CardCollection rarityCollectionTwo = new CardCollection();

            rarityCollectionTwo.AddCard(
                new Card(
                    "Johnny Silverhand",
                    "Iconic",
                    95
                )
            );

            rarityCollectionTwo.AddCard(
                new Card(
                    "Panam Palmer",
                    "Epic",
                    85
                )
            );

            Console.WriteLine(
                rarityCollectionTwo
                    .FindCardsByRarity("Epic")
                    .Count == 1
            );


            // Two matches.
            // Expected Count: 2.

            CardCollection rarityCollectionThree = new CardCollection();

            rarityCollectionThree.AddCard(
                new Card(
                    "Johnny Silverhand",
                    "Iconic",
                    95
                )
            );

            rarityCollectionThree.AddCard(
                new Card(
                    "Adam Smasher",
                    "Iconic",
                    100
                )
            );

            rarityCollectionThree.AddCard(
                new Card(
                    "Judy Alvarez",
                    "Rare",
                    70
                )
            );

            Console.WriteLine(
                rarityCollectionThree
                    .FindCardsByRarity("Iconic")
                    .Count == 2
            );


            // Case-insensitive check.
            // Expected Count: 2.

            Console.WriteLine(
                rarityCollectionThree
                    .FindCardsByRarity("ICONIC")
                    .Count == 2
            );


            /*
                ============================================================
                OOP CHALLENGE 6: REMOVE CARD BY NAME
                ============================================================
            */


            // Null input.
            // Expected result: false.

            CardCollection removeCollectionOne = new CardCollection();

            Console.WriteLine(
                removeCollectionOne.RemoveCardByName(null!) == false
            );


            // Empty input.
            // Expected result: false.

            CardCollection removeCollectionTwo = new CardCollection();

            Console.WriteLine(
                removeCollectionTwo.RemoveCardByName("") == false
            );


            // Card doesn't exist.
            // Expected result: false.

            CardCollection removeCollectionThree = new CardCollection();

            Console.WriteLine(
                removeCollectionThree
                    .RemoveCardByName("Johnny Silverhand") == false
            );


            // Remove existing card.
            // Expected:
            // true
            // Count == 1.

            CardCollection removeCollectionFour = new CardCollection();

            removeCollectionFour.AddCard(
                new Card(
                    "Johnny Silverhand",
                    "Iconic",
                    95
                )
            );

            removeCollectionFour.AddCard(
                new Card(
                    "Adam Smasher",
                    "Legendary",
                    100
                )
            );

            Console.WriteLine(
                removeCollectionFour
                    .RemoveCardByName("Johnny Silverhand") == true
            );

            Console.WriteLine(
                removeCollectionFour.Cards.Count == 1
            );


            // Case-insensitive removal.
            // Expected:
            // true
            // Count == 1.

            CardCollection removeCollectionFive = new CardCollection();

            removeCollectionFive.AddCard(
                new Card(
                    "Johnny Silverhand",
                    "Iconic",
                    95
                )
            );

            removeCollectionFive.AddCard(
                new Card(
                    "Adam Smasher",
                    "Legendary",
                    100
                )
            );

            Console.WriteLine(
                removeCollectionFive
                    .RemoveCardByName("johnny silverhand") == true
            );

            Console.WriteLine(
                removeCollectionFive.Cards.Count == 1
            );


            // Card not found.
            // Expected:
            // false
            // Count remains 2.

            CardCollection removeCollectionSix = new CardCollection();

            removeCollectionSix.AddCard(
                new Card(
                    "Johnny Silverhand",
                    "Iconic",
                    95
                )
            );

            removeCollectionSix.AddCard(
                new Card(
                    "Adam Smasher",
                    "Legendary",
                    100
                )
            );

            Console.WriteLine(
                removeCollectionSix
                    .RemoveCardByName("Panam Palmer") == false
            );

            Console.WriteLine(
                removeCollectionSix.Cards.Count == 2
            );


            // Two cards have same name.
            // Remove first one only.
            // Expected:
            // true
            // Count == 2
            // First remaining card with that name has Attack 100.

            CardCollection removeCollectionSeven = new CardCollection();

            removeCollectionSeven.AddCard(
                new Card(
                    "Johnny Silverhand",
                    "Iconic",
                    95
                )
            );

            removeCollectionSeven.AddCard(
                new Card(
                    "Johnny Silverhand",
                    "Legendary",
                    100
                )
            );

            removeCollectionSeven.AddCard(
                new Card(
                    "Panam Palmer",
                    "Epic",
                    85
                )
            );

            Console.WriteLine(
                removeCollectionSeven
                    .RemoveCardByName("Johnny Silverhand") == true
            );

            Console.WriteLine(
                removeCollectionSeven.Cards.Count == 2
            );

            Console.WriteLine(
                removeCollectionSeven.Cards[0].Attack == 100
            );


            // Remove only card.
            // Expected:
            // true
            // Count == 0.

            CardCollection removeCollectionEight = new CardCollection();

            removeCollectionEight.AddCard(
                new Card(
                    "Johnny Silverhand",
                    "Iconic",
                    95
                )
            );

            Console.WriteLine(
                removeCollectionEight
                    .RemoveCardByName("Johnny Silverhand") == true
            );

            Console.WriteLine(
                removeCollectionEight.Cards.Count == 0
            );


            /*
                ============================================================
                OOP CHALLENGE 7: CALCULATE AVERAGE ATTACK
                ============================================================
            */


            // Empty collection.
            // Expected: 0.

            CardCollection averageCollectionOne = new CardCollection();

            Console.WriteLine(
                averageCollectionOne.CalculateAverageAttack() == 0
            );


            // One card.
            // Expected: 95.

            CardCollection averageCollectionTwo = new CardCollection();

            averageCollectionTwo.AddCard(
                new Card(
                    "Johnny Silverhand",
                    "Iconic",
                    95
                )
            );

            Console.WriteLine(
                averageCollectionTwo.CalculateAverageAttack() == 95
            );


            // Challenge example.
            // Expected: 80.

            CardCollection averageCollectionThree = new CardCollection();

            averageCollectionThree.AddCard(
                new Card(
                    "Card1",
                    "Common",
                    100
                )
            );

            averageCollectionThree.AddCard(
                new Card(
                    "Card2",
                    "Common",
                    80
                )
            );

            averageCollectionThree.AddCard(
                new Card(
                    "Card3",
                    "Common",
                    60
                )
            );

            Console.WriteLine(
                averageCollectionThree.CalculateAverageAttack() == 80
            );


            // Decimal result.
            // Expected: 10.5.

            CardCollection averageCollectionFour = new CardCollection();

            averageCollectionFour.AddCard(
                new Card(
                    "Card1",
                    "Common",
                    10
                )
            );

            averageCollectionFour.AddCard(
                new Card(
                    "Card2",
                    "Common",
                    11
                )
            );

            Console.WriteLine(
                averageCollectionFour.CalculateAverageAttack() == 10.5
            );


            Console.WriteLine("========================================");
            Console.WriteLine("OOP SET 1 COMPLETE");
            Console.WriteLine("========================================");
        }
    }
}
