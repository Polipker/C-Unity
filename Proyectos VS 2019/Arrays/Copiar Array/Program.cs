using System;

namespace Copiar_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("¿Cuantos numeros quieres guardar en el primer array? ");
            int numarray = int.Parse(Console.ReadLine());
            
           int[] numbers = new int[numarray];
           int[] numbers2 = new int[numbers.Length];


            for (int count = 0; count < numarray; count++)
            {
                Console.Write("Introduce un numero ");
                int newnum = int.Parse(Console.ReadLine());

                numbers[count] = newnum;
            }

            

            for (int count = 0; count < numbers2.Length; count++)
            {
                

               numbers2[count] = numbers[count];
            }


            Console.WriteLine("Tus numeros son ");

            for (int count = 0; count < numbers2.Length; count++)
            {
                int x = numbers2[count];

                Console.WriteLine(x);

            }


            Console.ReadLine();
        }
    }
}
