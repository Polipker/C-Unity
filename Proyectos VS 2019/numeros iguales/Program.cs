using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numeros_iguales
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("introduzca el primer numero ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("introduzca el segundo numero ");
            int num2 = int.Parse(Console.ReadLine());

            if(num1 == num2)
            {
                Console.Write("Enhorabuena sus numeros sus igules");
            }
            else if(num1 > num2)
            {
                Console.Write( "Sus numeros no son iguales y ademas " + num1 + " es mayor que " + num2 );

            }

            else 
            {
                Console.Write( "Sus numeros no son iguales y ademas " + num2 + " es mayor que " + num1);

            }
            Console.ReadLine();



        }
    }
}
