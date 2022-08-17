using System;
using CoresEscuela.Entidades;

namespace school
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var escuela = new Escuela("school 1", 2022, TiposEscuela.Primaria, ciudad:"TLX");

            escuela.Pais = "Mx";

            Console.WriteLine(escuela);
        }
    }
}
