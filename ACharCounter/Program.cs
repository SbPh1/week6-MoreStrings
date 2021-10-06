using System;

namespace ACharCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnimi
            //programm palub kasutajal sisestada perekonnanimi
            //programm kuvab mitu 'a' tähte kasutaja ees- ja perekonnanimes kokku on

            

            Console.WriteLine("Sisestage eesnimi:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Sisestage perekonnanimi");
            string lastName = Console.ReadLine();

            string fullName = $"{firstName}{lastName}".ToLower();

            int counter = 0;
            // 'a'

            for (int i = 0; i < fullName.Length; i++)
            {
                if (fullName[i] == 'a')
                {
                    counter++; //counter = counter + 1
                }
            }
            if (counter == 1)
            {
                Console.WriteLine($"Sinu nimes on {counter} 'a' täht");
            }
            else
            {
                Console.WriteLine($"Sinu nimes on {counter} 'a' tähte");
            }




        }
    }
}
