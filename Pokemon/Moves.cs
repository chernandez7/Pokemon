namespace Pokemon
{
    public class Move
    {
        public string Name { get; }
        public string Type { get; }
        public string Category { get; }
        public int CurrentPp { get; set; }
        public int MaxPp { get; }
        public int Power { get; }
        public float Accuracy { get; }
        public bool IsSpecial { get; }

        public Move(string name, string type, string category, int maxPp, int power, float accuracy, bool isSpecial)
        {
            Name = name;
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