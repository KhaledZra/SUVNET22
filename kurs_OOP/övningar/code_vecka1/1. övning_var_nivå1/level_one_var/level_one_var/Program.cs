using System;

namespace level_one_var
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Deklarera och tilldela värden till variabler av typen
            int iNumber = 3;
            float fNumber = 3.14f;
            string? sName = "Khaled";
            char cAlphabet = 'K';
            bool bBoolean = true;

            // 2. Skriv ut samtliga värden med Console.WriteLine();
            Console.Clear();
            Console.WriteLine(iNumber);
            Console.WriteLine(fNumber);
            Console.WriteLine(sName);
            Console.WriteLine(cAlphabet);
            Console.WriteLine(bBoolean);

            // 3. Ta in värden till samtliga variabler med Console.ReadLine();
            iNumber = Convert.ToInt32(Console.ReadLine());      // förväntas siffra
            float.TryParse(Console.ReadLine(), out fNumber);  // förväntas siffra med deci eller utan
            sName = Console.ReadLine();                         // Kan vara vad som
            cAlphabet = Convert.ToChar(Console.ReadLine());     // förväntar en input t.ex: a b c ... osv
            bBoolean = Convert.ToBoolean(Console.ReadLine());   // förväntar true/false

            // 4. Skriv ut samtliga värden igen med Console.WriteLine();
            Console.Clear();
            Console.WriteLine(iNumber);
            Console.WriteLine(fNumber);
            Console.WriteLine(sName);
            Console.WriteLine(cAlphabet);
            Console.WriteLine(bBoolean);

            // 5. Lägg ihop två variabler av typen sträng och skriv ut resultatet
            string? sString1 = "Khaled";
            string? sString2 = "Zraiqi";
            Console.WriteLine(sString1+sString2);

            // 6. Lägg ihop en int och en float och skriv ut resultatet
            int iNumber1 = 5;
            float fNumber1 = 5.5f;

            Console.WriteLine(fNumber1 + iNumber1); // Out: 10.5
            Console.WriteLine(iNumber1 + fNumber1); // Out: 10.5

            // 7. Se vad som funkar och inte
            //Console.WriteLine(iNumber1 = fNumber1); // Does not work because u are trying to convert float to int

        }
    }
}