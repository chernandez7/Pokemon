using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pokemon;

namespace PokemonTests
{
    [TestClass()]
    public class PokemonTypeTests
    {
        private PokemonType _normal;

        [TestInitialize]
        public void Initialize()
        {
            var game = new Game();
            Globals.TypeDictionary = Game.LoadTypeDictionary();

            _normal = new PokemonType("Normal");
        }

        [TestMethod()]
        public void GetNameTest()
        {
            // Checking if Getting Type name works
            Assert.IsTrue(_normal.Name == "Normal");

            // Should be "Bug"
            Assert.IsFalse(_normal.Name == "jriofjifr");

            // Check number of elements
            Assert.IsTrue(Globals.TypeDictionary.Keys.Count == 18);
        }

        [TestMethod()]
        public void GetMultiplierTest()
        {
            // Checking is "Normal" Types have a multiplier of 0 to "Ghost" Types
            Assert.IsTrue(Math.Abs(Globals.TypeDictionary.Keys.ToArray()[Globals.GetTypeIndexByName("Normal")].GetMultiplier("Ghost")) < .1);

            // Checking is "Fairy" Types have a multiplier of 1 to "Dragon" Types (Should be 2)
            Assert.IsFalse(Math.Abs(Globals.TypeDictionary.Keys.ToArray()[Globals.GetTypeIndexByName("Fairy")].GetMultiplier("Dragon") - 1.0) < .1);
        }
    }
}