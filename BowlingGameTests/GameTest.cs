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
            RollMany(0);

            Assert.AreEqual(0, bowlingGame.GetScore());
        }

        [Test]
        public void RollGame_20_GetScoreResults()
        {
            RollMany(1);

            Assert.AreEqual(20, bowlingGame.GetScore());
        }

        private void RollMany(int pins)
        {
            for (int rollCount = 0; rollCount < 20; rollCount++)
            {
                bowlingGame.Roll(pins);
            }
        }
    }
}