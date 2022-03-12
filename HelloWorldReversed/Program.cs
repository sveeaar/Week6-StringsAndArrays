using System;

namespace HelloWorldReversed
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Hello World!".ToLower();

            for(int i = message.Length -1; i >= 0; i--)
            {
                Console.Write(message[i]);
            }

        }
    }
}
