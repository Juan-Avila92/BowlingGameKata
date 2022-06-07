using BowlingGame;
using NUnit.Framework;

namespace BowlingGameTests
{
    public class GameTest
    {
        Game bowlingGame;

        [SetUp]
        public void Setup()
        {
            bowlingGame = new Game();
        }

        [Test]
        public void RollGame_0_GetScoreResults()
        {
            for(int rollCount = 0; rollCount <= 20; rollCount++)
            {
                bowlingGame.Roll(0);
            }


            Assert.AreEqual(0, bowlingGame.GetScore());
        }

        [Test]
        public void RollGame_20_GetScoreResults()
        {
            for (int rollCount = 0; rollCount < 20; rollCount++)
            {
                bowlingGame.Roll(1);
            }


            Assert.AreEqual(20, bowlingGame.GetScore());
        }
    }
}