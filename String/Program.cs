using System;
using static System.Console;

// Crear un programa que pida al usuario su nombre, y le diga "Hola" si se llama "Alejandro", o bien le diga "No te conozco" si teclea otro nombre. tener en cuenta, que el la validación no es case sensitive, es decir que si escriben "alejandro" ,"Alejandro", "aleJANdrO" serán valores validos.


namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Input first string: ");
            string str1 = ReadLine();

            WriteLine($"\n{Match(str1)}");
        }

        public static string Match(string str1)
        {
            string a = str1.ToLower();
            string b = a.ToLower();
            a = b;
            string nameAle = "Alejandro";

            if (a == "alejandro")
            {
                return $"Hola {nameAle}!";
            }
            else
            {
                return "No te conozco";
            }
        }
    }
}
