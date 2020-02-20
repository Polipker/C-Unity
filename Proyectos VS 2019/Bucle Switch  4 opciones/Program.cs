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


            int x = 0;
            Console.WriteLine("1.Refrán ");
            Console.WriteLine("2.Chiste ");
            Console.WriteLine("3.Insulto ");
            Console.WriteLine("4.Salir ");
            do
            {
              

                Console.Write("Seleccione opcion 1, 2, 3, o 4 ");
                 x = int.Parse(Console.ReadLine());

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


                    case 4:
                        Console.WriteLine("Adios");
                        break;

                    default:
                        Console.WriteLine("ESA OPCION NO EXISTE CATETO");
                        
                            break;

                }
            }
           
            while ( x !=  4);
            
            Console.ReadLine();
        }
    }
}
