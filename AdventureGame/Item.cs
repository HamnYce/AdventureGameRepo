using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureGame
{
    public class Item
    {
        //default is a stone
        public string Name = "Small stone";
        public string Description = "Unimpressive object.";

        string[] Items = { "shoe", "can", "pair of chopsticks" };
        string[] Descriptions = { "Size 10 sneaker", "Empty root beer can", "Pink plastic chopsticks" };

        public Item()
        {
            Random randomNumber = new Random();
            int number;

            //Next(Int32) returns a non-negative random number less than the maximum
            number = randomNumber.Next(Items.Length);

            Name = Items[number];
            Description = Descriptions[number];
            Console.WriteLine("\nYou have found a " + Name + " (" + Description + ") \n");
        }
        
       
        
      
    }
}

