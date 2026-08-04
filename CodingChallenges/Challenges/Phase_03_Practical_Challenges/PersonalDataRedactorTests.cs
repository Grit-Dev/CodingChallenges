using Xunit;

namespace CodingChallenges.Challenges.Phase_03_Practical_Challenges
{
    public class PersonalDataRedactorTests
    {
        private static string GetJsonInput =>
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

        [Fact]
        public void RedactPersonalData_WithValidPerson_RedactsExpectedValues()
        {
            // Act
            var actualResult = PersonalDataRedactor.RedactPersonalData(GetJsonInput);

            // Assert
            Assert.Contains(@"""name"":""DM""", actualResult);
            Assert.Contains(@"""address"":""Edinburgh""", actualResult);
            Assert.Contains(@"""mobile"":""*******0832""", actualResult);
            Assert.Contains(@"""emailAddress"":""************@example.co.uk""", actualResult);
            Assert.DoesNotContain("Derek Morgan", actualResult);
            Assert.DoesNotContain("4321 Willow Lane", actualResult);
            Assert.DoesNotContain("07700900832", actualResult);
            Assert.DoesNotContain("derek.morgan@example.co.uk", actualResult);
        }

        [Fact(Skip = "TODO: implement test")]
        public void RedactPersonalData_WithMcSurname_IgnoresMcForSurnameInitial()
        {
        }

        [Fact(Skip = "TODO: implement test")]
        public void RedactPersonalData_WithSingleName_ReturnsSingleInitial()
        {
        }

        [Fact(Skip = "TODO: implement test")]
        public void RedactPersonalData_WithMultiplePeople_RedactsAllPeople()
        {
        }

        [Fact(Skip = "TODO: implement test")]
        public void RedactPersonalData_WithEmptyJson_ReturnsEmptyString()
        {
        }

        [Fact(Skip = "TODO: implement test")]
        public void RedactPersonalData_WithWhitespaceJson_ReturnsEmptyString()
        {
        }

        [Fact(Skip = "TODO: implement test")]
        public void RedactPersonalData_WithMobileShorterThanFourCharacters_KeepsMobile()
        {
        }

        [Fact(Skip = "TODO: implement test")]
        public void RedactPersonalData_WithInvalidEmail_ReturnsEmptyEmail()
        {
        }
    }
}
