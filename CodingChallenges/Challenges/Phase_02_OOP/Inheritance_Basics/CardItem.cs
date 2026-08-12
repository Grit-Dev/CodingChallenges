using CodingChallenges.Challenges.Phase_02_OOP.shared;

namespace CodingChallenges.Challenges.Phase_02_OOP.Inheritance_Basics
{
    public class CardItem : VaultItem
    {
        public string Rarity { get; set; } = string.Empty;

        public int Attack { get; set; }

        public CardItem(
            string name,
            string rarity,
            int attack,
            int estimatedValue)
            : base(name, "Card", estimatedValue)
        {
            Rarity = rarity;
            Attack = attack;
        }

        public bool IsHighValueCard()
        {
            return EstimatedValue >= 100;
        }

        
        public override string BuildDisplayName()
        {
            return $"{Name} - {Rarity} - Attack {Attack} - £{EstimatedValue}";
        }
    }
}