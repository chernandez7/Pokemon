using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public static class Globals
    {
        public static Dictionary<PokemonType, float[]> TypeDictionary;

        public static int GetTypeIndexByName(string name)
        {
            switch (name)
            {
                case "Normal":
                    return 0;
                case "Fight":
                    return 1;
                case "Flying":
                    return 2;
                case "Poison":
                    return 3;
                case "Ground":
                    return 4;
                case "Rock":
                    return 5;
                case "Bug":
                    return 6;
                case "Ghost":
                    return 7;
                case "Steel":
                    return 8;
                case "Fire":
                    return 9;
                case "Water":
                    return 10;
                case "Grass":
                    return 11;
                case "Electric":
                    return 12;
                case "Psychic":
                    return 13;
                case "Ice":
                    return 14;
                case "Dragon":
                    return 15;
                case "Dark":
                    return 16;
                case "Fairy":
                    return 17;
                default:
                    throw new Exception("Not a valid Type");
            }
        }
    }
}
