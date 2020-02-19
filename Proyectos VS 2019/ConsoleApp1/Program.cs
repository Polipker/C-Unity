using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string saludo = ("Que pacha como estamos!");
            Console.WriteLine(saludo);

            bool booleanoverdadero = true;
            bool booleanofalso = false;


       

            int xx = 6;
            float zz = 1.9f;
            double yy = 1.9999999999999999d;

            Console.WriteLine(xx + yy + zz);

            Console.WriteLine(xx+yy+zz);
            Console.WriteLine(booleanofalso);
            Console.WriteLine(booleanoverdadero);
            
            Console.Write("introduzca un numero ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("introduzca otro numero ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("La suma es: " + (x + y));
            Console.WriteLine("La resta es: " + (x - y));
            Console.WriteLine("La division es: " + (x / y));
            Console.WriteLine("La multiplicación es: " + (x * y));
            Console.WriteLine("El resto de  " + x + " y " + y + " es " + (x % y));







            Console.ReadLine();

        }

    }
}
