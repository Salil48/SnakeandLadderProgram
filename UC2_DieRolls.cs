using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeandLadder
{
    public class UC2_DieRolls
    {
        public static void Game()
        {
            int startPosition = 0;
            Console.WriteLine("Snake and Ladder game played with single player at start position : " + startPosition);

            Random random = new Random();
            int die = random.Next(1, 7);
            Console.WriteLine("The Player rolls the die to get a number between 1 to 6 is : " + die);

        }
    }
}
