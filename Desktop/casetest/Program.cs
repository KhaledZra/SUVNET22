// See https://aka.ms/new-console-template for more information

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        bool isActive = true;
        while (isActive)
        {
            Console.Clear();
            // borde vara en tryparse
            Console.WriteLine("1. Switch");
            Console.Write("Input: ");
            Int32.TryParse(Console.ReadLine(), out int input);
            switch (input)
            {
                case 1: SwitchOne(); break;
                // skapa fler switch
                case 9:
                    isActive = false;
                    break;

                case 0:
                    Console.WriteLine("Du skrev inget siffra");
                    break;
                default: SwitchDefault(); break;
            }

            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }
        Console.Clear();
        Console.WriteLine("Saving progress"!);
    }

    static void SwitchOne()
    {
        Console.WriteLine("Switch 1");
    }
    
    static void SwitchDefault()
    {
        Console.WriteLine("Dumbass");
    }
}
