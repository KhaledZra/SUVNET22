using System;

namespace FizzBuzz // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? sPlayerOne = String.Empty;
            string? sPlayerTwo = String.Empty;
            int iTurn = 1;
            string? sSay = string.Empty;

            Console.WriteLine("Welcome to FizzBuzz!");
            Console.WriteLine("When ready pick between your self's who will be player 1 and player 2");
            Console.Write("Press any key to continue!");
            Console.ReadKey();

            Console.Clear();
            Console.Write("Enter name for player one: ");
            sPlayerOne = Console.ReadLine();
            Console.Write("Enter name for player two: ");
            sPlayerTwo = Console.ReadLine();


            // Starting Game loop
            for (int i = 1; i <= 100; i++)
            {
                sSay = string.Empty;
                if (iTurn == 1)
                {
                    if ((i % 3) == 0)
                        sSay += "Fizz";

                    if ((i % 5) == 0)
                        sSay += "Buzz";

                    if ((i % 6) == 0)
                        sSay += "Fuzz";

                    if ((i % 7) == 0)
                        sSay += "Bizz";

                    if (sSay.Length == 0)
                        sSay = i.ToString();

                    Console.WriteLine($"{sPlayerOne} says: {sSay}");
                    iTurn = 2;
                }
                else
                {
                    if ((i % 3) == 0)
                        sSay += "Fizz";

                    if ((i % 5) == 0)
                        sSay += "Buzz";

                    if ((i % 6) == 0)
                        sSay += "Fuzz";

                    if ((i % 7) == 0)
                        sSay += "Bizz";

                    if (sSay.Length == 0)
                        sSay = i.ToString();

                    Console.WriteLine($"{sPlayerTwo} says: {sSay}");
                    iTurn = 1;
                }
            }
        }
    }
}