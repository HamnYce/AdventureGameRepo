using System;
using System.Globalization;
using System.Threading;

namespace Game
{
    
    static class Madlib
    {
        static String[] Words = {
            "Creature",
            "Luminous", 
            "Ghastly", 
            "Spectral", 
            "Countryman", 
            "Farrier", 
            "Farmer",
            "Dreadful", 
            "Apparition", 
            "Hound", 
        };
        static String[] Prompts = {
            "noun", 
            "adjective", 
            "adjective", 
            "adjective", 
            "occupation", 
            "occupation", 
            "occupation", 
            "adjective", 
            "noun", 
            "noun" 
        };
        static String Story;
        static String GameTitle;
            
        public static void Run()
        {
            Start();
            GetWords();
            WriteStory();
            End();
        }  

        static void Start()
        {

            //Set window bar title
            Console.Title = "Make a Madlib";

            //write out a header & instructions
            Console.WriteLine("--------");
            Console.WriteLine("Madlib!");
            Console.WriteLine("-------");
          
        }

        static void GetWords()
        {
            //ask player to enter words
            //for loop, initing i as 0; while i is < length of word; increment i
            for (int i = 0; i < Words.Length; i++)
            //asks user for input and it cycles through the propmts from the array, by using the counter as the array element to induce the 'cycle'
            //the same is done for the storing of the user input by placing i as the array counter
            {
                Console.Write("Please enter a/an " + Prompts[i] + " :");
                Words[i] = Console.ReadLine();
            }

            //clear the console window
            Console.Clear();
        }

        static void WriteStory()
        {
            //Concatenate (capitalize the first letter of each word i.e. Title Case) strings to make a title 
            GameTitle = "The " + Words[1] + " " + Words[2] + " " + Words[0];

            //Capitalize the words in our title
            TextInfo TitleCase = new CultureInfo("en-US", false).TextInfo;
            GameTitle = TitleCase.ToTitleCase(GameTitle);

            //Write the title to the console window
            Console.WriteLine(GameTitle);

            //change the title of the application window
            Console.Title = GameTitle;
            

           

            //write out story
                Story = "They all agreed that it was a huge {0}, {1}, {2}, and {3}.\nI have cross-examined these men, one of them a hard-headed {4},\none a {5}, and one a moorland {6}, who all tell the same story\nof this {7} {8}, exactly corresponding to the {9} of the legend.";
            Console.WriteLine(Story, Words[0], Words[1], Words[2], Words[3], Words[4], Words[5], Words[6], Words[7], Words[8], Words[9]);
            
          
        }

        static void End()
        //ASCII Drawing
        {
            String cuteSeal = @"────────────────────▛▀▜▖─▄▛▀▜▖
────────────────────▜▖─▝▀▘──▝▌
─────▄▛▀▀▜▄▄▖────────▜▄─────▐▘
──▗▟▀▘──▄▄──▀▖─────▄▟▀▀────▚▛─
─▐▀────▝█▞───▀▄▄▞▀▀▘─────▒▓▓▌─
─█▝─────────────────────▒▒▓▓▌─
─▐█▄▄▄▄▄▄▛────────────▒▒▒▓▓▞──
──▙▄▒▒▒▒─────────────▒▒▒▓▓▟▘──
───▝▀▜▖▒▒────────▒▒▒▒▒▓▓▓▓▙▄▄▖
──────▜▄▓▓▒▒▒─▒▒▒▒▒▓▓▓▓▓▒▒▒▒▟▘
───────▝▙▓▓▓▓▓▒▓▓▓▓▓▝▙▒▒▒▒▒▄▌─
──────▒▒▝▚▖▓▓▓▓▓▓▓▓▓▓▓▄█▀▀▀▘▒▒
─────▒▒▒▒▒▝▜▄▄▄▄▄▄▄▄▄▞▒▒▒▒▒▒▒▒
──────▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒──
──────────▒▒▒▒▒▒▒▒▒▒▒▒────────
";
            //change backgroundcolor to cyan and the letter colour to magenta
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(cuteSeal);
            Console.ResetColor();



            //keep window open and prompt for exit
            Console.WriteLine("Press Enter to Exit");
            Console.ReadKey();

          
        }

        
    }

    class Program
    {
        static void Main()
        {

            //Method run from class Madlib
            Madlib.Run();

        }
    }
}



