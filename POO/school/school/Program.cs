using System;
using CoresEscuela.Entidades;
using static System.Console;

namespace school
{
    class Program
    {
        static void Main(string[] args)
        {

            var escuela = new Escuela("school 1", 2022, TiposEscuela.Primaria, ciudad:"TLX");

            escuela.Pais = "Mx";

            var arregloCursos = new Curso[3];

            arregloCursos[0] = new Curso()
                                    {
                                        Nombre="101"
                                    };

            var curso2 = new Curso() 
            {
                Nombre="201",
                
            };

            arregloCursos[1] = curso2;

            arregloCursos[2] =  new Curso 
            {
                Nombre="301",
                
            };

            Console.WriteLine(escuela);

            Console.WriteLine("-------------------");
            Console.WriteLine("While loop");
            ImprimirCursosWhile(arregloCursos);

            Console.WriteLine("-------------------");
            Console.WriteLine("Do-While loop");
            ImprimirCursosDoWhile(arregloCursos);

            Console.WriteLine("-------------------");
            Console.WriteLine("For");
            ImprimirCursosFor(arregloCursos);

            
            Console.WriteLine("-------------------");
            Console.WriteLine("For each");
            ImprimirCursosForEach(arregloCursos);




            static void ImprimirCursosWhile(Curso[] array)
            {   
                int contador = 0;
                while(contador < array.Length)
                {
                    Console.WriteLine($"Nombre {array[contador].Nombre}, ID: {array[contador].UniqueId}");
                    contador++;

                }
            }


            static void ImprimirCursosDoWhile(Curso[] array)
            {   
                int contador = 0;
                do
                {
                    Console.WriteLine($"Nombre {array[contador].Nombre}, ID: {array[contador].UniqueId}");
                    contador++;

                } while(contador < array.Length);
            }


            static void ImprimirCursosFor(Curso[] array)
            {   
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine($"Nombre {array[i].Nombre}, ID: {array[i].UniqueId}");    
                }
                
            }


            static void ImprimirCursosForEach(Curso[] array)
            {   
                foreach (var curso in array)
                {
                    Console.WriteLine($"Nombre {curso.Nombre}, ID: {curso.UniqueId}");    
                }
                
            }
            



        }
    }
}
