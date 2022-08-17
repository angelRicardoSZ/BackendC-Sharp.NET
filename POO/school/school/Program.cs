using System;
using CoresEscuela.Entidades;

namespace school
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var escuela = new Escuela("school 1", 2022);

            escuela.Pais = "Mx";

            escuela.Ciudad = "Pue";

            escuela.TipoEscuela = TiposEscuela.Primaria;

            Console.WriteLine(escuela);
        }
    }
}
