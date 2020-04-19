using System;
using System.Globalization;
using System.Collections.Generic;

namespace AdventureGame
{
    public static class Game
    {
        static List<string> Inventory = new List<string>(); 
        static String CharacterName = "John Doe";

        static string[] PartOne = {
    "You start to see a dark silhouette in the distance. as you get closer you see an old man standing next to a cart\n" +
                "it appears to contain junk.\n" +
                "\"Oi\" he says, \"I sense you have something I need\"\n" +
                "you look at him confused\n" +
                "\"would you happen to have a pointy object on you\"" +
                "your expression changes\n" +
                "\"I'll trade with ye from my pile of treasure here\", he says attempting to bargain\n" +
                "you look in his cart, out of the \'treasure\' you see a flashlight and an umbrella\n" +
                "Which do you pick A)The flashlight or B)The umbrella",
    "You pick the Flashlight",
    "You pick the Umbrella",
    "You continue walking down the tunnel",
    "You decide to use the flashlight, a writhes in shock from the sudden brightness and scitters off into the darkness.\n" +
                "you keep walking and you see something shining in the distance, you pick it up." +
                "Acquired coin!",
    "As you walk with your umbrella sheathed you see a critter. You open ",
    "Transition to next part of story "
                        };
        static string[] PartTwo = {
    "Description of story ... and the choice C or D",
    "what happens if C is chosen",
    "what happens if D is chosen",
    "more story c/d",
    "more about what happens if C is chosen",
    "more about what happens if D is chosen",
    "Transition to next part of story "
                        };
        static string[] PartThree = {
    "Description of story ... and the choice E or F",
    "what happens if E is chosen",
    "You have acquired The Key!",
    "more story e/f",
    "more about what happens if E is chosen",
    "more about what happens if F is chosen",
    "Transition to next part of story "
                        };

        public static void NameCharacter()
        {
            //ask player for a name, and save it

            Console.WriteLine("Enter a Name for your Character");
            CharacterName = Console.ReadLine();
            TextInfo ProperCase = new CultureInfo("en-US", false).TextInfo;
            CharacterName = ProperCase.ToTitleCase(CharacterName);
            Console.WriteLine("Great! Your character is now named " + CharacterName);
            Console.WriteLine("your name is " + CharacterName.Length + " Characters");
        }

        public static void StartGame()
        {
            //print out game title and overview
            Console.WriteLine("Welcome to the Cave of Trials, get ready for a dark and gloomy ride with... CHOICES!!");
            NameCharacter();
            Console.WriteLine("~Press Enter to begin story~");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(
            "You wake up with no knowledge of who you are or where you came from. you seem to be inside something but it's too\n" +
            "dark to see. you search inside your pockets and you find a lighter, a pin and some pocket lint. you flick the lighter\n" +
            "on and start moving down a tunnel.");
           
        }

        public static void Choice() {
            for (int scenario = 1; scenario <= 3; scenario++)
            { switch (scenario)
                {
                    case 1:
            //method declarations
            int i = 0;
                String input;
                //0
                Console.WriteLine(PartOne[0]);
                //path a or b
                input = Console.ReadLine();
                //1/2
                do
                {
                    if (input == "a" || input == "A")
                    {
                        Console.WriteLine(PartOne[1]);
                        i++;
                                Inventory.Add("Flashlight");
                            }
                    else if (input == "b" || input == "B")
                    {
                        Console.WriteLine(PartOne[2]);
                        i++;
                    }
                    else
                    {
                        Console.WriteLine("I don't understand");
                        input = Console.ReadLine();
                    }
                } while (i == 0);
                //3
                Console.WriteLine(PartOne[3]);
                //4/5
                if (input == "a" || input == "A")
                {
                    Console.WriteLine(PartOne[4]);
                            
                }
                else if (input == "b" || input == "B")
                {
                    Console.WriteLine(PartOne[5]);
                            Inventory.Add("Umbrella");
                }
                //6
                Console.WriteLine(PartOne[6]);
                        break;
                        
                    case 2:
                     i = 0;
                     
                        //0
                        Console.WriteLine(PartTwo[0]);
                        //path c or d
                        input = Console.ReadLine();
                        //1/2
                        do
                        {
                            if (input == "c" || input == "C")
                            {
                                Console.WriteLine(PartTwo[1]);
                                i++;
                            }
                            else if (input == "d" || input == "D")
                            {
                                Console.WriteLine(PartTwo[2]);
                                i++;
                            }
                            else
                            {
                                Console.WriteLine("I didn't quite get that, try again please");
                                input = Console.ReadLine();
                            }
                        } while (i == 0);
                        //3
                        Console.WriteLine(PartTwo[3]);
                        //4/5
                        if (input == "c" || input == "C")
                        {
                            Console.WriteLine(PartTwo[4]);
                        }
                        else if (input == "d" || input == "D")
                        {
                            Console.WriteLine(PartTwo[5]);
                        }
                        //6
                        Console.WriteLine(PartTwo[6]);
                        break;

                    case 3:
                        i = 0;

                        //0
                        Console.WriteLine(PartThree[0]);
                        //path e or f
                        input = Console.ReadLine();
                        //1/2
                        do
                        {
                            if (input == "e" || input == "E")
                            {
                                Console.WriteLine(PartThree[1]);
                                i++;
                            }
                            else if (input == "f" || input == "F")
                            {
                                Console.WriteLine(PartThree[2]);
                                i++;
                                Inventory.Add("Key");
                            }
                            else
                            {
                                Console.WriteLine("I didn't quite get that, try again please");
                                input = Console.ReadLine();
                            }
                        } while (i == 0);
                        //3
                        Console.WriteLine(PartThree[3]);
                        //4/5
                        if (input == "e" || input == "E")
                        {
                            Console.WriteLine(PartThree[4]);
                        }
                        else if (input == "f" || input == "F")
                        {
                            Console.WriteLine(PartThree[5]);
                           
                        }
                        //6
                        Console.WriteLine(PartThree[6]);
                        break;
            }
        }  
    }

        public static void EndGame()
        {
            //end of gamer story text
            Console.WriteLine("End of story text here.....");
            Console.WriteLine(CharacterName + " These are the items you have acquired on your journey");

            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (string Item in Inventory)
            {
                Console.WriteLine(Item);
            }
            Console.ResetColor();

            if (Inventory.Contains("Key"))
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Congratulations you accomplished the goal! You found the key!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You didn't find the special item, try again next time :)");
                Console.ResetColor();
            }
            Console.WriteLine("Press enter to exit.");
        }
        
    }


}
