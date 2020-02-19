using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intervalo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca un edad en cm ");
            int x = int.Parse(Console.ReadLine());

            if (x<135)
            {
                Console.Write("Es usted un Leprecaun ");
          
            }

            else if ( (x >= 135) && (x < 150) )
            {
                Console.Write("Es usted un Enano ");

            }

             else if ( (x >= 150) && (x < 170) )

            {
                Console.Write("Es usted mas normal ");

            }

             else if ( (x >= 150) && (x < 170) )

            {
                Console.Write("Es usted mas normal ");

            }

            Console.ReadLine();

        }
    }
}
