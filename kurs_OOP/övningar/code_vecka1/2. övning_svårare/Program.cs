using System;

namespace Cmd_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Övning: Svårare
            // 1. Be användaren skriva in en mening.
            System.Console.Write("Skriv in en mening: ");
            string sentence = Console.ReadLine();
            for(int i = 0; i < sentence.Length; i++)
            {
                // 2. Skriv ut varje teckens int-värde (varje char)
                if((Convert.ToInt32(sentence[i]) == 32))
                {
                    System.Console.WriteLine();
                }
                else
                {
                    if(sentence.Length-1 == i)
                    {
                    System.Console.Write(Convert.ToInt32(sentence[i]));
                    }
                    else
                    {
                    System.Console.Write(Convert.ToInt32(sentence[i]) + ", ");
                    }
                }
            }

            System.Console.WriteLine();

            for(int i = 0; i < sentence.Length; i++)
            {
                // 3. Skriv ut varje teckens binära värde separerade med 
                // mellanslag (skriv alltså inte ut mellanslag som binära värden)
                if((Convert.ToInt32(sentence[i]) == 32))
                {
                    System.Console.WriteLine();
                }
                else
                {
                    if(sentence.Length-1 == i)
                    {
                        System.Console.WriteLine(Convert.ToString(sentence[i], 2));                    
                    }
                    else
                    {
                        System.Console.Write(Convert.ToString(sentence[i], 2) + ", ");                    
                    }
                }
            }

            //4. Skapa en caesar-kryptering:
            //  a. Låt användaren skriva in en mening som innan
            System.Console.Write("Skriv in en ny mening: ");
            string sentence2 = Console.ReadLine();
            //  b. Låt användaren skriva in ett heltal
            System.Console.Write("Skriv in ett heltal: ");
            int skiftaMed = Convert.ToInt32(Console.ReadLine());
            //  c. Använd heltalet för att “skifta” varje teckens int-värde (lägg
            //      på heltalet till varje chars-värde i meningen)
            string decryptedSentence = "";
            for(int i = 0; i < sentence2.Length; i++)
            {
                int tempVar = Convert.ToInt32(sentence2[i]) + skiftaMed;
                decryptedSentence = decryptedSentence + Convert.ToChar(tempVar);
            }

            //  d. Skriv ut meningen på nytt, nu i sin “krypterade” form
            System.Console.WriteLine("Efter kryptering: " + decryptedSentence);
        }
    }
}