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
        public void StartGame_0_GetScoreResults()
        {
            for(int rollCount = 0; rollCount <= 20; rollCount++)
            {
                bowlingGame.Roll(0);
            }


            Assert.AreEqual(0, bowlingGame.GetScore());
        }
    }
}