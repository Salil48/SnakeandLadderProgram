using SnakeandLadder;

namespace LineComparisonComputation
{
    class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Program");

            //UC1_Start.Game();
            //UC2_DieRolls.Game();
            //UC3_Option.Game();
            //UC4_PlayerPosition.Game();
            //UC5_Position100.Game();
            //UC6_DieRollTimes.Game();
            int Player1 = 0;
            int Player2 = 0;
            while (Player1 < 100 | Player2 < 100)
            {
                Player1 = Players.Play(Player1);
                Player2 = Players.Play(Player2);
            }

            if (Player1 > 100)
            {
                Console.WriteLine("The Player1 has won");
            }
            else
            {
                Console.WriteLine("The player2 has won");
            }
        }
    }
}
