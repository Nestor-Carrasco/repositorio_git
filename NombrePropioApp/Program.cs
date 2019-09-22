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
            string nombre = "arIEl jA cID carDENAs";
            int a = nombre.IndexOf(" ") + 1; // posicion del 1° caracter nulo de izquierda a derecha

            string primerNombre = nombre.Substring(a);
            int b = a + primerNombre.IndexOf(" ") + 1; // posicion del 2° caracter nulo de izquierda a derecha

            int c = nombre.LastIndexOf(" "); // posicion del 3° caracter nulo de izquierda a derecha

            Console.WriteLine(nombre.Substring(0, 1).ToUpper() + // 1° mayuscula 
                              nombre.Substring(1, (a - 1)).ToLower() + // minuscula
                              nombre.Substring(a, 1).ToUpper() + // 2° mayuscula
                              nombre.Substring((a + 1), (b - a - 1)).ToLower() +// minusculas
                              nombre.Substring(b, 1).ToUpper() + // 3° mayuscula
                              nombre.Substring((b + 1), (c - b)).ToLower() + // minuscula
                              nombre.Substring((c + 1), 1).ToUpper() + // 4° mayuscula
                              nombre.Substring(c + 2).ToLower()); // minusculas
            Console.ReadKey();
        }
    }
}
