using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.Write("Introduzca su edad ");
            int age = int.Parse(Console.ReadLine());

            if (age >= 18 && age <=64)
            {
                Console.Write("Es usted mayor de edad ");

            }
            else if(age >= 65 && age <=99)
            {
                Console.Write("Es usted un jubilado ");

            }

            else if (age>=100)
            {
                Console.Write("Es usted un druida");


            }
            else   
            {
                Console.Write("Es usted menor de edad ");

            }





            Console.ReadLine();
        }
    }
}
