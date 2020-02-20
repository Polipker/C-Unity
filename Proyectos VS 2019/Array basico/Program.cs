using System;

namespace Array_basico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("¿Cuantos numeros quieres sumar? ");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int[] numbers = new int [num] ;
            
            for (int count = 0; count < num; count++)
            {
                Console.Write("Introduce un numero ");
                int newnum = int.Parse(Console.ReadLine());

                numbers[count] = newnum;
            }

            for (int count = 0; count < numbers.Length; count++)
            {
                sum += numbers[count];
            }
            
            Console.Write("La suma de tus numeros es  " + sum);

            Console.ReadLine();
        }

    }
}
