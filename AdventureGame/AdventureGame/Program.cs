/* licensing
 * by HamnYce, 4/1/2020
 *  
 * This work is a derivative of 
 * "C# Adventure Game" by http://programmingisfun.com, used under CC BY.
 * https://creativecommons.org/licenses/by/4.0/
 */
using System;


namespace AdventureGame
{
  
    


    class Program
    {
        static void Main()
        {
            Console.Title = "Breath.exe";
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
           
            Console.WriteLine(@"   /(,-.     /`-.   )\.---.     /`-.   .-,.-.,-.      .'(  
 ,' _   )  ,' _  \ (   ,-._(  ,' _  \  ) ,, ,. (  ,') \  ) 
(  '-' (  (  '-' (  \  '-,   (  '-' (  \( |(  )/ (  '-' (  
 )  _   )  ) ,_ .'   ) ,-`    )   _  )    ) \     ) .-.  ) 
(  '-' /  (  ' ) \  (  ``-.  (  ,' ) \    \ (    (  ,  ) \ 
 )/._.'    )/   )/   )..-.(   )/    )/     )/     )/    )/ 
                                                           ");

            Console.ResetColor();
            
            Game.StartGame();

            Game.Choice();

            Game.EndGame();

            Console.ReadKey();

        }

       


        

        
    }
}

