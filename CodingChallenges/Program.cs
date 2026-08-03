using CodingChallenges.Challenges;

public class Program
{
    public static void Main(string[] args)
    {
        JsonDataSanitizerRunner.Run();

        // CardShopCompositionChallenges.Run();
        // CardShopRequestObjectChallenges.Run();
        // CardShopTransactionReportsChallenges.Run();
        // CardShopTransactionHistoryChallenges.TransactionHistoryChallenges_Run_23_07_2026();


        /*
            ============================================================
            MONDAY CODING CHALLENGE
            INTERVIEW ASSESSMENT DRILL 01
            JSON PERSONAL DATA REDACTOR
            ============================================================

            BACKGROUND
            ============================================================

            You are building a small utility that processes personal data
            before it is stored or displayed.

            You receive a JSON string containing a list of people.

            Your job is to:

            * deserialize the JSON into C# objects
            * redact sensitive information
            * return the updated data as a JSON string

            The solution should focus on:

            * clean readable C#
            * small helper methods
            * understandable logic
            * unit testing
            * explaining your decisions

            Avoid overengineering.


            ============================================================
            REQUIRED METHOD
            ============================================================

            Create this method:

            public string RedactPersonalData(string json)

            The method should:

            * accept a JSON string
            * deserialize it into C# objects
            * process each person
            * redact name, address, mobile and email
            * return the updated object as JSON


            ============================================================
            EXAMPLE INPUT
            ============================================================

            {
              "people": [
                {
                  "name": "Derek Morgan",
                  "address": "4321 Willow Lane, Edinburgh, EH12 7JQ",
                  "mobile": "07700900832",
                  "email": "derek.morgan@example.co.uk"
                }
              ]
            }


            ============================================================
            ACCEPTANCE CRITERIA 1:
            MODELS
            ============================================================

            Create suitable models matching the JSON structure.

            Required structure:

            PeopleData
                |
                |-- List<Person>

            Person
                |
                |-- Name
                |-- Address
                |-- Mobile
                |-- Email

            Suggested files:

            PeopleData.cs
            Person.cs


            ============================================================
            ACCEPTANCE CRITERIA 2:
            NAME REDACTION
            ============================================================

            Convert names into initials.

            Examples:

            Derek Morgan
            -> DM

            Robert McDowell
            -> RD

            Rules:

            * Take the first letter of the first name.
            * Take the first letter of the surname.
            * If the surname begins with "Mc", ignore the "Mc".

            Example:

            Robert McDowell

            First name initial:
            R

            Surname:
            McDowell

            Ignore Mc:
            Dowell

            Surname initial:
            D

            Result:
            RD


            ============================================================
            ACCEPTANCE CRITERIA 3:
            ADDRESS REDACTION
            ============================================================

            Only keep the city.

            Example input:

            4321 Willow Lane, Edinburgh, EH12 7JQ

            Output:

            Edinburgh

            Assumption:

            * City is always the second section after splitting by commas.


            ============================================================
            ACCEPTANCE CRITERIA 4:
            MOBILE NUMBER REDACTION
            ============================================================

            Hide all digits except the last four.

            Example input:

            07700900832

            Output:

            *******0832

            Rules:

            * Keep the last 4 characters.
            * Replace everything before the last 4 characters with *.


            ============================================================
            ACCEPTANCE CRITERIA 5:
            EMAIL REDACTION
            ============================================================

            Hide everything before the @.

            Example input:

            derek.morgan@example.co.uk

            Output:

            ************@example.co.uk

            Rules:

            * Find the position of @.
            * Replace everything before @ with *.
            * Keep the domain.


            ============================================================
            ACCEPTANCE CRITERIA 6:
            CODE QUALITY
            ============================================================

            The solution should:

            * use clear naming
            * avoid one huge method
            * use helper methods where appropriate
            * handle invalid or empty input sensibly
            * be easy to explain in an interview

            Suggested helper methods:

            private string GetInitials(string name)

            private string GetCity(string address)

            private string MaskMobile(string mobile)

            private string MaskEmail(string email)


            ============================================================
            ACCEPTANCE CRITERIA 7:
            UNIT TESTING
            ============================================================

            Create at least one xUnit test.

            The test should:

            Arrange:
            * create test JSON input

            Act:
            * call RedactPersonalData

            Assert:
            * verify the output contains the expected redacted values

            Example expected values:

            DM
            Edinburgh
            *******0832
            ************@example.co.uk


            ============================================================
            INTERVIEW DISCUSSION QUESTIONS
            ============================================================

            Be prepared to explain:

            1. Why is Mobile a string and not an int?

               Because:
               * phone numbers are not used for calculations
               * leading zeroes matter
               * string operations are needed

            2. What is serialization?

               Converting a C# object into JSON.

               Example:

               C# object
                   ↓
               JSON string

            3. What is deserialization?

               Converting JSON into a C# object.

               Example:

               JSON string
                   ↓
               C# object

            4. Why use helper methods?

               To:
               * keep methods small
               * make logic easier to test
               * improve readability
               * make the main method easier to understand


            ============================================================
            MONDAY APPROACH
            ============================================================

            Do not jump straight into coding.

            Step 1:
            Read the acceptance criteria.

            Step 2:
            Write your plan before coding.

            Step 3:
            Build the models.

            Step 4:
            Implement RedactPersonalData.

            Step 5:
            Add one helper method at a time.

            Step 6:
            Test manually.

            Step 7:
            Add at least one xUnit test.

            Step 8:
            Practise explaining the solution.


            ============================================================
            IMPORTANT RULES
            ============================================================

            * Do not look at your previous solution.
            * Do not overengineer.
            * Do not use a database.
            * Do not build an API.
            * Keep it as a plain C# utility.
            * Use System.Text.Json unless you have a strong reason not to.
            * Keep the code easy to explain.
        */
    }

}
