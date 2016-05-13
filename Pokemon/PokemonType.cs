using System;

namespace Pokemon
{
    public class PokemonType {
    /* Pokemon Types
     * 1    Normal
     * 2    Fight
     * 3    Flying
     * 4    Poison
     * 5    Ground
     * 6    Rock
     * 7    Bug
     * 8    Ghost
     * 9    Steel
     * 10   Fire
     * 11   Water
     * 12   Grass
     * 13   Electric
     * 14   Psychic
     * 15   Ice
     * 16   Dragon
     * 17   Dark
     * 18   Fairy
     */
        public string Name { get; set; }
        public float[] MultiplierArray { get; set; } // Holds weakness/strength toward another type

        public PokemonType(string name) {
            Name = name;
            MultiplierArray = Globals.TypeDictionary[this];
        }

        // Gets multiplier value from attacking type -> opponent type
        public float GetMultiplier(string opponentTypeName) {
            var index = Globals.GetTypeIndexByName(opponentTypeName);
            return Globals.TypeDictionary[this][index];
        }
    }
}
