using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace Morse
{
    class Program
    {
        public static void Main(string[] args)
        {
            string m = args[0];
            m = m.ToUpper();
            char[] caracteres = m.ToCharArray();
            int unidad = 500;
            int x = 0;

            //Calculo de tiempo
            for (int i = 0; i < m.Length; i++) 
            {
                if (caracteres[i].Equals('A'))
                {
                    x = espaciot(x);//750
                    x = puntot(x);//500
                    x = lineat(x);//1250
                    //2500
                }
                else
                if (caracteres[i].Equals('B'))
                {
                    x = espaciot(x);
                    x = lineat(x);
                    x = puntot(x);
                    x = puntot(x);
                    x = puntot(x);
                }
                else
                if (caracteres[i].Equals('C'))
                {
                    x = espaciot(x);
                    x = lineat(x);
                    x = puntot(x);
                    x = lineat(x);
                    x = puntot(x);

                }
                else
                if (caracteres[i].Equals('D'))
                {
                    x = espaciot(x);
                    x = lineat(x);
                    x = puntot(x);
                    x = puntot(x);
                }
                else
                if (caracteres[i].Equals('E'))
                {
                    x = espaciot(x);
                    x = puntot(x);
                }
                else
                if (caracteres[i].Equals('F'))
                {
                    x = espaciot(x);
                    x = puntot(x);
                    x = puntot(x);
                    x = lineat(x);
                    x = puntot(x);
                }
                else
                if (caracteres[i].Equals('H'))
                {
                    x = espaciot(x);
                    x = puntot(x);
                    x = puntot(x);
                    x = puntot(x);
                    x = puntot(x);
                }
                else
                if (caracteres[i].Equals('I'))
                {
                    x = espaciot(x);
                    x = puntot(x);
                    x = puntot(x);
                }
                else
                if (caracteres[i].Equals('J'))
                {
                    x = espaciot(x);
                    x = puntot(x);
                    x = lineat(x);
                    x = lineat(x);
                    x = lineat(x);
                }
                else
                if (caracteres[i].Equals('K'))
                {
                    x = espaciot(x);
                    x = lineat(x);
                    x = puntot(x);
                    x = lineat(x);
                }
                else
                if (caracteres[i].Equals('L'))
                {
                    x = espaciot(x);
                    x = puntot(x);
                    x = lineat(x);
                    x = puntot(x);
                    x = puntot(x);
                }
                else
                if (caracteres[i].Equals('M'))
                {
                    x = espaciot(x);
                    x = lineat(x);
                    x = lineat(x);
                }
                else
                if (caracteres[i].Equals('N'))
                {
                    x = espaciot(x);
                    x = lineat(x);
                    x = puntot(x);
                }
                else
                if (caracteres[i].Equals('O'))
                {
                    x = espaciot(x);
                    x = lineat(x);
                    x = lineat(x);
                    x = lineat(x);
                }
                else
                if (caracteres[i].Equals('P'))
                {
                    x = espaciot(x);
                    x = puntot(x);
                    x = lineat(x);
                    x = lineat(x);
                    x = puntot(x);
                }
                else
                if (caracteres[i].Equals('Q'))
                {
                    x = espaciot(x);
                    x = lineat(x);
                    x = lineat(x);
                    x = puntot(x);
                    x = lineat(x);
                }
                else
                if (caracteres[i].Equals('R'))
                {
                    x = espaciot(x);
                    x = puntot(x);
                    x = lineat(x);
                    x = puntot(x);
                }
                else
                if (caracteres[i].Equals('S'))
                {
                    x = espaciot(x);
                    x = puntot(x);
                    x = puntot(x);
                    x = puntot(x);

                }
                else
                if (caracteres[i].Equals('T'))
                {
                    x = espaciot(x);
                    x = lineat(x);
                }
                else
                if (caracteres[i].Equals('U'))
                {
                    x = espaciot(x);
                    x = puntot(x);
                    x = puntot(x);
                    x = lineat(x);
                }
                else
                if (caracteres[i].Equals('V'))
                {
                    x = espaciot(x);
                    x = puntot(x);
                    x = puntot(x);
                    x = puntot(x);
                    x = lineat(x);
                }
                else
                if (caracteres[i].Equals('W'))
                {
                    x = espaciot(x);
                    x = puntot(x);
                    x = lineat(x);
                    x = lineat(x);
                }
                else
                if (caracteres[i].Equals('X'))
                {
                    x = espaciot(x);
                    x = lineat(x);
                    x = puntot(x);
                    x = puntot(x);
                    x = lineat(x);
                }
                else
                if (caracteres[i].Equals('Y'))
                {
                    x = espaciot(x);
                    x = lineat(x);
                    x = puntot(x);
                    x = lineat(x);
                    x = lineat(x);
                }
                else
                if (caracteres[i].Equals('Z'))
                {
                    x = espaciot(x);
                    x = lineat(x);
                    x = lineat(x);
                    x = puntot(x);
                    x = puntot(x);
                }
                else
                if (caracteres[i].Equals('1'))
                {
                    x = espaciot(x);
                    x = puntot(x);
                    x = lineat(x);
                    x = lineat(x);
                    x = lineat(x);
                    x = lineat(x);
                }
                else
                if (caracteres[i].Equals('2'))
                {
                    x = espaciot(x);
                    x = puntot(x);
                    x = puntot(x);
                    x = lineat(x);
                    x = lineat(x);
                    x = lineat(x);
                }
                else
                if (caracteres[i].Equals('3'))
                {
                    x = espaciot(x);
                    x = puntot(x);
                    x = puntot(x);
                    x = puntot(x);
                    x = lineat(x);
                    x = lineat(x);
                }
                else
                if (caracteres[i].Equals('4'))
                {
                    x = espaciot(x);
                    x = puntot(x);
                    x = puntot(x);
                    x = puntot(x);
                    x = puntot(x);
                    x = lineat(x);
                }
                else
                if (caracteres[i].Equals('5'))
                {
                    x = espaciot(x);
                    x = puntot(x);
                    x = puntot(x);
                    x = puntot(x);
                    x = puntot(x);
                    x = puntot(x);
                }
                else
                if (caracteres[i].Equals('6'))
                {
                    x = espaciot(x);
                    x = lineat(x);
                    x = puntot(x);
                    x = puntot(x);
                    x = puntot(x);
                    x = puntot(x);
                }
                else
                if (caracteres[i].Equals('7'))
                {
                    x = espaciot(x);
                    x = lineat(x);
                    x = lineat(x);
                    x = puntot(x);
                    x = puntot(x);
                    x = puntot(x);
                }
                else
                if (caracteres[i].Equals('8'))
                {
                    x = espaciot(x);
                    x = lineat(x);
                    x = lineat(x);
                    x = lineat(x);
                    x = puntot(x);
                    x = puntot(x);
                }
                else
                if (caracteres[i].Equals('9'))
                {
                    x = espaciot(x);
                    x = lineat(x);
                    x = lineat(x);
                    x = lineat(x);
                    x = lineat(x);
                    x = puntot(x);
                }
                else
                if (caracteres[i].Equals('0'))
                {
                    x = espaciot(x);
                    x = lineat(x);
                    x = lineat(x);
                    x = lineat(x);
                    x = lineat(x);
                    x = lineat(x);
                }
                else
                if (caracteres[i].Equals(' '))
                {
                    x = x + 1750;
                }
            }

            Console.WriteLine("El mensaje tomara " + (x*2) / 1000 + " segundos para reproducirse");

            //Reproduccion de mensaje
            for (int i = 0; i < m.Length; i++)
            {
                if (caracteres[i].Equals('A'))
                {
                    espacio();
                    punto();
                    linea();
                }
                else
                if (caracteres[i].Equals('B'))
                {
                    espacio();
                    linea();
                    punto();
                    punto();
                    punto();
                }
                else
                if (caracteres[i].Equals('C'))
                {
                    espacio();
                    linea();
                    punto();
                    linea();
                    punto();

                }
                else
                if (caracteres[i].Equals('D'))
                {
                    espacio();
                    linea();
                    punto();
                    punto();
                }
                else
                if (caracteres[i].Equals('E'))
                {
                    espacio();
                    punto();
                }
                else
                if (caracteres[i].Equals('F'))
                {
                    espacio();
                    punto();
                    punto();
                    linea();
                    punto();
                }
                else
                if (caracteres[i].Equals('H'))
                {
                    espacio();
                    punto();
                    punto();
                    punto();
                    punto();
                }
                else
                if (caracteres[i].Equals('I'))
                {
                    espacio();
                    punto();
                    punto();
                }
                else
                if (caracteres[i].Equals('J'))
                {
                    espacio();
                    punto();
                    linea();
                    linea();
                    linea();
                }
                else
                if (caracteres[i].Equals('K'))
                {
                    espacio();
                    linea();
                    punto();
                    linea();
                }
                else
                if (caracteres[i].Equals('L'))
                {
                    espacio();
                    punto();
                    linea();
                    punto();
                    punto();
                }
                else
                if (caracteres[i].Equals('M'))
                {
                    espacio();
                    linea();
                    linea();
                }
                else
                if (caracteres[i].Equals('N'))
                {
                    espacio();
                    linea();
                    punto();
                }
                else
                if (caracteres[i].Equals('O'))
                {
                    espacio();
                    linea();
                    linea();
                    linea();
                }
                else
                if (caracteres[i].Equals('P'))
                {
                    espacio();
                    punto();
                    linea();
                    linea();
                    punto();
                }
                else
                if (caracteres[i].Equals('Q'))
                {
                    espacio();
                    linea();
                    linea();
                    punto();
                    linea();
                }
                else
                if (caracteres[i].Equals('R'))
                {
                    espacio();
                    punto();
                    linea();
                    punto();
                }
                else
                if (caracteres[i].Equals('S'))
                {
                    espacio();
                    punto();
                    punto();
                    punto();
                }
                else
                if (caracteres[i].Equals('T'))
                {
                    espacio();
                    linea();
                }
                else
                if (caracteres[i].Equals('U'))
                {
                    espacio();
                    punto();
                    punto();
                    linea();
                }
                else
                if (caracteres[i].Equals('V'))
                {
                    espacio();
                    punto();
                    punto();
                    punto();
                    linea();
                }
                else
                if (caracteres[i].Equals('W'))
                {
                    espacio();
                    punto();
                    linea();
                    linea();
                }
                else
                if (caracteres[i].Equals('X'))
                {
                    espacio();
                    linea();
                    punto();
                    punto();
                    linea();
                }
                else
                if (caracteres[i].Equals('Y'))
                {
                    espacio();
                    linea();
                    punto();
                    linea();
                    linea();
                }
                else
                if (caracteres[i].Equals('Z'))
                {
                    espacio();
                    linea();
                    linea();
                    punto();
                    punto();
                }
                else
                if (caracteres[i].Equals('1'))
                {
                    espacio();
                    punto();
                    linea();
                    linea();
                    linea();
                    linea();
                }
                else
                if (caracteres[i].Equals('2'))
                {
                    espacio();
                    punto();
                    punto();
                    linea();
                    linea();
                    linea();
                }
                else
                if (caracteres[i].Equals('3'))
                {
                    espacio();
                    punto();
                    punto();
                    punto();
                    linea();
                    linea();
                }
                else
                if (caracteres[i].Equals('4'))
                {
                    espacio();
                    punto();
                    punto();
                    punto();
                    punto();
                    linea();
                }
                else
                if (caracteres[i].Equals('5'))
                {
                    espacio();
                    punto();
                    punto();
                    punto();
                    punto();
                    punto();
                }
                else
                if (caracteres[i].Equals('6'))
                {
                    espacio();
                    linea();
                    punto();
                    punto();
                    punto();
                    punto();
                }
                else
                if (caracteres[i].Equals('7'))
                {
                    espacio();
                    linea();
                    linea();
                    punto();
                    punto();
                    punto();
                }
                else
                if (caracteres[i].Equals('8'))
                {
                    espacio();
                    linea();
                    linea();
                    linea();
                    punto();
                    punto();
                }
                else
                if (caracteres[i].Equals('9'))
                {
                    espacio();
                    linea();
                    linea();
                    linea();
                    linea();
                    punto();
                }
                else
                if (caracteres[i].Equals('0'))
                {
                    espacio();
                    linea();
                    linea();
                    linea();
                    linea();
                    linea();
                }
                else
                if (caracteres[i].Equals(' '))
                {
                    System.Threading.Thread.Sleep(unidad * 7);
                }
                else
                {
                    Console.Error.WriteLine(caracteres[i] + " no es un caracter valido para el codigo morse");
                }
            }
            

            void punto()
            {
                Console.Beep(600, unidad);
                System.Threading.Thread.Sleep(unidad);
                //500
            }
            void linea()
            {
                Console.Beep(600, unidad * 3);
                System.Threading.Thread.Sleep(unidad);
                //1000
            }
            void espacio()
            {
                System.Threading.Thread.Sleep(unidad * 3);
                //750
            }

            int puntot(int x)
            {
                x = x + 500;
                return x;
                //500
                
            }
            int lineat(int x)
            {
                x = x + 1000;
                return x;
                //1000
            }
            int espaciot(int x)
            {
                x = x + 750;
                return x;
                //750
            }
        }
    }
}

