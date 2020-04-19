using System;

namespace ReturnValue
{
    class Character
    {
        static int luck = 5;
        static Random randomNumber = new Random();
        public static int points = 0;

        public static bool Luck()
        {
            
            int karma = randomNumber.Next(10);
            bool result = false;

            if (luck >= karma)
            { result = true; }  

            return result;
        }
    }
    class Program
    {
        static void Main()
        {
            Console.Title = "Return Value Example";
            Console.WriteLine("Your points: " + Character.points);
            for (int i = 0; i < 20; i++)
            {

                if (Character.Luck())
                {
                    Console.WriteLine("Your luck has gained you another point!");
                    Character.points++;
                }
                else
                {
                    Console.WriteLine("Your luck has failed.... you've lost a point.");
                    Character.points--;
                }
            }

            Console.WriteLine("Your points: " + Character.points);
            Console.Read();
        }
    }
}