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

        [Fact]
        public void RedactPersonalData_WithMcSurname_IgnoresMcForSurnameInitial()
        {
            // Arrange
            var json = @"{
                    ""people"": [
                        {
                            ""name"": ""Derek McMorgan"",
                            ""address"": """",
                            ""mobile"": """",
                            ""emailAddress"": """"
                        }
                    ]
                }";

            // Act 
            var actualResult = PersonalDataRedactor.RedactPersonalData(json);

            // Assert
            Assert.Contains(@"""name"":""DM""", actualResult);
            Assert.DoesNotContain("Derek Morgan", actualResult);
        }

        [Fact]
        public void RedactPersonalData_WithSingleName_ReturnsSingleInitial()
        {
            // Arrange
            var json = @"{
                    ""people"": [
                        {
                            ""name"": ""Derek"",
                            ""address"": """",
                            ""mobile"": """",
                            ""emailAddress"": """"
                        }
                    ]
                }";

            // Act 
            var actualResult = PersonalDataRedactor.RedactPersonalData(json);

            // Assert
            Assert.Contains(@"""name"":""D""", actualResult);
            Assert.DoesNotContain("Derek", actualResult);
        }

        [Fact]
        public void RedactPersonalData_WithMultiplePeople_RedactsAllPeople()
        {
            // Arrange 
            var json = @"{
                ""people"": [
                    {
                        ""name"": ""Derek"",
                        ""address"": ""4321, Edinburgh, EH13 767"",
                        ""mobile"": ""07700900555"",
                        ""emailAddress"": ""derek.morgan@example.co.uk""
                    },
                    {
                        ""name"": ""Solid Snake"",
                        ""address"": ""5678, London, EH14 777"",
                        ""mobile"": ""07700900777"",
                        ""emailAddress"": ""solid.snake@example.co.uk""
                    },
                    {
                        ""name"": ""Geralt McRivia"",
                        ""address"": ""1234, Belfast, EH15 888"",
                        ""mobile"": ""07700900901"",
                        ""emailAddress"": ""geralt.mcrivia@example.co.uk""
                    }
                ]
            }";

            // Act    
            var actualResult = PersonalDataRedactor.RedactPersonalData(json);

            // Assert

            // Derek
            Assert.Contains(@"""name"":""D""", actualResult);
            Assert.Contains(@"""address"":""Edinburgh""", actualResult);
            Assert.Contains(@"""mobile"":""*******0555""", actualResult);
            Assert.Contains(@"""emailAddress"":""************@example.co.uk""", actualResult);

            // Solid Snake
            Assert.Contains(@"""name"":""SS""", actualResult);
            Assert.Contains(@"""address"":""London""", actualResult);
            Assert.Contains(@"""mobile"":""*******0777""", actualResult);
            Assert.Contains(@"""emailAddress"":""***********@example.co.uk""", actualResult);

            // Geralt McRivia
            Assert.Contains(@"""name"":""GR""", actualResult);
            Assert.Contains(@"""address"":""Belfast""", actualResult);
            Assert.Contains(@"""mobile"":""*******0901""", actualResult);
            Assert.Contains(@"""emailAddress"":""**************@example.co.uk""", actualResult);

            Assert.DoesNotContain("07700900555", actualResult);
            Assert.DoesNotContain("07700900777", actualResult);
            Assert.DoesNotContain("07700900901", actualResult);

            Assert.DoesNotContain("derek.morgan@example.co.uk", actualResult);
            Assert.DoesNotContain("solid.snake@example.co.uk", actualResult);
            Assert.DoesNotContain("geralt.mcrivia@example.co.uk", actualResult);
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
