using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Magnitud ");
            int x = int.Parse(Console.ReadLine());
           

            int[,] numbers = new int[x , x];

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    if (i==j)
                    {
                        numbers [i,j] = 1;
                    }
                    
                    else
                    {
                        numbers[i, j] = 2;
                    }
                    Console.Write(numbers[i, j] + " ");

                }
                Console.WriteLine();
            }

            
            Console.ReadLine();

        }
    }
}
