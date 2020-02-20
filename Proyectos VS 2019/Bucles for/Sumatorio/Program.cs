using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sumatorio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("introduzca un numero ");
            int rept = int.Parse(Console.ReadLine());
            int totalsum = 0;
            int counter = rept;

            while (counter >= 0)
            {
                Console.WriteLine(counter);

                counter--;
            }

            //for (totalsum = 0, counter = 1; counter <= rept; counter++)
            //{
            //    totalsum = totalsum + counter;

            //}

            Console.WriteLine(totalsum);

            Console.ReadLine();
        }
    }
}
