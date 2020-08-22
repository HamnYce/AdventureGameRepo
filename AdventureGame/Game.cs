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
    "The beast morphs back into a balloon on the floor. you think to yourself what a wild scenario that was.\nYou continue walking to see what more lies ahead.\nThis time with a companion as hollow as you!"
                        };
        static string[] PartThree = {
    "You keep walking through the darkness. You approach a new area. This time a circular dome like cavern.\nYou look around and see lamps on the wall, illuminating the area with an orange hue. The same colour as the flames inside them.\nYou can feel the flame radiant light penetrate your skin and the warmth that it creates. Wow you think.\nYou continue walking through to see what's on the other side you cross the middle and the ground starts splitting up, the whole cave is rumbling!\nYou see a ray of light shine from the top of the dome. You look around to make your move.\nWill you E)Go up towards the light? F)Go down towards the darkness?",
    "You've chosen to see what lies beyond the darkness of this cavern.\nYou jump on the opposing platform, rising to the top towards the light! You wonder what you will see beyond the confines of this cave system.",
    "You stay where you, even taking a step back towards the descending platform. You look around to the crumblin, and think to yourself, \"what might lie deeper within these walls.\"\nYou feel this weird sensation in your body like a knot in your chest, fear but also this other feeling...\nExhilaration!",
    "As your transitioning to the nexxt part of your adventure, or perhaps your end. You think back to the events that occured not to long ago. \"what's happening, is this all a dream or is this real life?\"\n maybe your answers lie beyond or maybe more confusion awaits.\nYou have no way of knowing, but you don't need to know.\nAll that matters is what happens in the moment and how you respond to it.\nYou here a thunk! That platform seems to have stopped, you've arrived. You take a step off and look around.",
    "It's grass! and... animals! you think to yourself, \"I think I've made it out!\"You start walking towards a tree to rest - haven't gotten much of that recently - with each step you hear the crunching of the grass and the rustling of the leaves caused by the wind.\n\"AAh Fresh Air\", You exclaim with an outbreathe as you drop down and lay your back on the tree.\nLooking up to see the suns rays passing through the trea leaves.\n You rest your head and before you know it, pass out...",
    "This is still the cave but something seems different. Something feels different...\nYou get off the platform and walk into the surrounding darkness, this time the air seems to be covered in a red tint.\nYou continue walking, you go through a tunnel, then a hallway, then into a large square room lit by blue flames. The world turns purple.\nYou look up and feel your body's hairs all stand up and shiver down your spine.\nThree creeatures, humanoid in shape but definetly not human. They begin to chant and the sheer volume was enough to put you on your knees.\nThey appear to be giving you something but what could it be.\nYou feel a surge of power in your body and a new voice inside of you awakens...\nThis is too much. You pass out.",
    ""
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
                                Inventory.Add("Umbrella");
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
                                Inventory.Add("Blue dog balloon");
                            }
                            else if (input == "d" || input == "D")
                            {
                                Console.WriteLine(PartTwo[2]);
                                i++;
                                Inventory.Add("Red cat balloon");
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
                        Console.WriteLine("Press enter to continue");
                        Console.ReadKey();
                        Console.Clear();
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
                        Console.WriteLine("Press enter to continue");
                        Console.ReadKey();
                        Console.Clear();
                        break;
            }
        }  
    }

        public static void EndGame()
        {
            //end of gamer story text
            Console.WriteLine("You've reached the end of one journey, and the beggining of another!");
            Console.WriteLine("" +
               
" _______  __   __  _______  __    _  ___   _    __   __  _______  __   __     ___             ___\n" +   
"|       ||  | |  ||   _   ||  |  | ||   | | |  |  | |  ||       ||  | |  |   |   |           |   |  \n" +
"|_     _||  |_|  ||  |_|  ||   |_| ||   |_| |  |  |_|  ||   _   ||  | |  |  |  _  |         |  _  | \n" +
"  |   |  |       ||       ||       ||      _|  |       ||  | |  ||  |_|  |  |_| |_|         |_| |_| \n" +
"  |   |  |       ||       ||  _    ||     |_   |_     _||  |_|  ||       |                          \n" +
"  |   |  |   _   ||   _   || | |   ||    _  |    |   |  |       ||       |           _____          \n" +
"  |___|  |__| |__||__| |__||_|  |__||___| |_|    |___|  |_______||_______|          |_____|         \n");
            Console.WriteLine(CharacterName + " These are the items you have acquired on your journey:");

            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (string Item in Inventory)
            {
                Console.WriteLine(Item);
            }
            Console.ResetColor();

            Console.WriteLine("I hope you had fun " + CharacterName + " ^^");

            Console.WriteLine("Please press enter to exit.");


        }
        
    }


}
