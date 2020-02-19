using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notas_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("introduzca su nota ");
            int notas = int.Parse(Console.ReadLine());

            switch (notas)
              {
               case 0:
               case 1:
               case 2:
               case 3:
               case 4:
                Console.Write("Tienes un suspenso");

                    break;
                case 5:
                    Console.Write("Tienes un aprobado");
                    break;
                case 6:
                    Console.Write("Tienes un bien");
                    break;
                case 7:
                    Console.Write("Tienes un notable");
                    break;
                case 8:
                    Console.Write("Tienes un notable");
                    break;
                case 9:
                    Console.Write("Tienes un sobresaliente");
                    break;
                case 10:
                    Console.Write("Tienes un sobresaliente");
                    break;
                default:
                    Console.Write("Normal que hayas suspenido");
                    break;

            }
            Console.ReadLine();
        }
    }
}
