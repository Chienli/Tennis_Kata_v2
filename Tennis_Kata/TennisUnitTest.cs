﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tennis_Kata
{
    [TestClass]
    public class TennisUnitTest
    {
        private readonly TennisGame _tennisGame = new TennisGame("Guy", "Jay");

        [TestMethod]
        public void Love_All()
        {
            ScoreShouldBe("Love_All");
        }

        [TestMethod]
        public void Fifteen_All()
        {
            FirstPlayerGetPointTimes(1);
            SecondPlayerGetPointTimes(1);

            ScoreShouldBe("Fifteen_All");
        }

        [TestMethod]
        public void Thirty_All()
        {
            FirstPlayerGetPointTimes(2);
            SecondPlayerGetPointTimes(2);

            ScoreShouldBe("Thirty_All");
        }

        [TestMethod]
        public void Deuce()
        {
            FirstPlayerGetPointTimes(3);
            SecondPlayerGetPointTimes(3);

            ScoreShouldBe("Deuce");
        }

        [TestMethod]
        public void FirstPlayer_Adv()
        {
            FirstPlayerGetPointTimes(4);
            SecondPlayerGetPointTimes(3);

            ScoreShouldBe("Guy_Adv");
        }

        [TestMethod]
        public void SecondPlayer_Adv()
        {
            FirstPlayerGetPointTimes(3);
            SecondPlayerGetPointTimes(4);

            ScoreShouldBe("Jay_Adv");
        }

        [TestMethod]
        public void FirstPlayer_Win()
        {
            FirstPlayerGetPointTimes(5);
            SecondPlayerGetPointTimes(3);

            ScoreShouldBe("Guy_Win");
        }

        [TestMethod]
        public void SecondPlayer_Win()
        {
            FirstPlayerGetPointTimes(3);
            SecondPlayerGetPointTimes(5);

            ScoreShouldBe("Jay_Win");
        }

        [TestMethod]
        public void Fifteen_Love()
        {
            FirstPlayerGetPointTimes(1);

            ScoreShouldBe("Fifteen_Love");
        }

        [TestMethod]
        public void Thirty_Love()
        {
            FirstPlayerGetPointTimes(2);

            ScoreShouldBe("Thirty_Love");
        }

        [TestMethod]
        public void Forty_Love()
        {
            FirstPlayerGetPointTimes(3);

            ScoreShouldBe("Forty_Love");
        }

        [TestMethod]
        public void Love_Fifteen()
        {
            SecondPlayerGetPointTimes(1);

            ScoreShouldBe("Love_Fifteen");
        }

        [TestMethod]
        public void Love_Thirty()
        {
            SecondPlayerGetPointTimes(2);

            ScoreShouldBe("Love_Thirty");
        }

        [TestMethod]
        public void Love_Forty()
        {
            SecondPlayerGetPointTimes(3);

            ScoreShouldBe("Love_Forty");
        }

        private void SecondPlayerGetPointTimes(int times)
        {
            for (var i = 0; i < times; i++)
            {
                _tennisGame.SecondPlayerGetPoint();
            }
        }

        private void FirstPlayerGetPointTimes(int times)
        {
            for (var i = 0; i < times; i++)
            {
                _tennisGame.FirstPlayerGetPoint();
            }
        }

        private void ScoreShouldBe(string expected)
        {
            var score = _tennisGame.Score();
            Assert.AreEqual(expected, score);
        }
    }
}