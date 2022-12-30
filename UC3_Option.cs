using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeandLadder
{
    public class UC3_Option
    {
        public static void Game()
        {
            int position = 0;
            Random random = new Random();
            int die = random.Next(1, 7);
            int opt = random.Next(3);
            const int NoPlay = 0;
            const int ladder = 1;
            const int snake = 2;
            switch (opt)
            {

                case NoPlay:
                    break;
                case ladder:
                    position = die;
                    break;
                case snake:
                    position = position - die;
                    break;
            }
            Console.WriteLine("die: " + die + " option : " + opt + " position : " + position);



        }
    }
}
