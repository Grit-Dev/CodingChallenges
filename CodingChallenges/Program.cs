using System.Security.Cryptography.X509Certificates;
using CodingChallenges.Challenges.Phase_02_OOP;

public class Program
{   
    public static int? FindSecondLargestDistinctNumber(int[] pNumbers)
    {
        if(pNumbers == null)
        {
            return null;
        }

        List<int> newListInt = [];
        int largestNumber;
        int secondLargestNumber;

        foreach (int value in pNumbers)
        {
            if (!newListInt.Contains(value))
            {
                newListInt.Add(value);
            }
        }

        if (newListInt.Count < 2)
        {
            return null;
        }

        if (newListInt[0] > newListInt[1])
        {
            largestNumber = newListInt[0];
            secondLargestNumber = newListInt[1];
        }
        else
        {
            largestNumber = newListInt[1];
            secondLargestNumber = newListInt[0];
        }

        for (int outterIndex = 2; outterIndex <= newListInt.Count -1; outterIndex++)
        {
            int value = newListInt[outterIndex];

            if(value > largestNumber)
            {
                secondLargestNumber = largestNumber;
                largestNumber = value;
            }
            else if(value > secondLargestNumber)
            {
                secondLargestNumber = value;
            }
        }

        return secondLargestNumber;
    } 

    public static int[] MoveZerosToEnd(int [] pNumber)
    {
        if(pNumber == null)
        {
            return [];
        }

        int counter = 0; 
        List<int> newListInts = [];

        foreach(int value in pNumber)
        {
            if(value != 0)
            {
                newListInts.Add(value);
            }
            else
            {
                counter++;
            }
        }

        for(int outterIndex = 0; outterIndex <= counter -1; outterIndex++)
        {
            newListInts.Add(0);
        }

        return newListInts.ToArray();
    }

