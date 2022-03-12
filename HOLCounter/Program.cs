using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab konsoolis mitu 'h', 'o' ja 'l' tähte on lauses "Hello World!";

            string message = "Hello World!".ToLower();

            int aCounter = 0;

            for (int i = 0; i < message.Length; i++) 
            {
                if (message[i] == 'h')
                {
                    aCounter++;
                    Console.WriteLine($"Lauses {message} on {aCounter} 'h' täht(e).");
                }
                else if (message[i] == 'o')
                {
                    aCounter++;
                    Console.WriteLine($"Lauses {message} on {aCounter} 'o' täht(e).");
                }
                else if (message[i] == 'l')
                {
                    aCounter++;
                    Console.WriteLine($"Lauses {message} on {aCounter} 'l' täht(e).");
                }
                             
            }
            Console.WriteLine($"Lauses {message} on kokku {aCounter} 'h', 'o' ja 'l' tähte.");

















        }
    }
}
