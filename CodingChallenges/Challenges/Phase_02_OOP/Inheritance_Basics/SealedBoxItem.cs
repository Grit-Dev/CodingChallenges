namespace CodingChallenges.Challenges.Phase_02_OOP.Inheritance_Basics
{
    public class SealedBoxItem : VaultItem
    {
        public int PackCount { get; set; }
        public bool IsSealed { get; set; }


        public SealedBoxItem(string name, int packCount, bool isSealed, int estimatedValue)
        : base(name, "Sealed Box", estimatedValue)
        {
            PackCount = packCount;
            IsSealed = isSealed;
        }

        public bool ShouldKeepSealed()
        {
            return IsSealed && EstimatedValue >= 200;
        }

        
        public override string BuildDisplayName()
        {
            return $"{Name} - Sealed Box - Packs {PackCount} - £{EstimatedValue}";
        }

    }
}