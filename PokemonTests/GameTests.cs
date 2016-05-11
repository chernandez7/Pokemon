using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pokemon;

namespace PokemonTests
{
    [TestClass()]
    public class GameTests
    {

        [TestInitialize]
        public void Initialize()
        {
            var game = new Game();
            Globals.TypeDictionary = game.LoadTypeDictionary();
        }

        [TestMethod()]
        public void LoadTypeDictionaryTest()
        {
            // Checking is "Normal" Types have a multiplier of 0 to "Ghost" Types
            Assert.IsTrue(Globals.TypeDictionary.Keys.ToArray()[Globals.GetTypeIndexByName("Normal")].GetMultiplier("Ghost") == 0.0);

            // Checking is "Fairy" Types have a multiplier of 1 to "Dragon" Types (Should be 2)
            Assert.IsFalse(Globals.TypeDictionary.Keys.ToArray()[Globals.GetTypeIndexByName("Fairy")].GetMultiplier("Dragon") == 1.0);

        }
    }
}