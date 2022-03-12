using System;

namespace DontPanic
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm asendab kõik 'o' tähed lauses "Don't panic!" 0-ga;
            //programm asendab lõik 'a' tähed lauses "Don't panic!" 4-ga;

            string message = "Don't panic!";

            message = message.Replace('o', '0');
            message = message.Replace('a', '4');

            Console.Write(message);



        }
    }
}
