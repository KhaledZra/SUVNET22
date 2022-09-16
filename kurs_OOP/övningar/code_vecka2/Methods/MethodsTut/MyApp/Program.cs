using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hello("world!");

            AddTwoStrings("Hello ", "World");

            Console.WriteLine(AddValues(5, 10));

            AddTax(100);

            AddTax(100, 50);

            Console.WriteLine(ToPercentage(0.25f) + "%");

            Console.WriteLine(CheckIfLegal(21));

            Console.WriteLine(CheckIfLegal(15));
        }
        
        // Input a string that shows it with another bit of text
        static void Hello(string? sInputText)
        {
            Console.WriteLine("Hello " + sInputText);
        }

        // Input two strings that adds and shows it together
        static void AddTwoStrings(string sTextOne, string sTextTwo)
        {
            Console.WriteLine(sTextOne + sTextTwo);
        }

        // Input two integers that shows the sum of the two given values
        static int AddValues(int iLeftValue, int iRightValue)
        {
            return iLeftValue + iRightValue;
        }

        // Input an integer that adds a 25% tax and shows it
        static void AddTax(int iInputValue)
        {
            Console.WriteLine((float)iInputValue * 1.25f);
        }

        // Override of a method, Input integer and procent. Shows result after adding tax
        static void AddTax(int iInputValue, int iTaxProcent)
        {
            float fTaxModifier = ((float)iTaxProcent / 100.0f) + 1;

            Console.WriteLine(fTaxModifier * (float)iInputValue);
        }

        // Input decimal and turns it to a procentage
        static int ToPercentage(float fDecimalProcent)
        {
            fDecimalProcent = fDecimalProcent * 100;
            return (int)fDecimalProcent;
        }

        // Input integer and returns bool, true if over or 18, false if under
        static bool CheckIfLegal(int iAge)
        {
            if (iAge >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}