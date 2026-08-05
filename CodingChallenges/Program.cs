using System.Text.Json;
using CodingChallenges.Challenges.Phase_02_OOP;
using CodingChallenges.Challenges.Phase_03_Practical_Challenges;

public class Program
{
    public class PeopleData
    {
        public List<People> Person {get; set;} = [];
    }
    public class People
    {
        public string Name {get; set;} = string.Empty;

        public string Address {get;set;} = string.Empty;

        public string Mobile {get;set;} = string.Empty;

        public string Email {get;set;} = string.Empty;
    }
    public string RedactPersonalData(string json)
    {
        if(string.IsNullOrWhiteSpace(json))
        {
            return "";
        }

        var deserialized = JsonSerializer.Deserialize<PeopleData>(json);

        if(deserialized is null || deserialized.Person is null)
        {
            return "";
        }

        foreach(var person in deserialized.Person)
        {
            person.Name = "";
            person.Address = "";
            person.Mobile = "";
            person.Email = "";
        }

        return JsonSerializer.Serialize(deserialized);

    }
    public static void Main(string[] args)
    {
        ChallengeSolutionsRunner.Run_Three();
        //JsonDataSanitizerRunner.Run();
    }

}
