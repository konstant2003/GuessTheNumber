using ProgrammingFundamentalsClassLibrary;
using System;
using System.ComponentModel.DataAnnotations;

namespace GuessTheNumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Login();

            while (true)
            {
                var rand = new Random();
                int number = rand.Next(1, 100);
                Console.WriteLine("Try to guess a number from 1 to 100");
                int guessNum = 0;

                while (guessNum != number)
                {
                    string input = Console.ReadLine();
                    if (!int.TryParse(input, out guessNum))
                    {
                        Console.WriteLine("Invalid Number, try again!");
                        continue;
                    }
                    if (guessNum != number)
                    { 
                        if (guessNum > number) { PrintColorMessege(ConsoleColor.Red, "The number is smaller.Try again!"); }
                        else { PrintColorMessege(ConsoleColor.Red, "The number is bigger.Try again!"); }  
                    }
                    
                }
                PrintColorMessege(ConsoleColor.Green, "You Win!");

                Console.WriteLine("Do you want to play again? (Y , N)");
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                { continue; }
                else { break; }
            }

        }
        static void Login()
        {
            Console.WriteLine("What's your name?");
            string inputname = Console.ReadLine();
            Console.WriteLine($"Hello  {inputname}");
        }
        static void PrintColorMessege(ConsoleColor color, string messege)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(messege);
            Console.ResetColor();
        }
        
    }
}
