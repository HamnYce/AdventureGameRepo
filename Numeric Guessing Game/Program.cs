using System;

namespace Numeric_Guessing_Game
{
    class Program
    {
      static void Main()
        {
            Game.Play();
        }
    }

    static class Game
    {

        static int guess;
        static int target;
        static string input = "";
        static Random Rando = new Random();

        public static void Play()
        {
            //+1 so it gives an int 1 to 10 else it gives 0 to 9, since it is overload can also use .Next(1,11) == 1 to <11
            int target = Rando.Next(10) + 1;
            Console.WriteLine("I look deep into my crystal ball and I see a number between 1 and 10.\nCan you guess what it is?");
            input = Console.ReadLine();

            
           if (int.TryParse(input, out guess ))
            {
                    if (guess == target)
                {

                        Console.WriteLine("\'The crystal ball appears to be smiling\'");

                }
                     else
                {
                        Console.WriteLine("\'The crystal ball cracks\'\nIt was " + target + "\nBetter luck next time.");
                }
                     
            }
           else
            {
                Console.WriteLine("Please enter a number.");
                Console.WriteLine("Press enter to Continue...");
                Console.ReadKey();
                Play();
            }
           
            Console.ReadKey();
        }
    }
}
