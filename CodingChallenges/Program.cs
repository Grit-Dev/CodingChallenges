using System.Diagnostics.Metrics;
using CodingChallenges.Challenges.Phase_02_OOP.shared;

public class Program
{   
    public static void Main(string[] args)
    {
        CardShopTransactionReportsChallenges.Run();
       // CardShopTransactionHistoryChallenges.TransactionHistoryChallenges_Run_23_07_2026();

    }

    /*
        ============================================================
        CODING CHALLENGE 3:
        FIND HIGHEST VALID SCORE FROM CSV TEXT
        ============================================================

        Create this method:

        public static int? FindHighestValidScoreFromCsv(string input)

        Requirements:

        * Return null if input is null, empty, or whitespace.
        * Values are separated by commas.
        * Trim spaces around each value.
        * Use int.TryParse.
        * Only scores from 0 to 100 are valid.
        * Ignore invalid values.
        * Ignore numbers below 0.
        * Ignore numbers above 100.
        * Return the highest valid score.
        * Return null if no valid scores exist.
        * No LINQ.

        Examples:

        "10, 50, 90" -> 90

        "101, -5, hello, 80" -> 80

        "abc, -1, 200" -> null

        "60, 60, 59" -> 60

        "" -> null


        ============================================================
        LEARNING FOCUS:
        REPORT / QUERY METHODS
        ============================================================

        Yesterday, the shop started recording transactions.

        Today, the shop needs to answer questions about those transactions.

        This is like backend/API work:

        * get all transactions for a player
        * get all purchases
        * get all sales
        * find the biggest transaction
        * calculate totals for reports

        Important idea:

        Report/query methods should usually READ data.
        They should not change inventory, credits, or owned cards.


        ============================================================
        OOP CHALLENGE 4:
        GET TRANSACTIONS BY PLAYER NAME
        ============================================================

        Add this method to CardShop:

        public List<ShopTransaction> GetTransactionsByPlayerName(string playerName)

        Requirements:

        * Return an empty list if playerName is null, empty, or whitespace.
        * Return all transactions where PlayerName matches.
        * Comparison must be case-insensitive.
        * Preserve the original transaction objects.
        * Return an empty list if no matches exist.
        * Do not modify Transactions.
        * No LINQ.

        Example:

        Transactions:
        V bought Johnny
        V sold Judy
        Rogue bought Adam

        GetTransactionsByPlayerName("v") -> 2 transactions


        ============================================================
        OOP CHALLENGE 5:
        GET TRANSACTIONS BY TYPE
        ============================================================

        Add this method to CardShop:

        public List<ShopTransaction> GetTransactionsByType(string transactionType)

        Requirements:

        * Return an empty list if transactionType is null, empty, or whitespace.
        * Return all transactions where TransactionType matches.
        * Comparison must be case-insensitive.
        * Preserve the original transaction objects.
        * Return an empty list if no matches exist.
        * Do not modify Transactions.
        * No LINQ.

        Example:

        Purchase
        Sale
        Purchase

        GetTransactionsByType("purchase") -> 2 transactions


        ============================================================
        OOP CHALLENGE 6:
        FIND HIGHEST VALUE TRANSACTION
        ============================================================

        Add this method to CardShop:

        public ShopTransaction? FindHighestValueTransaction()

        Requirements:

        * Return null if there are no transactions.
        * Return the transaction with the highest Amount.
        * If tied, return the first one encountered.
        * Do not modify Transactions.
        * No LINQ.

        Example:

        Purchase 400
        Sale 125
        Purchase 700

        Expected:

        Purchase 700


        ============================================================
        OOP CHALLENGE 7:
        CALCULATE TOTAL VALUE BY TRANSACTION TYPE
        ============================================================

        Add this method to CardShop:

        public int CalculateTotalValueByTransactionType(string transactionType)

        Requirements:

        * Return 0 if transactionType is null, empty, or whitespace.
        * Add up the Amount for transactions matching the supplied type.
        * Comparison must be case-insensitive.
        * Return 0 if no matches exist.
        * Do not modify Transactions.
        * No LINQ.

        Example:

        Purchase 400
        Sale 125
        Purchase 700

        CalculateTotalValueByTransactionType("purchase") -> 1100

        CalculateTotalValueByTransactionType("sale") -> 125


        ============================================================
        OPTIONAL OOP STRETCH 8:
        BUILD SIMPLE TRANSACTION SUMMARY TEXT
        ============================================================

        Add this method to CardShop:

        public string BuildTransactionSummary()

        Requirements:

        * Return a summary string using:
            - total number of transactions;
            - total purchase value;
            - total sale value;
            - total transaction value.
        * Reuse methods you already wrote where possible.
        * No LINQ.

        Expected format:

        "Transactions:3 Purchases:1100 Sales:125 Total:1225"

        Example transactions:

        Purchase 400
        Sale 125
        Purchase 700

        Expected:

        "Transactions:3 Purchases:1100 Sales:125 Total:1225"
    */
}
