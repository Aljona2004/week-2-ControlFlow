using System;

namespace PositiveNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutajal sisestada numbrit -10 kuni 10;
            //programm kontrollib numbrit;
            //kui number on positiivne, konsool kuvab "positve";
            //kui number on negatiivne, konsool kuvab "negative";
            //kui number on 0, siis konsool kuvab "null";

            Console.WriteLine("Sisesta numbrit -10 kuni 10");

            int UserNumber = Convert.ToInt32(Console.ReadLine()); 

            if(UserNumber > 0)
            {
                Console.WriteLine("Positive");
            }
            else if (UserNumber < 0)
            {
                Console.WriteLine("Negative");
            }
            







        }
    }
}
