using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors_DEMO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock - Paper - Scissors 2019 Edition");
            Console.WriteLine("");
            Console.WriteLine("Enter your choice R (rock), P (paper), or S (scissors)");
            PlayGame();
        }

        private static void PlayGame()
        {
            string[] options = new string[] { "R", "P", "S" };
            Random randomChoice = new Random();
            int computerChoice = randomChoice.Next(0, 2);

            string userInput = Console.ReadLine().ToUpper();
            string computerInput = options[computerChoice];

            if (userInput != "R" && userInput != "P" && userInput != "S")
                Console.WriteLine("Incorrect input, please enter a letter: R (rock), P (paper), or S (scissors)");
            else
                GetResult(userInput, computerInput);

            PlayGame();
        }

        private static void GetResult(string userInput, string computerInput)
        {
            string compMessage = "Computer played " + computerInput + "! ";
            string userWon = compMessage + "Congratulations you won!";
            string userLost = compMessage + "You lost! try again...";
            string userDraw = compMessage + "Nobody won, try again! ";


            if (userInput == "R" && computerInput == "R")
                Console.WriteLine(userDraw);
            else if (userInput == "R" && computerInput == "P")
                Console.WriteLine(userLost);
            else if (userInput == "R" && computerInput == "S")
                Console.WriteLine(userWon);

            else if (userInput == "P" && computerInput == "R")
                Console.WriteLine(userWon);
            else if (userInput == "P" && computerInput == "P")
                Console.WriteLine(userDraw);
            else if (userInput == "P" && computerInput == "S")
                Console.WriteLine(userLost);

            else if (userInput == "S" && computerInput == "R")
                Console.WriteLine(userLost);
            else if (userInput == "S" && computerInput == "P")
                Console.WriteLine(userWon);
            else if (userInput == "S" && computerInput == "S")
                Console.WriteLine(userDraw);
            else
                Console.WriteLine(userDraw);

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Let's play again, enter your choice R (rock), P (paper), or S (scissors)");
        }
    }
}