    public static void Main(string[] args)
    {
        // 1. Find Second Largest Distinct number:
        // Console.WriteLine(FindSecondLargestDistinctNumber(null!) == null);
        // Console.WriteLine(FindSecondLargestDistinctNumber([]) == null);
        // Console.WriteLine(FindSecondLargestDistinctNumber([5]) == null);
        // Console.WriteLine(FindSecondLargestDistinctNumber([5, 5]) == null);
        // Console.WriteLine(FindSecondLargestDistinctNumber([7, 3, 7, 3]) == 3);
        // Console.WriteLine(FindSecondLargestDistinctNumber([-10, -20]) == -20);
        // Console.WriteLine(FindSecondLargestDistinctNumber([-1, -5, -3]) == -20);

        // 2. Move Zeros to End: 
        Console.WriteLine(string.Join(", ", MoveZerosToEnd([0, 1, 0, 3, 12]))); // Expected: 1, 3, 12, 0, 0
        Console.WriteLine(string.Join(", ", MoveZerosToEnd([1, 2, 3]))); // Expected: 1, 2, 3
        Console.WriteLine(string.Join(", ", MoveZerosToEnd([0, 0, 1]))); // Expected: 1, 0, 0
        Console.WriteLine(string.Join(", ", MoveZerosToEnd([0, 0, 0]))); // Expected: 0, 0, 0
        Console.WriteLine(string.Join(", ", MoveZerosToEnd([-1, 0, -2, 0, 3]))); // Expected: -1, -2, 3, 0, 0
        Console.WriteLine(string.Join(", ", MoveZerosToEnd([]))); // Expected:
        Console.WriteLine(string.Join(", ", MoveZerosToEnd([5]))); // Expected: 5
        Console.WriteLine(string.Join(", ", MoveZerosToEnd([0]))); // Expected: 0
        Console.WriteLine(string.Join(", ", MoveZerosToEnd([4, 0, 5, 0, 6, 0]))); // Expected: 4, 5, 6, 0, 0, 0
        Console.WriteLine(string.Join(", ", MoveZerosToEnd([0, 1, 2, 0, 3, 0, 4]))); // Expected: 1, 2, 3, 4, 0, 0, 0
        Console.WriteLine(string.Join(", ", MoveZerosToEnd(null!))); // Expected:


        // PMG TO DO:
        //PhaseTwoChallengeRunner.CardShopSellingAndStockChallenges_Run_23_07_2026();

        /*
            ============================================================
            CODING CHALLENGE 2:
            MOVE ZEROS TO THE END
            ============================================================

            Create this method:

            public static int[] MoveZerosToEnd(int[] numbers)

            Requirements:

            * Return an empty array if numbers is null.
            * Keep the original order of non-zero numbers.
            * Move all zeros to the end.
            * Do not use Sort.
            * No LINQ.

            Examples:



            ============================================================
            CODING CHALLENGE 3:
            PARSE AND SUM POSITIVE NUMBERS
            ============================================================

            Create this method:

            public static int SumPositiveNumbersFromText(string input)

            Requirements:

            * Return 0 if input is null, empty, or whitespace.
            * Numbers are separated by commas.
            * Trim spaces around each value.
            * Ignore invalid values.
            * Ignore zero.
            * Ignore negative numbers.
            * Add only positive valid integers.
            * No LINQ.

            Examples:

            "1,2,3" -> 6

            "10, -5, 3, hello" -> 13

            "0, -1, -2" -> 0

            "5, abc, 7" -> 12

            "" -> 0

            " 4, 6 , test, -2, 0, 10 " -> 20


            ============================================================
            LEARNING FOCUS:
            TRANSACTION HISTORY
            ============================================================

            A transaction record is a small object that stores something
            that happened in the system.

            Example:

            Player bought Johnny Silverhand for 400 credits.

            In real applications, this is similar to:

            * order history
            * payment history
            * audit logs
            * activity logs
            * account transactions

            The important idea:

            A method does not just change data.
            It can also record the fact that the change happened.


            ============================================================
            OOP CHALLENGE 4:
            CREATE SHOPTRANSACTION CLASS
            ============================================================

            Create a new class:

            public class ShopTransaction

            Properties:

            public string PlayerName { get; set; }
            public string CardName { get; set; }
            public string TransactionType { get; set; }
            public int Amount { get; set; }

            Requirements:

            * Default string properties should be string.Empty.
            * Add a default constructor.
            * Add a constructor with all four values.

            Example:

            new ShopTransaction(
                "V",
                "Johnny Silverhand",
                "Purchase",
                400
            );


            ============================================================
            OOP CHALLENGE 5:
            ADD TRANSACTION HISTORY TO CARDSHOP
            ============================================================

            Add this property to CardShop:

            public List<ShopTransaction> Transactions { get; } = [];

            Requirements:

            * Transactions should start empty.
            * External code should be able to read the list.
            * External code should not be able to replace the list.
            * Transactions should be added by CardShop methods.


            ============================================================
            OOP CHALLENGE 6:
            RECORD TRANSACTION WHEN PLAYER BUYS FROM SHOP
            ============================================================

            Update your existing CardShop method:

            public bool BuyCard(Player player, string cardName)

            Existing behaviour must stay the same:

            * Return false if player is null.
            * Return false if cardName is null, empty, or whitespace.
            * Return false if the card is not found in Inventory.
            * Return false if the player cannot afford the card.
            * If successful:
                - card is added to player's OwnedCards;
                - card is removed from shop Inventory;
                - method returns true.

            New behaviour:

            * If the purchase succeeds, add a ShopTransaction to Transactions.

            Transaction values:

            PlayerName:
            player.Name

            CardName:
            purchased card name

            TransactionType:
            "Purchase"

            Amount:
            card.Price

            Important:

            * Do not record a transaction if the purchase fails.
            * No LINQ.


            ============================================================
            OOP CHALLENGE 7:
            RECORD TRANSACTION WHEN SHOP BUYS FROM PLAYER
            ============================================================

            Update your existing CardShop method:

            public bool BuyCardFromPlayer(Player player, string cardName)

            Existing behaviour must stay the same:

            * Return false if player is null.
            * Return false if cardName is null, empty, or whitespace.
            * Return false if the player does not own the card.
            * If successful:
                - card is removed from player's OwnedCards;
                - card is added to shop Inventory;
                - player receives half the card price as credits;
                - method returns true.

            New behaviour:

            * If the sale succeeds, add a ShopTransaction to Transactions.

            Transaction values:

            PlayerName:
            player.Name

            CardName:
            sold card name

            TransactionType:
            "Sale"

            Amount:
            half the card price

            Important:

            * Do not record a transaction if the sale fails.
            * Use player.RemoveCardByName(cardName).
            * Use player.AddCredits(amount).
            * No LINQ.


            ============================================================
            OOP CHALLENGE 8:
            CALCULATE TOTAL TRANSACTION VALUE
            ============================================================

            Add this method to CardShop:

            public int CalculateTotalTransactionValue()

            Requirements:

            * Add up the Amount of every transaction.
            * Return 0 if there are no transactions.
            * No LINQ.

            Example Transactions:

            Purchase 400
            Sale 125
            Purchase 700

            Expected:

            1225


            ============================================================
            OPTIONAL OOP STRETCH 9:
            COUNT TRANSACTIONS BY TYPE
            ============================================================

            Add this method to CardShop:

            public int CountTransactionsByType(string transactionType)

            Requirements:

            * Return 0 if transactionType is null, empty, or whitespace.
            * Count matching transaction types.
            * Comparison must be case-insensitive.
            * No LINQ.

            Example Transactions:

            Purchase
            Sale
            Purchase

            CountTransactionsByType("purchase") -> 2

            CountTransactionsByType("sale") -> 1

            CountTransactionsByType("refund") -> 0
        */
    }
}
