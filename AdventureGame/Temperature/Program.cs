﻿using System;

namespace Temperature
{
    class Program
    {
        static void Main(string[] args)
        {
            int temperature = 0;
            Console.WriteLine("pleasrue enter temperature :)");

            temperature = Convert.ToInt16(Console.ReadLine());


            if (temperature <= 0)
            {
                Console.WriteLine("Water will freeze; the freezing point of water is 0°C.");
            }
            else if (temperature >= 208)
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
            else
            {
                Console.WriteLine("Water is not cold enough to freeze,");
                Console.WriteLine("nor a good temperature for brewing tea.");
            }

            Console.ReadKey();
        }
    }
}
