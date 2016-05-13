using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pokemon;

namespace PokemonTests
{
    [TestClass()]
    public class GlobalsTests
    {
        [TestMethod()]
        public void GetTypeIndexByNameTest()
        {
            // Testing that function returns the expected index
            var index = Globals.GetTypeIndexByName("Normal");
            Assert.IsTrue(index == 0);

            index = Globals.GetTypeIndexByName("Steel");
            Assert.IsTrue(index == 8);

            index = Globals.GetTypeIndexByName("Fairy");
            Assert.IsTrue(index == 17);
        }
    }
}