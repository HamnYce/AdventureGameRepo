using System;

namespace Temperature
{
    class Program
    {
        static void Main(string[] args)
        {
            int temperature = 0;
            Console.WriteLine("please enter temperature :)");

            //Converting string to integer, from user input (ReadLine)
            temperature = Convert.ToInt16(Console.ReadLine());

            
           
            if (temperature >= 208)
            {
                Console.WriteLine("A good temperature for brewing black tea.");
            }
            else if (temperature >= 180)
            {
                Console.WriteLine("A good temperature for brewing oolong tea.");
            }
            else if (temperature >= 170)
            {
                Console.WriteLine("A good temperature for brewing white and green teas.");
            }
            else  if (temperature <= 0)
            {
                Console.WriteLine("Water will freeze; the freezing point of water is 0°C.");
            }
            else
            {
                Console.WriteLine("Water is not cold enough to freeze,\nnor a good temperature for brewing tea.");
            }

            Console.ReadKey();
        }
    }
}
