using System;

namespace Cambiar_variable
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = 4;
            int aux = x;
            x = y;
            y = aux;
           
            Console.WriteLine(x);
            Console.WriteLine(y);

            Console.ReadLine();





        }
    }
}
