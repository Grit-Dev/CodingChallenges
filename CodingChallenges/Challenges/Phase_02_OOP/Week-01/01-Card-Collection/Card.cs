namespace CodingChallenges.Challenges.Phase_02_OOP.Week_01._01_Card_Collection
{
    public class Card
    {
        public string Name { get; set; } = string.Empty;

        public string Rarity { get; set; } = string.Empty;

        public int Attack { get; set; }

        public Card()
        {
        }

        public Card(string name, string rarity, int attack)
        {
            Name = name;
            Rarity = rarity;
            Attack = attack;
        }

    }
}
