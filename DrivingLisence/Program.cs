using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingLisence
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünni aastat
            //programm kontroliib kasutaja vanust
            //programm teatab kasutaja, kas ta on piisavalt vana,
            //et juhiluba saada (tingimuseks 18 aastat vana)
             
            Console.WriteLine("Sisesta oma sünniaasta:");

            int YearOfBirth = Convert.ToInt32(Console.ReadLine());

            int Age = 2021 - YearOfBirth;

               
            if (Age >= 18)
            {
                Console.WriteLine("Oled piisavalt vana, et juhiluba saada.");
            }
            else
            {
                Console.WriteLine("Oled liiga noor.");
            }

                





        }
    }
}
