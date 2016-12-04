using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an Option: ");
            Console.WriteLine("1) Print Numbers");
            Console.WriteLine("2) Guessing Game");
            Console.WriteLine("3) Exit");

            string result = Console.ReadLine();
            if (result == "1")
            {
                PrintNumbers();
                return true;
            }
            else if (result == "2")
            {
                GuessingGame();
                return true;
            }
            else if (result == "3")
            {
                //If they choose exit return false so it breaks out of the while true statement
                return false;
            }
            else
            {
                //If they type in something invalid display the menu again
                return true;
            }
        }

        private static void PrintNumbers()
        {
            Console.Clear();
            Console.WriteLine("Print Numbers!");
            Console.Write("Type a number: ");
            int result = int.Parse(Console.ReadLine());
            int counter = 1;
            while (counter <= result)
            {
                Console.Write(counter);
                Console.Write("-");
                counter++;
            }
            Console.ReadLine();
        }

        private static void GuessingGame()
        {
            Console.Clear();
            Console.WriteLine("Guessing Game!");
            Random Rando = new Random();
            int randomNumber = Rando.Next(1, 11);

            //Keep track of how many guesses the user has made
            int guesses = 0;

            //Keep track of whether or not the user was correct
            bool incorrectGuess = true;

            do
            {
                Console.WriteLine("Guess a number between 1 - 10: ");
                string result = Console.ReadLine();
                //Instead of parsing the users response we will convert random number .ToString() below
                //Increment  Guesses
                guesses++;

                if (result == randomNumber.ToString())
                {
                    incorrectGuess = false;
                }
                else
                {   //Will make the user guess again b/c incorrect guess still equals true
                    Console.WriteLine("Wrong!");
                }

            } while (incorrectGuess);
            Console.WriteLine("Correct! It took you {0} guesses.", guesses);

            Console.ReadLine();
        }
    }
}
