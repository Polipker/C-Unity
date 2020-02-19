using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabla_con_for
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("¿Que tabla quiere? ");
            int Tab = int.Parse(Console.ReadLine());

            Console.Write("Cuantos numeros de la tabla quiere ");
            int Num = int.Parse(Console.ReadLine());

            for (int cont = 0; cont < Num; cont++)
            {
                Console.WriteLine(Tab + "x" + cont + "=" + Tab*cont  );
            }

            Console.ReadLine();

        }
    }
}
