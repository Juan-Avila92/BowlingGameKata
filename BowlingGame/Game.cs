using System;
using System.Collections.Generic;
using System.Text;

namespace BowlingGame
{
    public class Game
    {
        int score = 0;

        public void Roll(int numberOfpins)
        {
            score += numberOfpins;
        }

        public int GetScore()
        {
            return score;
        }

        public bool IsSpare()
        {
            Roll(5);
            Roll(5);

            if(score == 10)
            {
                return true;
            }

            return false;
        }
    }
}
