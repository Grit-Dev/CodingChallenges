using System.Text.Json;
using System.Text.Json.Serialization;
using CodingChallenges.Challenges.Phase_03_Practical_Challenges;

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

    public string RedactPersonalData_RunFour(string json)
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
            person.Name = "";
            person.Address = "";
            person.Mobile = "";
            person.Email = "";
        }

        return JsonSerializer.Serialize(jsonDeserialized, options);

    }
    public static void Main(string[] args)
    {
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
