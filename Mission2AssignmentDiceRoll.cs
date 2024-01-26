using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2Assignment
{
    using System;

    class DiceRoll
    {
        // import random thing
        private Random random = new Random();1
        // Create the array
        public int[] SimulateRolls(int numRolls)
        {
            int[] results = new int[13];
            // Roll the dice
            for (int i = 0; i < numRolls; i++)
            {
                int die1 = random.Next(1, 7);
                int die2 = random.Next(1, 7);
                int diceTotal = die1 + die2;

                results[diceTotal]++;
            }

            return results;
        }
    }
}

