using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class Pokemon
    {
        public string Name { get; set; }
        public List<PokemonType> TypesList { get; set; }
        public List<Move> MovesList { get; set; }
        public int MaxHp { get; set; }
        public int CurrentHp { get; set; }
        public PokemonStats PokemonStats { get; set; }

        public Pokemon(string name, List<PokemonType> typesList, List<Move> movesList, PokemonStats pokemonStats)
        {
            Name = name;
            TypesList = typesList;
            MovesList = movesList;
            MaxHp = maxHp;
            CurrentHp = maxHp;
            PokemonStats = pokemonStats;
        }
    }
}
