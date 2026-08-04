using CodingChallenges.Challenges.Phase_03_Practical_Challenges;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using System.Numerics;
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

        public string EmailAddress { get; set; } = string.Empty;
    }

    public static string NameRedaction(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            return "";
        }

        string[] splitString = name.Split([' '], StringSplitOptions.RemoveEmptyEntries);

        if (splitString.Length == 1)
        {
            return splitString[0][0].ToString().Trim().ToUpper();
        }

        string firstName = splitString[0][0].ToString().ToUpper();

        string secondName = splitString[1];

        if (secondName.StartsWith("Mc", StringComparison.OrdinalIgnoreCase) && secondName.Length > 2)
        {
            secondName = secondName[2].ToString().ToUpper();
        }
        else
        {
           secondName = secondName[0].ToString().ToUpper();
        }

        return firstName + secondName;
    }

    public static string RedactPersonalData(string json)
    {
        if (string.IsNullOrEmpty(json))
        {
            return "";
        }

        var options = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            PropertyNameCaseInsensitive = true
        };

        var jsonDeserialized = JsonSerializer.Deserialize<PeopleData>(json, options);

        if (jsonDeserialized == null || jsonDeserialized.People.Count == 0)
        {
            return "";
        }

        foreach (var person in jsonDeserialized.People)
        {
            person.Name = NameRedaction(person.Name.Trim());
            person.Address = "";
            person.Mobile = "";
            person.EmailAddress = "";
        }

        var jsonSerialized = JsonSerializer.Serialize(jsonDeserialized);

        return jsonSerialized;
    }
    public static void Main(string[] args)
    {



        //Console.WriteLine("=== NameRedaction Tests ===");
        //Console.WriteLine(NameRedaction("Derek Morgan") == "DM");
        //Console.WriteLine(NameRedaction("Robert McDowell") == "RD");
        //Console.WriteLine(NameRedaction("Robert mcdowell") == "RD");
        //Console.WriteLine(NameRedaction("Derek") == "D");
        //Console.WriteLine(NameRedaction("  Derek   Morgan  ") == "DM");
        //Console.WriteLine(NameRedaction("Mary Smith") == "MS");
        //Console.WriteLine(NameRedaction("") == "");
        //Console.WriteLine(NameRedaction("   ") == "");

        //JsonDataSanitizerRunner.Run();
    }

}
 