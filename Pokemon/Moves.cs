namespace Pokemon
{
    internal class Move
    {
        public string Type { get; set; }
        public string Category { get; set; }
        public int CurrentPp { get; set; }
        public int MaxPp { get; set; }
        public int Power { get; set; }
        public float Accuracy { get; set; }
        public bool IsSpecial { get; set; }

        public Move(string type, string category, int maxPp, int power, float accuracy, bool isSpecial)
        {
            Type = type;
            Category = category;
            MaxPp = maxPp;
            CurrentPp = maxPp;
            Power = power;
            Accuracy = accuracy;
            IsSpecial = isSpecial;
        }
    }
}