using System;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm ennustab, mis juhtub kasutajaga homme (Random klass);

            string[] prediction = { "win a million", "fall in love", "buy youtube premium", "join the darkside for cookies" };

            //Console.WriteLine("Enter a number 0-3:");
            //int userNumber = Convert.ToInt32(Console.ReadLine());

            Random rnd = new Random();
            int userNumber = rnd.Next(0, prediction.Length);

            Console.WriteLine($"Tomorrow you will {prediction[userNumber]}.");

        }
    }
}
