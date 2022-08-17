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


            var curso1 = new Curso() 
            {
                Nombre="101",
                
            };

            var curso2 = new Curso() 
            {
                Nombre="201",
                
            };

            var curso3 = new Curso() 
            {
                Nombre="301",
                
            };

            Console.WriteLine(escuela);

            Console.WriteLine("-------------------");

            Console.WriteLine(curso1.Nombre + ", " + curso1.UniqueId);

            Console.WriteLine(curso2.Nombre + ", " + curso2.UniqueId);



        }
    }
}
