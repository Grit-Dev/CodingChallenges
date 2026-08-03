using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using CodingChallenges.Challenges;

public class Program
{
    public class PeopleData
    {
        public List<Person> People = [];
    }

    public class Person
    {
        public string Name {get; set;} = string.Empty;

        public string Address {get; set;} = string.Empty;

        public string Mobile {get; set;} = string.Empty;

        public string EmailAddress {get; set;} = string. Empty;
    }

    private static string NameRedaction(string fullName)
    {
        if(string.IsNullOrWhiteSpace(fullName))
        {
            return "";
        }

        string [] splitString = fullName.Split([' '], StringSplitOptions.RemoveEmptyEntries);

        if(splitString.Length == 0)
        {
            return "";
        }

        if(splitString.Length == 1)
        {
            return splitString[0][0].ToString().ToUpper();
        }

        string firstName = splitString[0];
        string surname = splitString[^1];

        char firstInitial = firstName[0];
        char surnameInitial;

        if(surname.StartsWith("Mc", StringComparison.OrdinalIgnoreCase) &&
        surname.Length > 2)
        {
            surnameInitial = surname[2];
        }
        else
        {
            surnameInitial = surname[0];
        }

        return $"{char.ToUpper(firstInitial)}{char.ToUpper(surnameInitial)}";

    }

    public static string AddressRedaction(string houseAddress)
    {
        if(string.IsNullOrWhiteSpace(houseAddress))
        {
            return "";
        }

        string [] splitString = houseAddress.Split([','], StringSplitOptions.RemoveEmptyEntries);

        if(splitString.Length < 2)
        {
            return "";
        }

        return splitString[1].ToString().Trim();
    }

    private static string EmailAddressRedaction(string EmailAddress)
    {
        if(string.IsNullOrWhiteSpace(EmailAddress))
        {
            return "";
        }

        var indexOfSpecialCharacter = EmailAddress.IndexOf('@');

        if(indexOfSpecialCharacter < 0)
        {
            return "";
        }

        var stringWithAsterisks = new string('*' , indexOfSpecialCharacter);

        var restOfEmail = EmailAddress.Substring(indexOfSpecialCharacter);

        return stringWithAsterisks + restOfEmail;


    }

    public static string RedactPersonalData(string json)
    {
        PeopleData? deserializationOfJson = JsonSerializer.Deserialize<PeopleData>(json);

        if(deserializationOfJson is null)
        {
            return "";
        }

        foreach(Person person in deserializationOfJson.People)
        {
            person.Name = NameRedaction(person.Name);
            person.Address = AddressRedaction(person.Address);
            person.Mobile = "";
            person.EmailAddress = EmailAddressRedaction(person.EmailAddress);
        }

        var serializationOfJson = JsonSerializer.Serialize(deserializationOfJson);
        
        return serializationOfJson;
    }

    public static void Main(string[] args)
    {

        // EMAIL REDACTION
        Console.WriteLine(EmailAddressRedaction("derek.morgan@example.co.uk") == "************@example.co.uk");
        Console.WriteLine(EmailAddressRedaction("paul@example.com") == "****@example.com");
        Console.WriteLine(EmailAddressRedaction("john.smith@test.com") == "**********@test.com");
        Console.WriteLine(EmailAddressRedaction("a@test.com") == "*@test.com");
        Console.WriteLine(EmailAddressRedaction("abc@domain.com") == "***@domain.com");
        Console.WriteLine(EmailAddressRedaction("@example.com") == "@example.com");
        Console.WriteLine(EmailAddressRedaction("no-at-symbol") == "");
        Console.WriteLine(EmailAddressRedaction("") == "");
        Console.WriteLine(EmailAddressRedaction("   ") == "");
        Console.WriteLine(EmailAddressRedaction(null!) == "");
        
        // Address Redaction
        // Console.WriteLine(AddressRedaction("4321 Willow Lane, Edinburgh, EH12 7JQ") == "Edinburgh");
        // Console.WriteLine(AddressRedaction("12 Main Street, Belfast, BT1 1AA") == "Belfast");
        // Console.WriteLine(AddressRedaction("99 River Road, Derry, BT48 6DQ") == "Derry");
        // Console.WriteLine(AddressRedaction("1 High Street, London, SW1A 1AA") == "London");
        // Console.WriteLine(AddressRedaction("Unit 5 Industrial Estate, Dublin, D02 AB12") == "Dublin");
        // Console.WriteLine(AddressRedaction("") == "");
        // Console.WriteLine(AddressRedaction("   ") == "");
        // Console.WriteLine(AddressRedaction(null!) == "");

        // Name Redaction
        // Console.WriteLine(NameRedaction("Derek Morgan") == "DM");
        // Console.WriteLine(NameRedaction("Robert McDowell") == "RD");
        // Console.WriteLine(NameRedaction("paul mcginley") == "PG");
        // Console.WriteLine(NameRedaction("V") == "V");
        // Console.WriteLine(NameRedaction("") == "");
        // Console.WriteLine(NameRedaction("   ") == "");
                
        // JsonDataSanitizerRunner.Run();
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
