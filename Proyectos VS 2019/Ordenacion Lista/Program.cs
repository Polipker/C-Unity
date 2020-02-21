using System;

namespace Ordenacion_Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 3, 1, 2 };
            for (int i = 0; i < numbers.Length; i++) //Barrido 1
            {
                for (int j = i+1; j < numbers.Length; j++)//Barrido 2. J empieza en este segundo bucle valiendo  i +1
                {
                    if (numbers[j] <numbers[i])//aqui con para los valores del array en la posicion de cada contador 
                    {

                     int aux = numbers[i]; //valor auxiliar para intercambiar valores del array
                     numbers[i] = numbers[j];
                     numbers[j] = aux;
                    }
                }// En este punto j avanza una posicion. Se repetira hasta que i no sea menos de que n(numbers.Length) del array

            }// En este punto i avanza una posicion y se vuelve a repetir el su bucle (Barrido 2)
            Console.ReadLine();
        }

    }
}
