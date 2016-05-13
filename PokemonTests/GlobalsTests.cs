using System;
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

            index = Globals.GetTypeIndexByName("Fight");
            Assert.IsTrue(index == 1);

            index = Globals.GetTypeIndexByName("Flying");
            Assert.IsTrue(index == 2);

            index = Globals.GetTypeIndexByName("Poison");
            Assert.IsTrue(index == 3);

            index = Globals.GetTypeIndexByName("Ground");
            Assert.IsTrue(index == 4);

            index = Globals.GetTypeIndexByName("Rock");
            Assert.IsTrue(index == 5);

            index = Globals.GetTypeIndexByName("Bug");
            Assert.IsTrue(index == 6);

            index = Globals.GetTypeIndexByName("Ghost");
            Assert.IsTrue(index == 7);

            index = Globals.GetTypeIndexByName("Steel");
            Assert.IsTrue(index == 8);

            index = Globals.GetTypeIndexByName("Fire");
            Assert.IsTrue(index == 9);

            index = Globals.GetTypeIndexByName("Water");
            Assert.IsTrue(index == 10);

            index = Globals.GetTypeIndexByName("Grass");
            Assert.IsTrue(index == 11);

            index = Globals.GetTypeIndexByName("Electric");
            Assert.IsTrue(index == 12);

            index = Globals.GetTypeIndexByName("Psychic");
            Assert.IsTrue(index == 13);

            index = Globals.GetTypeIndexByName("Ice");
            Assert.IsTrue(index == 14);

            index = Globals.GetTypeIndexByName("Dragon");
            Assert.IsTrue(index == 15);

            index = Globals.GetTypeIndexByName("Dark");
            Assert.IsTrue(index == 16);

            index = Globals.GetTypeIndexByName("Fairy");
            Assert.IsTrue(index == 17);
        }

        [TestMethod()]
        [ExpectedException(typeof (ArgumentException), "Not a valid Type")]
        public void GetTypeIndexByNameDefaultTest()
        {
            var index = Globals.GetTypeIndexByName("Fairy12345");
        }
    }
}