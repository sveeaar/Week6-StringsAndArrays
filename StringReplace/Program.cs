using System;

namespace StringReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm asendab kõik 'o' tähed lauses "Hello World!" tärniga;

            string message = "Hello World!";

            //for(int i = 0; i < message.Length; i++)
            {
               // message[i] = '*'; //sõned on muutumatud
            }

            message = message.Replace('o', '*');
            Console.WriteLine(message);
        }
    }
}
