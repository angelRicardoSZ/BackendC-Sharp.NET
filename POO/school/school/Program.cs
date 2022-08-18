using System;
using System.Collections.Generic;
using CoresEscuela.Entidades;
using static System.Console;

namespace school
{
    class Program
    {
        static void Main(string[] args)
        {

            var escuela = new Escuela("school 1", 2022, TiposEscuela.Primaria, ciudad: "TLX");

            escuela.Pais = "Mx";


            var listaCursos = new List<Curso>(){
                            new Curso(){Nombre = "101"},
                            new Curso(){Nombre = "201"},
                            new Curso(){Nombre = "301"},
            };


            
            
            // Curso[] arregloCursos = {
            //                 new Curso()
            //                         {
            //                             Nombre="101"},
            //                 new Curso()
            //                 {
            //                     Nombre = "201"
            //                 },
            //                 new Curso()
            //                 {
            //                     Nombre = "301"
            //                 },
            // };

            // escuela.Cursos = arregloCursos;
            escuela.Cursos =listaCursos;
            

            // escuela.Cursos = new Curso[] {
            //                 new Curso()
            //                         {
            //                             Nombre="101"},
            //                 new Curso()
            //                 {
            //                     Nombre = "201"
            //                 },
            //                 new Curso()
            //                 {
            //                     Nombre = "301"
            //                 },
            // };

            // Console.WriteLine(escuela);

            // Console.WriteLine("-------------------");
            // Console.WriteLine("While loop");
            // ImprimirCursosWhile(arregloCursos);

            // Console.WriteLine("-------------------");
            // Console.WriteLine("Do-While loop");
            // ImprimirCursosDoWhile(arregloCursos);

            // Console.WriteLine("-------------------");
            // Console.WriteLine("For");
            // ImprimirCursosFor(arregloCursos);


            // Console.WriteLine("-------------------");
            // Console.WriteLine("For each");
            // ImprimirCursosForEach(arregloCursos);
            
            ImprimirCursosEscuela(escuela);

            static void ImprimirCursosEscuela(Escuela escuela)
            {
                WriteLine("=================");
                WriteLine("Cursos de la Escuela");
                WriteLine("=================");


                // if( escuela!= null && escuela.Cursos != null) 
                // {
                //     foreach (var curso in escuela.Cursos)
                //     {
                //         Console.WriteLine($"Nombre {curso.Nombre}, ID: {curso.UniqueId}");
                //     }
                // }

                
                if( escuela?.Cursos != null) 
                {
                    foreach (var curso in escuela.Cursos)
                    {
                        Console.WriteLine($"Nombre {curso.Nombre}, ID: {curso.UniqueId}");
                    }
                }

                

            }

            // static void ImprimirCursosWhile(Curso[] array)
            // {
            //     int contador = 0;
            //     while (contador < array.Length)
            //     {
            //         Console.WriteLine($"Nombre {array[contador].Nombre}, ID: {array[contador].UniqueId}");
            //         contador++;

            //     }
            // }


            // static void ImprimirCursosDoWhile(Curso[] array)
            // {
            //     int contador = 0;
            //     do
            //     {
            //         Console.WriteLine($"Nombre {array[contador].Nombre}, ID: {array[contador].UniqueId}");
            //         contador++;

            //     } while (contador < array.Length);
            // }


            // static void ImprimirCursosFor(Curso[] array)
            // {
            //     for (int i = 0; i < array.Length; i++)
            //     {
            //         Console.WriteLine($"Nombre {array[i].Nombre}, ID: {array[i].UniqueId}");
            //     }

            // }


            // static void ImprimirCursosForEach(Curso[] array)
            // {
            //     foreach (var curso in array)
            //     {
            //         Console.WriteLine($"Nombre {curso.Nombre}, ID: {curso.UniqueId}");
            //     }

            // }




        }
    }
}
