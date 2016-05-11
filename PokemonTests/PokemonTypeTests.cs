using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pokemon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Tests
{
    [TestClass()]
    public class PokemonTypeTests
    {
        [TestInitialize]
        public void Initialize() {
            var game = new Game();
            Globals.TypeDictionary = game.LoadTypeDictionary();
        }

        [TestMethod()]
        public void GetNameTest() {
            // Checking if Getting Type name works
            Assert.IsTrue(Globals.TypeDictionary.Keys.ToArray()[0].GetName() == "Normal");

            // Should be Bug
            Assert.IsFalse(Globals.TypeDictionary.Keys.ToArray()[6].GetName() == "jriofjifr"); 
        }
    }
}