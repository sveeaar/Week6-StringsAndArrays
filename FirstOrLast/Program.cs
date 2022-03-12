using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt ees- ja perekonnanime;
            //programm kontrollib andmete pikkust;
            //programm kuvab kumb nendest on pikem, kas ees- või perekonnanimi;

            Console.WriteLine("Sisesta eesnimi:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Sisesta perekonnanimi:");
            string lastName = Console.ReadLine();

            int firstNameLength = firstName.Length;
            int lastNameLength = lastName.Length;

            if(firstNameLength > lastNameLength)
            {
                Console.WriteLine("Teie eesnimi on pikem kui perekonnanimi.");
            }
            else if(firstNameLength < lastNameLength)
            {
                Console.WriteLine("Teie perekonnanimi on pikem kui eesnimi.");
            }
            else
            {
                Console.WriteLine("Teie ees- ja perekonnanimi on sama pikad.");
            }
            



        }
    }
}
