/*3. Un programa que lea numeros de la entrada estandard e imprima su cuadrado (n x n)
	El "fin" es la lectura de una linea en blanco / nula*/
using System;

namespace Programa3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            while (int.TryParse(Console.ReadLine(), out x))
            {
                y = (x * x);
                Console.WriteLine(y);
            }
            
        }
    }
}
