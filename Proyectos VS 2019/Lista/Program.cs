using System;
using System.Collections.Generic;
namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            Console.Write("introduzca un numero ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("introduzca un numero ");
            int y = int.Parse(Console.ReadLine());

            numbers.Add(x);
            numbers.Add(y);

            foreach (int number in numbers)// por cada variable(var) de ese tipo en la lista (colecction) Lo extrae mediante un valor temporal(item) y realiza  el bucle
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine(number + " Es par ");
                }

                else
                {
                    Console.WriteLine(number + " Es impar ");

                }

            }

            Console.ReadLine();

            
            //numbers.Add(1);//añade valor al final de la lista
            //numbers.Remove(1);// borra el primer valor que valga lo indicado en la lista
            //numbers.RemoveAt(1);// borra la posicion de la lista indicada
            //numbers[1] = 40;// acceso a esa posicion en la lista

            //    List<float> decimals = new List<float>();
            //    List<double> muchdecimals = new List<double>();
            //    List<char> character = new List<char>();
            //    List<string> muchchar = new List<string>();

        }
    }
}