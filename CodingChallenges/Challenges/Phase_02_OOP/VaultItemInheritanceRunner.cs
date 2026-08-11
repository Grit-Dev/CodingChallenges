namespace CodingChallenges.Challenges.Phase_02_OOP.Inheritance_Basics
{
    public class VaultItemInheritanceRunner
    {
        public static void Run()
        {
            CardItem card = new(
                "Ghost Signal",
                "Rare",
                80,
                120);

            SealedBoxItem sealedBox = new(
                "Night City Legend Display",
                36,
                true,
                250);

            BinderItem binder = new(
                "Cyberpunk Rare Binder",
                360,
                120,
                40);

            Console.WriteLine(card.BuildDisplayName() == "Ghost Signal (Card)");
            Console.WriteLine(card.IsHighValueCard() == true);

            Console.WriteLine(sealedBox.BuildDisplayName() == "Night City Legend Display (Sealed Box)");
            Console.WriteLine(sealedBox.ShouldKeepSealed() == true);

            Console.WriteLine(binder.BuildDisplayName() == "Cyberpunk Rare Binder (Binder)");
            Console.WriteLine(binder.CalculateEmptySlots() == 240);
        }
    }
}