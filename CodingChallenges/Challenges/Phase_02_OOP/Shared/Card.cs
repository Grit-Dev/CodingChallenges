namespace CodingChallenges.Challenges.Phase_02_OOP.shared
{
    public class Card
    {
        public string Name { get; set; } = string.Empty;

        public string Rarity { get; set; } = string.Empty;

        public int Attack { get; set; }

        public int Price { get; set; }

        public Card()
        {
        }

        public Card(string name, string rarity, int attack)
        {
            Name = name;
            Rarity = rarity;
            Attack = attack;
            Price = 0;
        }

        public Card(string name, string rarity, int attack, int price)
        {
            Name = name;
            Rarity = rarity;
            Attack = attack;
            Price = price;
        }
    }
}