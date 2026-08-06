using System.Text.Json;

public class Program
{
    public class PersonData
    {
        public List<Person> People { get; set; } = [];
    }
    public class Person
    {
        public string Name { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public string Mobile { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;
    }

    public static string RedactPersonalData_RunFour(string json)
    {
        if (string.IsNullOrWhiteSpace(json))
        {
            return "";
        }

        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        };

        var jsonDeserialized = JsonSerializer.Deserialize<PersonData>(json, options);

        if (jsonDeserialized is null || jsonDeserialized.People == null)
        {
            return "";
        }

        foreach (var person in jsonDeserialized.People)
        {
            person.Name = NameRedaction_RunFour(person.Name);
            person.Address = AddressRedaction_RunFour(person.Address);
            person.Mobile = MobileNumberRedaction_RunFour(person.Mobile);
            person.Email = EmailAddressRedaction_RunFour(person.Email);
        }

        return JsonSerializer.Serialize(jsonDeserialized, options);

    }

    public static string NameRedaction_RunFour(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            return "";
        }

        string[] splitString = name.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        if (splitString.Length == 1)
        {
            return splitString[0][0].ToString().ToUpper();
        }

        string firstName = splitString[0].ToString().ToUpper();
        string firstInitial = firstName[0].ToString();
        string secondName = splitString[splitString.Length - 1].ToUpper();
        string secondInital = "";

        if (secondName.StartsWith("Mc", StringComparison.OrdinalIgnoreCase) && secondName.Length > 2)
        {
            secondInital = secondName[2].ToString().ToUpper();
        }
        else
        {
            secondInital = secondName[0].ToString().ToUpper();
        }

        return firstInitial + secondInital;
    }

    public static string AddressRedaction_RunFour(string address)
    {
        if (string.IsNullOrWhiteSpace(address))
        {
            return "";
        }

        string[] splitString = address.Split([','], StringSplitOptions.RemoveEmptyEntries);

        if (splitString.Length < 2)
        {
            return "";
        }

        return splitString[1].Trim();


    }

    public static string MobileNumberRedaction_RunFour(string mobile)
    {
        if (string.IsNullOrWhiteSpace(mobile))
        {
            return "";
        }

        mobile = mobile.Trim();

        if (mobile.Length <= 4)
        {
            return mobile;
        }

        int charactersLeftOver = mobile.Length - 4;

        string asterisks = new string('*', charactersLeftOver);

        string lastFourCharacters = mobile.Substring(charactersLeftOver);

        return asterisks + lastFourCharacters;
    }

    public static string EmailAddressRedaction_RunFour(string emailAddress)
    {
        if (string.IsNullOrWhiteSpace(emailAddress))
        {
            return "";
        }

        emailAddress = emailAddress.Trim();

        int indexOfAt = emailAddress.IndexOf('@');

        if (indexOfAt < 0)
        {
            return "";
        }

        string asterisks = new string('*', indexOfAt);

        string restOfEmail = emailAddress.Substring(indexOfAt);

        return asterisks + restOfEmail;
    }
    public static void Main(string[] args)
    {
        // REDACT PERSONAL DATA - SINGLE PERSON
        string json1 = @"{
            ""people"": [
                {
                    ""name"": ""Derek Morgan"",
                    ""address"": ""4321 Willow Lane, Edinburgh, EH12 7JQ"",
                    ""mobile"": ""07700900832"",
                    ""email"": ""derek.morgan@example.co.uk""
                }
            ]
        }";

        string result1 = RedactPersonalData_RunFour(json1);
        Console.WriteLine(result1);
        Console.WriteLine(result1.Contains(@"""name"":""DM"""));
        Console.WriteLine(result1.Contains(@"""address"":""Edinburgh"""));
        Console.WriteLine(result1.Contains(@"""mobile"":""*******0832"""));
        Console.WriteLine(result1.Contains(@"""email"":""************@example.co.uk"""));
        Console.WriteLine(result1.Contains("Derek Morgan") == false);
        Console.WriteLine(result1.Contains("4321 Willow Lane") == false);
        Console.WriteLine(result1.Contains("07700900832") == false);
        Console.WriteLine(result1.Contains("derek.morgan@example.co.uk") == false);

