using System;

namespace Patron
{
    class Program
    {
        static void Main(string[] args)
        {
            

           Console.Write("introduzca un numero para comenzar ");
           int x = int.Parse(Console.ReadLine());
           int[] numbers = new int[4];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]+1);
               
            }


            Console.ReadLine();
        }
    }
}
