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
            string m = Console.ReadLine();//args[0];
            m = m.ToUpper();
            char[] caracteres = m.ToCharArray();
            int unidad = 250;
            int x = 0;
            string y;

            //Calculo de tiempo
            for (int i = 0; i < m.Length; i++) 
            {
                if (caracteres[i].Equals('A'))
                {
                    espaciot(x);//750
                    puntot(x);//500
                    lineat(x);//1250
                    //2500
                }
                else
                if (caracteres[i].Equals('B'))
                {
                    espaciot(x);
                    lineat(x);
                    puntot(x);
                    puntot(x);
                    puntot(x);
                }
                else
                if (caracteres[i].Equals('C'))
                {
                    espaciot(x);
                    lineat(x);
                    puntot(x);
                    lineat(x);
                    puntot(x);

                }
                else
                if (caracteres[i].Equals('D'))
                {
                    espaciot(x);
                    lineat(x);
                    puntot(x);
                    puntot(x);
                }
                else
                if (caracteres[i].Equals('E'))
                {
                    espaciot(x);
                    puntot(x);
                }
                else
                if (caracteres[i].Equals('F'))
                {
                    espaciot(x);
                    puntot(x);
                    puntot(x);
                    lineat(x);
                    puntot(x);
                }
                else
                if (caracteres[i].Equals('H'))
                {
                    espaciot(x);
                    puntot(x);
                    puntot(x);
                    puntot(x);
                    puntot(x);
                }
                else
                if (caracteres[i].Equals('I'))
                {
                    espaciot(x);
                    puntot(x);
                    puntot(x);
                }
                else
                if (caracteres[i].Equals('J'))
                {
                    espaciot(x);
                    puntot(x);
                    lineat(x);
                    lineat(x);
                    lineat(x);
                }
                else
                if (caracteres[i].Equals('K'))
                {
                    espaciot(x);
                    lineat(x);
                    puntot(x);
                    lineat(x);
                }
                else
                if (caracteres[i].Equals('L'))
                {
                    espaciot(x);
                    puntot(x);
                    lineat(x);
                    puntot(x);
                    puntot(x);
                }
                else
                if (caracteres[i].Equals('M'))
                {
                    espaciot(x);
                    lineat(x);
                    lineat(x);
                }
                else
                if (caracteres[i].Equals('N'))
                {
                    espaciot(x);
                    lineat(x);
                    puntot(x);
                }
                else
                if (caracteres[i].Equals('O'))
                {
                    espaciot(x);
                    lineat(x);
                    lineat(x);
                    lineat(x);
                }
                else
                if (caracteres[i].Equals('P'))
                {
                    espaciot(x);
                    puntot(x);
                    lineat(x);
                    lineat(x);
                    puntot(x);
                }
                else
                if (caracteres[i].Equals('Q'))
                {
                    espaciot(x);
                    lineat(x);
                    lineat(x);
                    puntot(x);
                    lineat(x);
                }
                else
                if (caracteres[i].Equals('R'))
                {
                    espaciot(x);
                    puntot(x);
                    lineat(x);
                    puntot(x);
                }
                else
                if (caracteres[i].Equals('S'))
                {
                    espaciot(x);
                    puntot(x);
                    puntot(x);
                    puntot(x);

                }
                else
                if (caracteres[i].Equals('T'))
                {
                    espaciot(x);
                    lineat(x);
                }
                else
                if (caracteres[i].Equals('U'))
                {
                    espaciot(x);
                    puntot(x);
                    puntot(x);
                    lineat(x);
                }
                else
                if (caracteres[i].Equals('V'))
                {
                    espaciot(x);
                    puntot(x);
                    puntot(x);
                    puntot(x);
                    lineat(x);
                }
                else
                if (caracteres[i].Equals('W'))
                {
                    espaciot(x);
                    puntot(x);
                    lineat(x);
                    lineat(x);
                }
                else
                if (caracteres[i].Equals('X'))
                {
                    espaciot(x);
                    lineat(x);
                    puntot(x);
                    puntot(x);
                    lineat(x);
                }
                else
                if (caracteres[i].Equals('Y'))
                {
                    espaciot(x);
                    lineat(x);
                    puntot(x);
                    lineat(x);
                    lineat(x);
                }
                else
                if (caracteres[i].Equals('Z'))
                {
                    espaciot(x);
                    lineat(x);
                    lineat(x);
                    puntot(x);
                    puntot(x);
                }
                else
                if (caracteres[i].Equals('1'))
                {
                    espaciot(x);
                    puntot(x);
                    lineat(x);
                    lineat(x);
                    lineat(x);
                    lineat(x);
                }
                else
                if (caracteres[i].Equals('2'))
                {
                    espaciot(x);
                    puntot(x);
                    puntot(x);
                    lineat(x);
                    lineat(x);
                    lineat(x);
                }
                else
                if (caracteres[i].Equals('3'))
                {
                    espaciot(x);
                    puntot(x);
                    puntot(x);
                    puntot(x);
                    lineat(x);
                    lineat(x);
                }
                else
                if (caracteres[i].Equals('4'))
                {
                    espaciot(x);
                    puntot(x);
                    puntot(x);
                    puntot(x);
                    puntot(x);
                    lineat(x);
                }
                else
                if (caracteres[i].Equals('5'))
                {
                    espaciot(x);
                    puntot(x);
                    puntot(x);
                    puntot(x);
                    puntot(x);
                    puntot(x);
                }
                else
                if (caracteres[i].Equals('6'))
                {
                    espaciot(x);
                    lineat(x);
                    puntot(x);
                    puntot(x);
                    puntot(x);
                    puntot(x);
                }
                else
                if (caracteres[i].Equals('7'))
                {
                    espaciot(x);
                    lineat(x);
                    lineat(x);
                    puntot(x);
                    puntot(x);
                    puntot(x);
                }
                else
                if (caracteres[i].Equals('8'))
                {
                    espaciot(x);
                    lineat(x);
                    lineat(x);
                    lineat(x);
                    puntot(x);
                    puntot(x);
                }
                else
                if (caracteres[i].Equals('9'))
                {
                    espaciot(x);
                    lineat(x);
                    lineat(x);
                    lineat(x);
                    lineat(x);
                    puntot(x);
                }
                else
                if (caracteres[i].Equals('0'))
                {
                    espaciot(x);
                    lineat(x);
                    lineat(x);
                    lineat(x);
                    lineat(x);
                    lineat(x);
                }
                else
                if (caracteres[i].Equals(' '))
                {
                    x = x + 1750;
                }
            }

            Console.WriteLine("El mensaje tomara " + x / 1000 + " segundos para reproducirse");
            Console.WriteLine("desea reproducir este mensaje? S=si / N=no");
            y = (Console.ReadLine());

            if (y.ToUpper().Equals('S'))
            {
                //Reproduccion de mensaje
                for (int i = 0; i < m.Length; i++)
                {
                    if (caracteres[i].Equals('A'))
                    {
                        espacio();//750
                        punto();//500
                        linea();//1250
                                //2500
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
                Console.WriteLine(x);
                return x;
                //500
                
            }
            int lineat(int x)
            {
                x = x + 1000;
                Console.WriteLine(x);

                return x;
                //1000
            }
            int espaciot(int x)
            {
                x = x + 750;
                Console.WriteLine(x);
                return x;
                //750
            }
        }
    }
}
