/*Un programa que lea numeros de la entrada estandar e imprima su promedio (media aritmetica)
	El "fin" es la lectura de una linea en blanco / nula
*/
using System;

namespace Programa4
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z;

            y = 0;
            z = 0;

            while (double.TryParse(Console.ReadLine(), out x))
            {   
                y = x + y;
                z = z + 1;
            }
            y = y / z;
            Console.WriteLine(y);
        }
    }
}
