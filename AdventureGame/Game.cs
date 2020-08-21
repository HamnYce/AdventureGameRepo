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
    "You start to see a dark silhouette in the distance. as you get closer you see an old man standing next to a cart\nit appears to contain junk.\n\"Oi\" he says, \"I sense you have something I need\"\nyou look at him confused\n\"would you happen to have a pointy object on you\"your expression changes\n\"I'll trade with ye from my pile of treasure here\", he says attempting to bargain\nyou look in his cart, out of the \'treasure\' you see a flashlight and an umbrella\nWhich do you pick A)The flashlight or B)The umbrella",
    "You pick the Flashlight",
    "You pick the Umbrella",
    "You continue walking down the tunnel",
    "You decide to use the flashlight to see better in this dusty old gray cave, a snake writhes in shock from the sudden brightness and slithers off into the darkness.\nslightly flabbergasted, you keep walking and you see something shining in the distance, you pick it up.\nAcquired coin!",
    "As you walk with your umbrella you see a critter.\nYou open it in shock, ready for the critter to jump over it and crawl around your body, but in your hastiness it flew away from the umbrellas explosive force!\nGoodjob, you avoided a nasty insect! I hope...",
    "You shudder from what just happened and decided it's best to keep walking and not get held up for too long in one place. You never know what else might pop up after that.\n You look ahead and see a shadow you walked towards it..."
                        };
        static string[] PartTwo = {
    "You enter another area. There is a lamp with an odd looking little girl, staring at you.\nIn her hand you see two blown up balloons\n\"Hey you, you wanna buy a balloon off of me? It'll be worth your coin I promise\", she says with a growing grin on her face\nyou see her teeth are as sharp as nails with an uncanny reddish brown tint to them...\nshe's aware that you noticed her teeth as you see her grin grow ever bigger with her round hazel eyes and pink ponytails\nYou decide that you want a balloon, you look at her hands and see a blue dog balloon in the one hand and a red cat balloon in the other which will it be?\nMake a choice. C)The dog balloon D)The cat balloon",
    "You take the blue dog balloon then realise you don't have any money, the girls smile turns to a frown. she looks down at the floor and her face becomes dark.\n" +
                "\"Okay mister you can have the balloon for free\"\n, she mumbles with almast a tinge of anger",
    "you take the red cat balloon. You check in your back pocket but realise you woke up here with nothing but a lighter... you offer it to the girl\n" +
                "\"Okay mister you can have the balloon for free\"\n, she mumbles with an almost resentful tone. She looks down at the floor",
    "Then you see a tear go down her face and she disappears with a blip of light and a gust of wind.\nWow you think to yourself, there're all kinds of beings in this world!" +
                "you continue walking through the tunnels with your new found friend (don't forget to give them a name ^^).\n" +
                "as you enter a new area you feel the balloon vibrating and at the same time you here a rustling sound in front of you...\n" +
                "it's getting closer!",
    "The squeeky blue balloon begins vibrating so hard you let go of it. As it's falling to the floor it begins to morph into wolf with a coat of gold, with paws that have nails made ofsilver and a cheeky wide smile\n\"I see you've summoned me master\", he says with confidence, almost cocky\nHe's looking forward yet I hear his voice clearly in my head.. wait! his VOICE?!?\nA snake pops out to bite you but before it has a chance to get to you the wolf bites it and swallows it whole!",
    "The squeeky red balloon begins shaking so hard you let go of it. As it's floating to the floor it begins to morph into tiger with a coat of jade, with paws that have nails made of diamond and an elegant look in it's eye \n\"I see you've summoned me\", she says with grace, almost divine\nSHe's looking forward yet I hear her voice clearly in my head.. wait! her VOICE?!?\nA snake pops out to bite you but before it has a chance to get to you the tiger bites it's neck and let's it drop to the floor. Bleh!",
    "The beast morphs back into a balloon on the floor. you think to yourself what a wild scenario that was.\nYou continue walking to see what more lies ahead.\nThis time, with a companion!"
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
                        Console.WriteLine("Press enter to continue");
                        Console.ReadKey();
                        Console.Clear();
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
