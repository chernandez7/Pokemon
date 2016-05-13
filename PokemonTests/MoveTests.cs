using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pokemon;

namespace PokemonTests
{
    [TestClass()]
    public class MoveTests
    {
        private Move _tackle;

        [TestInitialize]
        public void Initialize()
        {
            _tackle = new Move("Tackle", "Normal", "Physical", 35, 50, 100, false);
        }

        [TestMethod()]
        public void MoveTest()
        {
            Assert.IsTrue(_tackle.Name == "Tackle");
            Assert.IsTrue(_tackle.Type == "Normal");
            Assert.IsTrue(_tackle.Category == "Physical");
            Assert.IsTrue(_tackle.MaxPp == 35);
            Assert.IsTrue(_tackle.Power == 50);
            Assert.IsTrue(Math.Abs(_tackle.Accuracy - 100) < .1);
            Assert.IsTrue(_tackle.IsSpecial == false);
        }

        [TestMethod()]
        public void PpDeduction()
        {
            // Initial Pp Count
            Assert.IsTrue(_tackle.CurrentPp == 35);

            // Move used
            _tackle.CurrentPp--;
            Assert.IsTrue(_tackle.CurrentPp == 34);
        }
    }
}