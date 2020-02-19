using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Tabla_Multiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" ¿Que tabla quiere? ");
            int Tabla = int.Parse(Console.ReadLine());

            Console.Write(" ¿Cuantos numeros de la tabla quiere? ");
            int Num = int.Parse(Console.ReadLine());

            int cont = 0;

            while (cont < Num)
            {
               
                Console.WriteLine( Tabla + " por " + cont + " igual a " + Tabla * cont ) ;
                
                cont += 1;

            }
            Console.ReadLine();
        }
    }
}
