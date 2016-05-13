using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pokemon;

namespace PokemonTests
{
    [TestClass()]
    public class PokemonTests
    {
        private Pokemon.Pokemon _pikachu;

        [TestInitialize]
        public void Initialize()
        {
            // Create Type List
            var typesList = new List<PokemonType>(1);
            var electric = new PokemonType("Electric");
            typesList.Add(electric);

            // Create Moves list
            var movesList = new List<Move>();

            var quickAttack = new Move("Quick Attack", "Normal", "Physical", 30, 40, 100, false);
            movesList.Add(quickAttack);

            var thunderShock = new Move("Thunder Shock", "Electric", "Special", 30, 40, 100, true);
            movesList.Add(thunderShock);

            // Create Stats Object
            var stats = new PokemonStats(35, 55, 40, 50, 50, 90);

            // Create Pokemon Object
            _pikachu = new Pokemon.Pokemon("Pikachu", typesList, movesList, stats);
        }

        [TestMethod()]
        public void PokemonTest()
        {
            //TODO
        }
    }
}