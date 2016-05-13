using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pokemon;

namespace PokemonTests
{
    [TestClass()]
    public class PokemonStatsTests
    {
        private PokemonStats _stats;

        [TestInitialize]
        public void Initialize()
        {
            // Bulbasaur Base Stats
            _stats = new PokemonStats(45, 49, 49, 65, 65, 45);
        }

        [TestMethod()]
        public void MoveTest()
        {
            Assert.IsTrue(_stats.MaxHp == 45);
            Assert.IsTrue(_stats.CurrentHp == 45);
            Assert.IsTrue(_stats.Attack == 49);
            Assert.IsTrue(_stats.Defense == 49);
            Assert.IsTrue(_stats.SpecialAttack == 65);
            Assert.IsTrue(_stats.SpecialDefense == 65);
            Assert.IsTrue(_stats.Speed == 45);

        }
    }
}