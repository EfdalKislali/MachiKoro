using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machi_Koro
{
    class Dice
    {
        public Dice()
        {
        }
        public int Roll1()
        {
            int diceRolled = 1;
            int diceAmount;

            if (diceRolled >= 1)
            {
                Random rnd = new Random();
                diceAmount = rnd.Next(1, 7);
                diceRolled = diceRolled - 1;
                return diceAmount;

            }
            return diceRolled;
        }
    }
}
