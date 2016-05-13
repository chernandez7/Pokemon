namespace Pokemon
{
    public class PokemonStats
    {
        public int MaxHp { get; }
        public int CurrentHp { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int SpecialAttack { get; set; }
        public int SpecialDefense { get; set; }
        public int Speed { get; set; }

        public PokemonStats(int maxHp, int attack, int defense, int specialAttack, int specialDefense, int speed)
        {
            MaxHp = maxHp;
            CurrentHp = maxHp;
            Attack = attack;
            Defense = defense;
            SpecialAttack = specialAttack;
            SpecialDefense = specialDefense;
            Speed = speed;
        }
    }
}