using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;

namespace Captura
{
    class Persona
    {
        public string nombre;
        public string apellido;

        public static Persona FromCsv(string csvLine)
        {
            string[] values = csvLine.Split(',');
            Persona persona = new Persona();
            persona.nombre = values[0];
            persona.apellido = values[1];

            return persona;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            if (!File.Exists("Datos.csv"))
            {
                using (StreamWriter file = new StreamWriter("Datos.csv", true))
                {
                    file.WriteLine("NOMBRE" + "," + "APELLIDO" + "," + "EDAD" + "," + "AHORROS" + "," + "DATOS");
                }
            }

            int caseSwicht = 0;
            string archivo = "Datos.csv";

            //MENU//
            while (caseSwicht != 4)
            {
                LinkedList<string> nombresLinkedList = RefreshNombre();
                LinkedList<string> apellidosLinkedList = RefreshApellido();

                Console.WriteLine("MENU");
                Console.WriteLine("Elija una opcion");
                Console.WriteLine("1-ingresar registro");
                Console.WriteLine("2-imprimir lista");
                Console.WriteLine("3-Editar linea");
                Console.WriteLine("4-salir");
                caseSwicht = Convert.ToInt32(Console.ReadLine());
                

                switch (caseSwicht)
                {
                    case 1:
                        Registro(nombresLinkedList, apellidosLinkedList);
                        Console.Clear();
                        break;
                    case 2:
                        Imprimir(archivo);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        Editar();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 4:
                        break;
                        
                }
            }

        }
        public static void Imprimir(string archivo)
        {
            string[] lineas = File.ReadAllLines(archivo);
            for(int i = 0; i < lineas.Length; i++)
            {
                string[] campos = lineas[i].Split(',');
                Console.Write(i + "-" + campos[0] + "|" + campos[1] + "|" + campos[2] + "|" + campos[3] + "|");
                if(i == 0)
                {
                    Console.Write(campos[4]);
                }
                else
                {
                    DecimalBinario(Convert.ToInt32(campos[4])); 
                }
                Console.WriteLine("");
            }
        }
        public static int BinarioDecimal(int n)
        {
            int num = n;
            int entero = 0;
            int base1 = 1;

            int temp = num;
            while(temp > 0)
            {
                int ultimo_digito = temp % 10;
                temp = temp / 10;
                entero += ultimo_digito * base1;
                base1 = base1 * 2;
            }
            return entero;
        }
        public static void DecimalBinario(int n)
        {
            int[] a = new int[4];
            int i;
            for(i = 0; n>0;i++)
            {
                a[i] = n % 2;
                n = n / 2;
            }
            if (a[0] == 0)//fememnino
            {
                Console.Write("|Mujer");
            }
            else
            {
                Console.Write("|Hombre");
            }
            if (a[1] == 0)//17
            {
                Console.Write("|Menor de edad");
            }
            else
            {
                Console.Write("|Mayor de Edad");
            }
            if (a[2] == 0)//sin licensia
            {
                Console.Write("|Sin licensia de consucir");
            }
            else
            {
                Console.Write("|con licensia de conducir");
            }
            if (a[3] == 0)//sin vehiculo
            {
                Console.Write("|sin vehiculo");
            }
            else
            {
                Console.Write("|con vehiculo");
            }

        }
        public static void Registro(LinkedList<string> nombresLinkedList, LinkedList<string> apellidosLinkedList)
        {
            string nombre = "";

            string apellido = "";

            string edadC = "";
            int edad;

            string ahorrosC = "";
            double ahorros;

            string contrasena1 = "";
            string contrasena2 = "";

            bool genero;
            bool mayorDeEdad;
            bool licConducir;
            bool vehiculo;
            int entero;

            string binario = "";

            ConsoleKeyInfo caracter;

            Console.WriteLine("Nombre :");
            do
            {
                caracter = Console.ReadKey(true);
                if (caracter.Key != ConsoleKey.Backspace && caracter.Key != ConsoleKey.Enter)
                {
                    nombre += caracter.KeyChar;
                    Console.Write(caracter.KeyChar);
                }
                else
                {
                    if (caracter.Key == ConsoleKey.Backspace && nombre.Length > 0)
                    {
                        nombre = nombre.Substring(0, (nombre.Length - 1));
                        Console.Write("\b \b");
                    }
                    else if (caracter.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                }
            }
            while (true);
            Console.WriteLine("");

            Console.WriteLine("Apellido :");
            do
            {
                caracter = Console.ReadKey(true);
                if (caracter.Key != ConsoleKey.Backspace && caracter.Key != ConsoleKey.Enter)
                {
                    apellido += caracter.KeyChar;
                    Console.Write(caracter.KeyChar);
                }
                else
                {
                    if (caracter.Key == ConsoleKey.Backspace && apellido.Length > 0)
                    {
                        apellido = apellido.Substring(0, (apellido.Length - 1));
                        Console.Write("\b \b");
                    }
                    else if (caracter.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                }
            }
            while (true);
            Console.WriteLine("");

            Console.WriteLine("Edad :");
            do
            {
                caracter = Console.ReadKey(true);
                if (char.IsDigit(caracter.KeyChar))
                {
                    edadC += int.Parse(caracter.KeyChar.ToString());
                    Console.Write(caracter.KeyChar);
                }
                else if (caracter.Key == ConsoleKey.Enter)
                {
                    break;
                }
                else if (caracter.Key == ConsoleKey.Backspace && edadC.Length > 0)
                {
                    edadC = edadC.Substring(0, (edadC.Length - 1));
                    Console.Write("\b \b");
                }
            }
            while (true);
            edad = Convert.ToInt32(edadC);
            if (edad > 17)
            {
                mayorDeEdad = true;
            }
            else
            {
                mayorDeEdad = false;
            }

            Console.WriteLine("");

            Console.WriteLine("ahorros :");
            do
            {
                caracter = Console.ReadKey(true);
                if (char.IsDigit(caracter.KeyChar))
                {
                    ahorrosC += double.Parse(caracter.KeyChar.ToString());
                    Console.Write(caracter.KeyChar);
                }
                else if (caracter.Key == ConsoleKey.Enter)
                {
                    break;
                }
                else if (caracter.Key == ConsoleKey.Backspace && ahorrosC.Length > 0)
                {
                    ahorrosC = ahorrosC.Substring(0, (ahorrosC.Length - 1));
                    Console.Write("\b \b");
                }
            }
            while (true);
            ahorros = Convert.ToInt32(ahorrosC);
            Console.WriteLine("");

            Console.WriteLine("Maculino = M / Femenino = F");
            do
            {
                caracter = Console.ReadKey();
                if (caracter.Key != ConsoleKey.Backspace && caracter.Key != ConsoleKey.Enter)
                {
                    string R = "";
                    R += caracter.KeyChar;
                    R = R.ToUpper();

                    if (R == "F")
                    {
                        genero = false;
                        break;
                    }
                    else if (R == "M")
                    {
                        genero = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Escriba una letra valida");
                    }
                }
            } while (true);
            Console.WriteLine("");

            Console.WriteLine("Tiene Licensia de conducir? si=S / No=N");
            do
            {
                caracter = Console.ReadKey();
                if (caracter.Key != ConsoleKey.Backspace && caracter.Key != ConsoleKey.Enter)
                {
                    string R = "";
                    R += caracter.KeyChar;
                    R = R.ToUpper();

                    if (R == "N")
                    {
                        licConducir = false;
                        break;
                    }
                    else if (R == "S")
                    {
                        licConducir = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Escriba una letra valida");
                    }
                }
            } while (true);
            Console.WriteLine("");

            Console.WriteLine("Tiene vehiculo? Si=S / NO = N");
            do
            {
                caracter = Console.ReadKey();
                if (caracter.Key != ConsoleKey.Backspace && caracter.Key != ConsoleKey.Enter)
                {
                    string R = "";
                    R += caracter.KeyChar;
                    R = R.ToUpper();

                    if (R == "N")
                    {
                        vehiculo = false;
                        break;
                    }
                    else if (R == "S")
                    {
                        vehiculo = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Escriba una leta valida");
                    }
                }
            } while (true);
            Console.WriteLine("");
            Console.WriteLine("Contraseña :");
            do
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                {
                    contrasena2 += key.KeyChar;
                    Console.Write("*");
                }
                else
                {
                    if (key.Key == ConsoleKey.Backspace && contrasena2.Length > 0)
                    {
                        contrasena2 = contrasena2.Substring(0, (contrasena2.Length - 1));
                        Console.Write("\b \b");
                    }
                    else if (key.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                }
            } while (true);
            Console.WriteLine("");
            Console.WriteLine("confirme la contraseña :");
            do
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                {
                    contrasena1 += key.KeyChar;
                    Console.Write("*");
                }
                else
                {
                    if (key.Key == ConsoleKey.Backspace && contrasena2.Length > 0)
                    {
                        contrasena1 = contrasena1.Substring(0, (contrasena2.Length - 1));
                        Console.Write("\b \b");
                    }
                    else if (key.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                }
            } while (true);
            Console.WriteLine("");
            if (genero)
            {
                binario += "1";
            }
            else { binario += "0"; }

            if (mayorDeEdad)
            {
                binario += "1";
            }
            else { binario += "0"; }

            if (licConducir)
            {
                binario += "1";
            }
            else { binario += 0; }

            if (vehiculo)
            {
                binario += "1";
            }
            else { binario += "0"; }

            entero = BinarioDecimal(Convert.ToInt32(binario));

            Console.WriteLine();
            Console.WriteLine("su nombre es " + nombre);
            Console.WriteLine("su apellido es " + apellido);
            Console.WriteLine("su edad es " + edad);
            Console.WriteLine("sus ahorros son " + ahorros);
            
            if (contrasena2 == contrasena1)
            {
                Persona persona;
                bool repetido = false;
                string[] lineas = File.ReadAllLines("Datos.csv");
                for (int i = 0; i < lineas.Length; i++)
                {
                    //string[] campos = lineas[i].Split(',');
                    if (nombresLinkedList.Contains(nombre) && apellidosLinkedList.Contains(apellido))//campos[0] == nombre && campos[1] == apellido) 
                    {
                        Console.WriteLine("Ese nombre y apellido ya han sido registrados");
                        repetido = true;
                        break;
                    }
                    Console.WriteLine("");
                }
                if (repetido != true)
                {
                    Console.WriteLine("Las contrasenas son iguales, se guardaran los datos en el archivo");
                    using (StreamWriter file = new StreamWriter("Datos.csv", true))
                    {
                        file.WriteLine(nombre + "," + apellido + "," + edad + "," + ahorros + "," + entero);
                    }
                }
            }
            else
            {
                Console.WriteLine("Las contrasenas NO son iguales");
            }
            Console.ReadLine();
        }
        public static void Editar()
        {
            Console.WriteLine("Que linea desea editar?");
            int linea = Convert.ToInt32(Console.ReadLine());
            int campo1;
            do
            {
                Console.WriteLine("que campo desea editar? Nombre = 0 | Apellido = 1 | Edad = 2 | Ahorros = 3");
                int campo = Convert.ToInt32(Console.ReadLine());
                if(campo > 3 || campo < 0 )
                {
                    Console.WriteLine("ingrese un campo valido");
                }
                else
                {
                    campo1 = campo;
                    break;
                }
            } while (true);


            string[] lineas = File.ReadAllLines("Datos.csv");
            if (linea < lineas.Length)
            {
                Console.WriteLine("ingrese el nuevo valor");

                string[] campos = lineas[linea].Split(',');
                campos[campo1] = Console.ReadLine();
                string edited_line = (campos[0] + "," + campos[1] + "," + campos[2] + "," + campos[3] + "," + campos[4]);
                lineas[linea] = edited_line;

                File.Delete("Datos.csv");

                using (StreamWriter writer = new StreamWriter("Datos.csv", true))
                {
                    
                    for (int i = 0; i < lineas.Length; i++)
                    {
                        writer.WriteLine(lineas[i]);
                    }
                }


            }
            else
            {
                Console.WriteLine("La linea especificada no existe");
            }
        }
        public static LinkedList<string> RefreshNombre()
        {
            List<Persona> personasList = File.ReadAllLines("Datos.csv").Skip(1).Select(v => Persona.FromCsv(v)).ToList();

            LinkedList<string> nombresLinkedList = new LinkedList<string>();

            foreach (Persona persona in personasList)
            {
                nombresLinkedList.AddLast(persona.nombre);
            }
            return nombresLinkedList;
        }
        public static LinkedList<string> RefreshApellido()
        {
            List<Persona> personasList = File.ReadAllLines("Datos.csv").Skip(1).Select(v => Persona.FromCsv(v)).ToList();

            LinkedList<string> apellidosLinkedList = new LinkedList<string>();

            foreach (Persona persona in personasList)
            {
                apellidosLinkedList.AddLast(persona.apellido);
            }
            return apellidosLinkedList;
        }
    }
}
