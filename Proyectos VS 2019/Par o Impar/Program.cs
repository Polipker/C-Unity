using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Par_o_Impar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Introduzca un numero ");
            //int x = int.Parse(Console.ReadLine());

            //if(x % 2 == 0)
            //{
            //    Console.Write("Su numero es par.");

            //}
            //else
            //{
            //    Console.Write("Su numero es impar.");

            //}
            Console.Write("Introduzca un numero ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Introduzca otro numero ");
            int y = int.Parse(Console.ReadLine());
            
            if (x % y == 0)
            {
                Console.Write(x + " Es multiplo de " + y);

            }
            
            else
            {
                Console.Write(x + " Es NO es multiplo de " + y);
            }
            Console.ReadLine();
        }
    }
}
