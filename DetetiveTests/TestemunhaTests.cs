using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Detetive;
using System.Collections.Generic;

namespace DetetiveTests
{
    [TestClass]
    public class TestemunhaTests
    {

        [TestMethod]
        public void TesteRetornoSomenteSuspeitoErrado()
        {
            Testemunha t = new Testemunha(3, 3, 3);

            Dictionary<string, int> cue = new Dictionary<string, int>();
            cue.Add(Constants.KEY_SUSPECT, 4);
            cue.Add(Constants.KEY_PLACE, 3);
            cue.Add(Constants.KEY_GUN, 3);

            Assert.AreEqual(t.nextTip(cue), 1);

        }

        [TestMethod]
        public void TesteRetornoSomenteLugarErrado()
        {
            Testemunha t = new Testemunha(3, 3, 3);

            Dictionary<string, int> cue = new Dictionary<string,int>();
            cue.Add(Constants.KEY_SUSPECT, 3);
            cue.Add(Constants.KEY_PLACE, 4);
            cue.Add(Constants.KEY_GUN, 3);

            Assert.AreEqual(t.nextTip(cue), 2);
   
        }

        [TestMethod]
        public void TesteRetornoSomenteArmaErrado()
        {
            Testemunha t = new Testemunha(3, 3, 3);

            Dictionary<string, int> cue = new Dictionary<string, int>();
            cue.Add(Constants.KEY_SUSPECT, 3);
            cue.Add(Constants.KEY_PLACE, 3);
            cue.Add(Constants.KEY_GUN, 4);

            Assert.AreEqual(t.nextTip(cue), 3);

        }

        [TestMethod]
        public void TesteRetornoSuspeitoELugarErrado()
        {
            Testemunha t = new Testemunha(3, 3, 3);

            Dictionary<string, int> cue = new Dictionary<string, int>();
            cue.Add(Constants.KEY_SUSPECT, 4);
            cue.Add(Constants.KEY_PLACE, 4);
            cue.Add(Constants.KEY_GUN, 3);

            Assert.IsTrue((t.nextTip(cue) == 1) || (t.nextTip(cue) == 2));

        }

        [TestMethod]
        public void TesteRetornoSuspeitoEArmaErrado()
        {
            Testemunha t = new Testemunha(3, 3, 3);

            Dictionary<string, int> cue = new Dictionary<string, int>();
            cue.Add(Constants.KEY_SUSPECT, 4);
            cue.Add(Constants.KEY_PLACE, 3);
            cue.Add(Constants.KEY_GUN, 4);

            Assert.IsTrue((t.nextTip(cue) == 1) || (t.nextTip(cue) == 3));

        }

        [TestMethod]
        public void TesteRetornoLugarEArmaErrado()
        {
            Testemunha t = new Testemunha(3, 3, 3);

            Dictionary<string, int> cue = new Dictionary<string, int>();
            cue.Add(Constants.KEY_SUSPECT, 3);
            cue.Add(Constants.KEY_PLACE, 4);
            cue.Add(Constants.KEY_GUN, 4);

            Assert.IsTrue((t.nextTip(cue) == 3) || (t.nextTip(cue) == 2));

        }

        [TestMethod]
        public void TesteRetornoTodosErrados()
        {
            Testemunha t = new Testemunha(3, 3, 3);

            Dictionary<string, int> cue = new Dictionary<string, int>();
            cue.Add(Constants.KEY_SUSPECT, 4);
            cue.Add(Constants.KEY_PLACE, 4);
            cue.Add(Constants.KEY_GUN, 4);

            Assert.IsTrue((t.nextTip(cue) == 1) || (t.nextTip(cue) == 2) || (t.nextTip(cue) == 3));

        }

        [TestMethod]
        public void TesteRetornoRespostaCorreta()
        {
            Testemunha t = new Testemunha(3, 3, 3);

            Dictionary<string, int> cue = new Dictionary<string, int>();
            cue.Add(Constants.KEY_SUSPECT, 3);
            cue.Add(Constants.KEY_PLACE, 3);
            cue.Add(Constants.KEY_GUN, 3);

            Assert.AreEqual(t.nextTip(cue), 0);

        }


    }
}
