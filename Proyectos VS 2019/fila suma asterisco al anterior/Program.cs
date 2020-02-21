using System;

namespace fila_suma_asterisco_al_anterior
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce primer numeros ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce segundo numeros ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce tercer numeros ");
            int z = int.Parse(Console.ReadLine());

            int[] numbers = new int[] { x, y, z };
            bool reapeated = false;

            for (int i = 0; i < numbers.Length && !reapeated; i++)
            {
                for (int j = i+1; j < numbers.Length && !reapeated; j++)
                {
                    if (numbers[i]==numbers[j])
                    {
                        Console.WriteLine("Hay un numero repetido ");
                        reapeated = true;
                    }

                     
                }
            }
            if (!reapeated)
            {
                Console.WriteLine("No un numero repetido ");

            }
            Console.ReadLine();
        }
    }
}
