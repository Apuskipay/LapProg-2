/*Un programa que lea numeros de la entrada estandard e imprima la sumatoria
    El "fin" es la lectura de una linea en blanco / nula*/
using System;

namespace Programa_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            y = 0;

            while (int.TryParse(Console.ReadLine(),out x))
            {
                y = x + y;
            }
            Console.WriteLine(y);
        }
    }
}
