using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucle_sumatorio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca un numero de Inicio ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Introduzca un numero de final ");
            int end = int.Parse(Console.ReadLine());

            for (int i = start ; i <= end; i++)
            {
                Console.WriteLine("Vamos por el " + i);

            }

            Console.ReadLine();
        }
    }
}
