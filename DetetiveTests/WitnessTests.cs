using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Detetive;
using System.Collections.Generic;

namespace DetetiveTests
{
    [TestClass]
    public class WitnessTests
    {

        [TestMethod]
        public void TesteRetornoSomenteSuspeitoErrado()
        {
            Witness t = new Witness(3, 3, 3);

            Dictionary<string, int> hint = new Dictionary<string, int>();
            hint.Add(Constants.KEY_SUSPECT, 4);
            hint.Add(Constants.KEY_PLACE, 3);
            hint.Add(Constants.KEY_GUN, 3);

            Assert.AreEqual(t.nextTip(hint), 1);

        }

        [TestMethod]
        public void TesteRetornoSomenteLugarErrado()
        {
            Witness t = new Witness(3, 3, 3);

            Dictionary<string, int> hint = new Dictionary<string,int>();
            hint.Add(Constants.KEY_SUSPECT, 3);
            hint.Add(Constants.KEY_PLACE, 4);
            hint.Add(Constants.KEY_GUN, 3);

            Assert.AreEqual(t.nextTip(hint), 2);
   
        }

        [TestMethod]
        public void TesteRetornoSomenteArmaErrado()
        {
            Witness t = new Witness(3, 3, 3);

            Dictionary<string, int> hint = new Dictionary<string, int>();
            hint.Add(Constants.KEY_SUSPECT, 3);
            hint.Add(Constants.KEY_PLACE, 3);
            hint.Add(Constants.KEY_GUN, 4);

            Assert.AreEqual(t.nextTip(hint), 3);

        }

        [TestMethod]
        public void TesteRetornoSuspeitoELugarErrado()
        {
            Witness t = new Witness(3, 3, 3);

            Dictionary<string, int> hint = new Dictionary<string, int>();
            hint.Add(Constants.KEY_SUSPECT, 4);
            hint.Add(Constants.KEY_PLACE, 4);
            hint.Add(Constants.KEY_GUN, 3);

            Assert.IsTrue((t.nextTip(hint) == 1) || (t.nextTip(hint) == 2));

        }

        [TestMethod]
        public void TesteRetornoSuspeitoEArmaErrado()
        {
            Witness t = new Witness(3, 3, 3);

            Dictionary<string, int> hint = new Dictionary<string, int>();
            hint.Add(Constants.KEY_SUSPECT, 4);
            hint.Add(Constants.KEY_PLACE, 3);
            hint.Add(Constants.KEY_GUN, 4);

            Assert.IsTrue((t.nextTip(hint) == 1) || (t.nextTip(hint) == 3));

        }

        [TestMethod]
        public void TesteRetornoLugarEArmaErrado()
        {
            Witness t = new Witness(3, 3, 3);

            Dictionary<string, int> hint = new Dictionary<string, int>();
            hint.Add(Constants.KEY_SUSPECT, 3);
            hint.Add(Constants.KEY_PLACE, 4);
            hint.Add(Constants.KEY_GUN, 4);

            Assert.IsTrue((t.nextTip(hint) == 3) || (t.nextTip(hint) == 2));

        }

        [TestMethod]
        public void TesteRetornoTodosErrados()
        {
            Witness t = new Witness(3, 3, 3);

            Dictionary<string, int> hint = new Dictionary<string, int>();
            hint.Add(Constants.KEY_SUSPECT, 4);
            hint.Add(Constants.KEY_PLACE, 4);
            hint.Add(Constants.KEY_GUN, 4);

            Assert.IsTrue((t.nextTip(hint) == 1) || (t.nextTip(hint) == 2) || (t.nextTip(hint) == 3));

        }

        [TestMethod]
        public void TesteRetornoRespostaCorreta()
        {
            Witness t = new Witness(3, 3, 3);

            Dictionary<string, int> hint = new Dictionary<string, int>();
            hint.Add(Constants.KEY_SUSPECT, 3);
            hint.Add(Constants.KEY_PLACE, 3);
            hint.Add(Constants.KEY_GUN, 3);

            Assert.AreEqual(t.nextTip(hint), 0);

        }


    }
}
