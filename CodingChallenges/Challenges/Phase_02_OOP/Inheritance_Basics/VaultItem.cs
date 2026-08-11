using System.Dynamic;

namespace CodingChallenges.Challenges.Phase_02_OOP.Inheritance_Basics
{
    public class VaultItem
    {
        public string Name {get; set;} = string.Empty;

        public string Category {get; set;} = string.Empty;

        public int EstimatedValue {get; set;}

        public VaultItem(string name, string category, int estimatedValue)
        {
            Name = name;
            Category = category;
            EstimatedValue = estimatedValue;
        }

        public string BuildDisplayName()
        {
            return Name + " (" + Category + ")";
        }
    }
}