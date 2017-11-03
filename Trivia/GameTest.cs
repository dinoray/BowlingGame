using System;
using System.IO;
using ApprovalTests;
using ApprovalTests.Reporters;
using NUnit.Framework;

namespace BowlingDino
{
    [TestFixture]
    [UseReporter(typeof(DiffReporter))]
    class GameTest
    {
        [Test]
        public void Strike()
        {
            var game = new Game();

            game.Hit(10);
            
            Assert.Equals(game.getResult(),"Strike");
        }
    }
}
