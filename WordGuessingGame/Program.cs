using System;
//game/program where you pick the correct word
namespace WordGuessingGame
{
    class Program
    {
        static void Main()
        {
            Game theGame = new Game();
            theGame.Play();

            Console.ReadKey();
        }
    }

    class Game
    {
        int target;
        string[] words = { "hat", "cat", "rat" };
        Random Rando = new Random();

        public void Play()
        {
            //picking a random index from the array using the array length
            target = Rando.Next(words.Length);

            Console.WriteLine("I see three words in my crystal ball.\nCan you guess which is the real one?");

            //for loop, initializing i as the counter; keeping the loop going for the length of array - 1; incrementation of loop
             for (int i = 0; i < words.Length; i++)
            {
            //'loop' output to console window all words except last 
                if (i == (words.Length - 1))
                    Console.Write("or " + words[i] + "? ");
                else
            //outputs the last word of the words array
                    Console.Write(words[i] + ", ");
            }
            //initializing input as string & storing user input into the variable
            string input = Console.ReadLine();
            //lowering the case of the string input 
            input = input.ToLower();

            //if user input is the same as the target word output 'correct'
            if (input == words[target])
            {
                Console.WriteLine("Congratulations! You guessed it!");
            }
            else
            {
                
                Console.WriteLine("not a match. Try again!");
                Console.WriteLine("Press enter to continue...");
                Console.ReadKey();
                Play();
            }
        }

    }
}