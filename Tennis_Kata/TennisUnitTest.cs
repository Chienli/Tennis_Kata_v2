﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tennis_Kata
{
    [TestClass]
    public class TennisUnitTest
    {
        private readonly TennisGame _tennisGame = new TennisGame();

        [TestMethod]
        public void Love_All()
        {
            ScoreShouldBe("Love_All");
        }

        private void ScoreShouldBe(string expected)
        {
            var score = _tennisGame.Score();
            Assert.AreEqual(expected , score);
        }
    }

    internal class TennisGame
    {
        public string Score()
        {
            return "Love_All";
        }
    }
}
