using System;

namespace myApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? sAnswer = string.Empty;
            // Kontrollera värdet (del 1)
            Console.WriteLine("Är det fint väder?");
            sAnswer = Console.ReadLine().ToLower(); // Extra lösning

            if (sAnswer == "j")
            {
                Console.WriteLine("Vi går på picknick!");
            }
            else if (sAnswer == "n") // (del 2)
            {
                Console.WriteLine("Vi stannar inne och läser en bok");
            }
            else // (del 3)
            {
                Console.WriteLine("Jag förstår inte!");
            }

            // (del 4)
            Console.WriteLine("Betygprogram");
            int iSum = 0;

            Console.WriteLine("input:");
            string? sInput = Console.ReadLine();

            string[] sInputs = sInput.Split(" ");
            for (int i = 0; i < sInputs.Length; i++)
            {
                iSum += Convert.ToInt32(sInputs[i]);
            }

            float fSum = (float)iSum / (float)sInputs.Length;

            Console.WriteLine("Output: ");
            Console.WriteLine("Genomsnitt: " + fSum + "%");

            switch ((int)fSum)
            {
                case int n when (n == 100):
                    Console.WriteLine("Betyg: A");
                    break;
                case int n when (n <= 99 && n >= 90):
                    Console.WriteLine("Betyg: B");
                    break;
                case int n when (n <= 89 && n >= 80):
                    Console.WriteLine("Betyg: C");
                    break;
                case int n when (n <= 79 && n >= 70):
                    Console.WriteLine("Betyg: D");
                    break;
                case int n when (n <= 69 && n >= 51):
                    Console.WriteLine("Betyg: E");
                    break;
                case int n when (n <= 50):
                    Console.WriteLine("Betyg: F");
                    break;
            }
        }
    }
}