﻿using System.Collections.Generic;

namespace Tennis_Kata
{
    internal class TennisGame
    {
        private int _firstPlayerScore;
        private int _secondPlayerScore;

        private Dictionary<int, string> _scoreLookUp = new Dictionary<int, string>
        {
            {0,"Love" },
            {1,"Fifteen"},
            {2,"Thirty"},
            {3,"Forty"}
        };

        public string Score()
        {
            if (_firstPlayerScore != _secondPlayerScore)
            {
                return $"{_scoreLookUp[_firstPlayerScore]}_{_scoreLookUp[_secondPlayerScore]}";
            }
            else
            {
                return $"{_scoreLookUp[_firstPlayerScore]}_All";
            }
        }

        public void FirstPlayerGetPoint()
        {
            _firstPlayerScore++;
        }

        public void SecondPlayerGetPoint()
        {
            _secondPlayerScore++;
        }
    }
}