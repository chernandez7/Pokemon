using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PokemonTests
{
    [TestClass]
    public class MainTesting
    {
        [TestMethod]
        public void CompilerCheck() {
            // Checking that testing framework works
            Assert.IsTrue("Hello World!".Equals("Hello World!"));
        }
    }
}
