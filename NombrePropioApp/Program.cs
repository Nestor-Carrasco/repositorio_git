using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NombrePropioApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = "nesTOr miGUel cArrAscO hUEntEMil";
            int a = nombre.IndexOf(" ") + 1; // posicion de 1° caracter despues de 1° caracter nulo de izquierda a derecha
            int b = nombre.LastIndexOf(" "); // posicion de 1° caracter nulo de derecha a izquierda
            Console.WriteLine(nombre.Substring(0, 1).ToUpper() + // 1° mayuscula 
                              nombre.Substring(1, (a - 1)).ToLower() + // minuscula
                              nombre.Substring(a, 1).ToUpper() + // 2° mayuscula
                              nombre.Substring((a + 1), (b - a)).ToLower() + // minusculas
                              nombre.Substring((b + 1), 1).ToUpper() + // 3° mayuscula
                              nombre.Substring(b + 2).ToLower()); // minusculas
            Console.ReadKey();
        }
    }
}