        // REDACT PERSONAL DATA - MC SURNAME
        string json2 = @"{
            ""people"": [
                {
                    ""name"": ""Robert McDowell"",
                    ""address"": ""12 Main Street, Belfast, BT1 1AA"",
                    ""mobile"": ""1234567890"",
                    ""email"": ""robert.mcdowell@test.com""
                }
            ]
        }";

        string result2 = RedactPersonalData_RunFour(json2);
        Console.WriteLine(result2.Contains(@"""name"":""RD"""));
        Console.WriteLine(result2.Contains(@"""address"":""Belfast"""));
        Console.WriteLine(result2.Contains(@"""mobile"":""******7890"""));
        Console.WriteLine(result2.Contains(@"""email"":""***************@test.com"""));
        Console.WriteLine(result2.Contains("Robert McDowell") == false);
        Console.WriteLine(result2.Contains("12 Main Street") == false);
        Console.WriteLine(result2.Contains("1234567890") == false);
        Console.WriteLine(result2.Contains("robert.mcdowell@test.com") == false);

        // REDACT PERSONAL DATA - SINGLE NAME
        string json3 = @"{
            ""people"": [
                {
                    ""name"": ""Derek"",
                    ""address"": ""4321 Willow Lane, Edinburgh, EH12 7JQ"",
                    ""mobile"": ""1234"",
                    ""email"": ""derek@example.com""
                }
            ]
        }";

        string result3 = RedactPersonalData_RunFour(json3);
        Console.WriteLine(result3.Contains(@"""name"":""D"""));
        Console.WriteLine(result3.Contains(@"""address"":""Edinburgh"""));
        Console.WriteLine(result3.Contains(@"""mobile"":""1234"""));
        Console.WriteLine(result3.Contains(@"""email"":""*****@example.com"""));
        Console.WriteLine(result3.Contains("4321 Willow Lane") == false);
        Console.WriteLine(result3.Contains("derek@example.com") == false);

        // REDACT PERSONAL DATA - MULTIPLE PEOPLE
        string json4 = @"{
            ""people"": [
                {
                    ""name"": ""Derek Morgan"",
                    ""address"": ""4321 Willow Lane, Edinburgh, EH12 7JQ"",
                    ""mobile"": ""07700900832"",
                    ""email"": ""derek.morgan@example.co.uk""
                },
                {
                    ""name"": ""Solid Snake"",
                    ""address"": ""5678 High Street, London, SW1A 1AA"",
                    ""mobile"": ""07700900777"",
                    ""email"": ""solid.snake@example.co.uk""
                },
                {
                    ""name"": ""Geralt McRivia"",
                    ""address"": ""1234 River Road, Belfast, BT1 1AA"",
                    ""mobile"": ""07700900901"",
                    ""email"": ""geralt.mcrivia@example.co.uk""
                }
            ]
        }";

        string result4 = RedactPersonalData_RunFour(json4);
        Console.WriteLine(result4.Contains(@"""name"":""DM"""));
        Console.WriteLine(result4.Contains(@"""address"":""Edinburgh"""));
        Console.WriteLine(result4.Contains(@"""mobile"":""*******0832"""));
        Console.WriteLine(result4.Contains(@"""email"":""************@example.co.uk"""));
        Console.WriteLine(result4.Contains(@"""name"":""SS"""));
        Console.WriteLine(result4.Contains(@"""address"":""London"""));
        Console.WriteLine(result4.Contains(@"""mobile"":""*******0777"""));
        Console.WriteLine(result4.Contains(@"""email"":""***********@example.co.uk"""));
        Console.WriteLine(result4.Contains(@"""name"":""GR"""));
        Console.WriteLine(result4.Contains(@"""address"":""Belfast"""));
        Console.WriteLine(result4.Contains(@"""mobile"":""*******0901"""));
        Console.WriteLine(result4.Contains(@"""email"":""**************@example.co.uk"""));
        Console.WriteLine(result4.Contains("Derek Morgan") == false);
        Console.WriteLine(result4.Contains("Solid Snake") == false);
        Console.WriteLine(result4.Contains("Geralt McRivia") == false);
        Console.WriteLine(result4.Contains("07700900832") == false);
        Console.WriteLine(result4.Contains("07700900777") == false);
        Console.WriteLine(result4.Contains("07700900901") == false);

        // INVALID INPUTS
        Console.WriteLine(RedactPersonalData_RunFour("") == "");
        Console.WriteLine(RedactPersonalData_RunFour("   ") == "");
        Console.WriteLine(RedactPersonalData_RunFour("null") == "");

        // INVALID EMAIL WITH NO @
        string json5 = @"{
            ""people"": [
                {
                    ""name"": ""Geralt Rivia"",
                    ""address"": ""1234 River Road, Belfast, BT1 1AA"",
                    ""mobile"": ""07700900901"",
                    ""email"": ""geralt.riviaexample.co.uk""
                }
            ]
        }";

        string result5 = RedactPersonalData_RunFour(json5);
        Console.WriteLine(result5.Contains(@"""email"":"""""));
        Console.WriteLine(result5.Contains("geralt.riviaexample.co.uk") == false);


        // EMAIL STARTING WITH @ - ALLOWED BECAUSE indexOfAt < 0 ONLY CHECKS MISSING @
        string json6 = @"{
            ""people"": [
                {
                    ""name"": ""Test User"",
                    ""address"": ""1 Road, Derry, BT48 1AA"",
                    ""mobile"": ""1234567"",
                    ""email"": ""@example.com""
                }
            ]
        }";

        string result6 = RedactPersonalData_RunFour(json6);
        Console.WriteLine(result6.Contains(@"""email"":""@example.com"""));

        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
