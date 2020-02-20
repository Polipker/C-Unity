using System;

namespace suma_de_10_numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("¿Cuantos numeros quiere introducir? ");
            int total = int.Parse(Console.ReadLine());
            
            int sum = 0;
           
            for (int counter = 0; counter < total; counter++)
            {
                Console.Write("Introduzca numero ");
                int newone = int.Parse(Console.ReadLine());
                sum = sum + newone;
               
            }
            if (total <= 0)
            {
                Console.Write("¿Tu no seras un gracioso? ");
                
            }


            else
            {
                Console.Write("La suma de todos sus numeros es " + sum);
            } 



            Console.ReadLine();
        }
    }
}
