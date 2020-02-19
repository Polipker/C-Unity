using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_de_tres_notas
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Introduzca su nota de Matemáticas ");
            float x = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca su nota de Lengua ");
            float y = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca su nota de Biología ");
            float z = float.Parse(Console.ReadLine());

            if (x < 0 || x > 10 || y < 0 || y > 10 || z < 0 || z > 10)
            {
                Console.Write(" Ha introducido un valor incorrecto");
            }

            else
            {
                Console.Write("Su media es de " + (x + y + z) / 3f);

                
            }

            Console.ReadLine();
        }

    }
}
