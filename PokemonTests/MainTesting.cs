using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PokemonTests
{
    [TestClass]
    public class MainTesting
    {
        [TestMethod]
        public void CompilerCheck() {
            Assert.IsTrue("Hello World!".Equals("Hello World!"));
        }
    }
}
