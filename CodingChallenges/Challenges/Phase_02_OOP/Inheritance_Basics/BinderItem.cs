namespace CodingChallenges.Challenges.Phase_02_OOP.Inheritance_Basics
{
    public class BinderItem : VaultItem
    {
        public int CardSlots {get; set;}

        public int FilledSlots {get; set;}

        public BinderItem(string name, int cardSlots, int filledSlots, int estimatedValue)
        : base(name, "Binder", estimatedValue)
        {
            CardSlots = cardSlots;
            FilledSlots = filledSlots;
        }

        public int CalculateEmptySlots()
        {
            if(FilledSlots > CardSlots)
            {
                return 0;
            }

            return CardSlots - FilledSlots;
        }
    }
}