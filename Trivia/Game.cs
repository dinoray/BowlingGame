using System;
using System.Collections.Generic;
using System.Linq;

namespace BowlingDino
{
    public class Game
    {
        private int bottle;
        private int round;
        private string result;
        private string gameState;

        public Game()
        {
            bottle = 10;
            round = 1;
            result = "";
        }

        public void Hit(int hitAmount)
        {
            bottle -= hitAmount;

            if (bottle == 0 && round == 1)
            {
                result = "Strike";
            }
        }

        public string getResult()
        {
            return result;
        }
    }

}
