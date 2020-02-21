using System;

namespace numero_mas_grande_y_mas_pequeño
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cuantos numeros quiere introducir? ");
            int x = int.Parse(Console.ReadLine());
            int counter = 0;
            int highest = int.MinValue;//numero mas pequeño posbile en memoria
            int lowest = int.MaxValue;//numero mas grande posible en memoria

            int[] numbers = new int[x];
            while (counter<x)
            {
                Console.Write("introduzca un numero ");
                int y = int.Parse(Console.ReadLine());
                numbers[counter] = y;
                counter++;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]>highest)
                {
                    highest = numbers[+i];

                }

                if (numbers[i] < lowest)
                {
                    lowest = numbers[i];
                }
            }

            Console.Write("El mas alto es " + highest + " y el mas bajo es " + lowest );

            Console.ReadLine();
        }
    }
}
