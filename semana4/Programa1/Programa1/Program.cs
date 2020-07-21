/*1. Programa que recibe un parametro por la consola(argumento de linea de comando)

    El parametro es numerico, entero y positivo
    Debe imprimir los numeros del 1 hasta el numero introducido uno por linea
    Si el valor introducido es invalido(cero, negativo o no puede ser convertido a numero), debe escribir un error por la salida de error estandard*/

using System;

namespace Programa1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;

            x = Convert.ToInt32(args[0]);

            if (x > 0 && int.TryParse(args[0], out x))
            {
                for (int i = 1; i < x + 1; i++)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine(" ");
            }
            else
            {
                Console.Error.WriteLine("ERROR: El valor introducido es invalido(cero, negativo o no puede ser convertido a numero)");
            }
        }
    }
}
