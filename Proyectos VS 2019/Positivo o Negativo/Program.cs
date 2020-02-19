using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Positivo_o_Negativo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("introduzca un numero ");
            int x = int.Parse(Console.ReadLine());

            if(x > 0)
            {
                Console.Write("Su numero es positivo");
            }
            
            else if(x < 0)
            {
                Console.Write("Su numero es negativo");
            }

            else
            {
                Console.Write("Ha introducido un 0.");
            }

            Console.ReadLine();
        }
    }
}
