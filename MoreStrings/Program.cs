using System;

namespace MoreStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutajal sisestada ees- ja perekonnanimi
            //programm tervitab kasutajat kasutades tema initsiaalse
            //initsiaalid lõppevad punktiga
            //--> Harry Potter --> H. P.
            Console.WriteLine("Sisestage eesnimi:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Sisestage perekonnanimi:");
            string lastName = Console.ReadLine();

            Console.WriteLine($"Tere, {firstName[0]}. {lastName[0]}.");
        }
    }
}
