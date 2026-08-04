using CodingChallenges.Challenges.Phase_03_Practical_Challenges;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
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
    public static string RedactPersonalData(string json)
    {
        if (string.IsNullOrEmpty(json))
        {
            return "";
        }

        var options = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            PropertyNameCaseInsensitive = true,

        };

        var jsonDeserialized = JsonSerializer.Deserialize<PeopleData>(json, options);

        if (jsonDeserialized == null || jsonDeserialized.People.Count == 0)
        {
            return "";
        }

        foreach (var person in jsonDeserialized.People)
        {
            person.Name = "";
            person.Address = "";
            person.Mobile = "";
            person.EmailAddress = "";
        }

        var jsonSerialized = JsonSerializer.Serialize(jsonDeserialized);

        return jsonSerialized;
    }
    public static void Main(string[] args)
    {


        //JsonDataSanitizerRunner.Run();
    }

}
 