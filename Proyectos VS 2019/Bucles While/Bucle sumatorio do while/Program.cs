using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucle_sumatorio_do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("introduzca un numero de inicio ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("introduzca un numero final ");
            int end = int.Parse(Console.ReadLine());
            int i = start;

            if (start <end)
            {
                while (i <= end)
                {
                    Console.WriteLine("vamos por el " + i);
                    i++;
                }
            }
            else if (start > end)
            {
                Console.WriteLine("vamos por el " + i);
                i--;
            }
            Console.ReadLine();

        }







    }
    }
}
