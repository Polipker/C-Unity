using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucle_While_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("introduzca un numero para cuenta atras ");
            
            
           int x = int.Parse(Console.ReadLine());

           
           do
            {
                x -- ;
                Console.WriteLine( x );

            }
            while (x > 0) ;
                Console.ReadLine();

        }
    }
}
