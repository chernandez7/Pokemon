using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pokemon;

namespace PokemonTests
{
    [TestClass()]
    public class PokemonTypeTests
    {
        [TestInitialize]
        public void Initialize()
        {
            var game = new Game();
            Globals.TypeDictionary = game.LoadTypeDictionary();
        }

        [TestMethod()]
        public void GetNameTest()
        {
            // Checking if Getting Type name works
            Assert.IsTrue(Globals.TypeDictionary.Keys.ToArray()[0].GetName() == "Normal");

            // Should be "Bug"
            Assert.IsFalse(Globals.TypeDictionary.Keys.ToArray()[6].GetName() == "jriofjifr");
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