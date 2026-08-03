namespace CodingChallenges.Challenges.Phase_03_Practical_Challenges
{
    public class JsonDataSanitizerRunner
    {
        public static void Run()
        {
            Console.WriteLine("=== JSON Personal Data Redactor Tests ===");

            string inputJson =
                @"{
                    ""people"": [
                        {
                            ""name"": ""Derek Morgan"",
                            ""address"": ""4321 Willow Lane, Edinburgh, EH12 7JQ"",
                            ""mobile"": ""07700900832"",
                            ""emailAddress"": ""derek.morgan@example.co.uk""
                        }
                    ]
                }";

            string result = PersonalDataRedactor.RedactPersonalData(inputJson);

            Console.WriteLine(result);

            Console.WriteLine(result.Contains("DM"));
            Console.WriteLine(result.Contains("Edinburgh"));
            Console.WriteLine(result.Contains("*******0832"));
            Console.WriteLine(result.Contains("************@example.co.uk"));

            Console.WriteLine(result.Contains("Derek Morgan") == false);
            Console.WriteLine(result.Contains("4321 Willow Lane") == false);
            Console.WriteLine(result.Contains("07700900832") == false);
            Console.WriteLine(result.Contains("derek.morgan@example.co.uk") == false);
        }
    }
}