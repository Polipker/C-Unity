using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_tres_opciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Refrán ");
            Console.WriteLine("2.Chiste ");
            Console.WriteLine("3.Insulto ");

            Console.Write("Seleccione opcion 1, 2 o 3 ");
            int x = int.Parse(Console.ReadLine());

            switch (x)
            {
                case 1:

                    Console.WriteLine("A quien madruga patada en los cojones");
                    break;

                case 2:

                    Console.WriteLine("Va un caracol y derrapa");
                    break;


                case 3:

                    Console.WriteLine("Vete de aqui, PAYASO!");
                    break;

                default:
                    Console.WriteLine("Te has equivocado tontorron!");
                    break;

            }

            Console.ReadLine();
        }
    }
}
