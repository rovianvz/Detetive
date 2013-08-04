using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Detetive;
using System.Collections.Generic;

namespace DetetiveTests
{
    [TestClass]
    public class LinUstOrvaldsTests
    {
        [TestMethod]
        public void TestEliminaSuspeito()
        {
            LinUstOrvalds l = new LinUstOrvalds(5, 5, 5);

            Dictionary<string, int> guess = l.nextGuess(1);

            Assert.AreEqual(guess[Constants.KEY_SUSPECT], 1);
            Assert.AreEqual(guess[Constants.KEY_PLACE], 0);
            Assert.AreEqual(guess[Constants.KEY_GUN], 0);
        }

        [TestMethod]
        public void TestEliminaLocal()
        {
            LinUstOrvalds l = new LinUstOrvalds(5, 5, 5);

            Dictionary<string, int> guess = l.nextGuess(2);

            Assert.AreEqual(guess[Constants.KEY_SUSPECT], 0);
            Assert.AreEqual(guess[Constants.KEY_PLACE], 1);
            Assert.AreEqual(guess[Constants.KEY_GUN], 0);
        }

        [TestMethod]
        public void TestEliminaArma()
        {
            LinUstOrvalds l = new LinUstOrvalds(5, 5, 5);

            Dictionary<string, int> guess = l.nextGuess(3);

            Assert.AreEqual(guess[Constants.KEY_SUSPECT], 0);
            Assert.AreEqual(guess[Constants.KEY_PLACE], 0);
            Assert.AreEqual(guess[Constants.KEY_GUN], 1);
        }
    }
}
