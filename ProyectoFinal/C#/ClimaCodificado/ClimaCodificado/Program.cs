using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;

namespace ClimaCodificado
{
    class Program
    {
        static void Main(string[] args)
        {      
            string encodeInput = "EncodeInput.csv";
            string encodeOutput = "EncodeOutput.csv";
            string decodeInput = "DecodeInput.csv";
            string decodeOutput = "DecodeOutput.csv";
            int caseSwitch = 0;

            while (caseSwitch != 5)
            {

                Console.WriteLine("MENU");
                Console.WriteLine("Elija una opcion");
                Console.WriteLine("1-Codificar clima");
                Console.WriteLine("2-Decodificar clima");
                Console.WriteLine("3-Imprimir clima codificado");
                Console.WriteLine("4-Imprimir clima decodificado");
                Console.WriteLine("5-Salir");
                caseSwitch = Convert.ToInt32(Console.ReadLine());


                switch (caseSwitch)
                {
                    case 1:
                        Console.Clear();
                        if (!File.Exists(encodeInput))
                        {
                            Console.WriteLine("no hay ningun archivo para codificar en la carpeta del programa");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                        Record.Encode(encodeInput,encodeOutput);
                        Console.WriteLine("El Registro ha sido codificado");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        if (!File.Exists(decodeInput))
                        {
                            Console.WriteLine("no hay ningun archivo para decodificar en la carpeta del programa");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                        Record.Decode(decodeInput, decodeOutput);
                        Console.WriteLine("El Registro ha sido decodificado");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        if (!File.Exists(encodeOutput))
                        {
                            Console.WriteLine("No existe un registro de codificacion para leer");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                        Print(encodeOutput);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 4:
                        Console.Clear();
                        if (!File.Exists(decodeOutput))
                        {
                            Console.WriteLine("No existe un registro de decodificacion para leer");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                        Print(decodeOutput);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 5:
                        caseSwitch = 5;
                        break;

                }
            }
        }

        public static void Print(string file)
        {
            string[] recordList = File.ReadAllLines(file);

            for (int i = 0; i < recordList.Length; i++)
            {
                Console.WriteLine(recordList[i]);
            }
        }
    }
}
