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
                            new Curso(){Nombre = "101",Jornada = TiposJornada.Morning},
                            new Curso(){Nombre = "201",Jornada = TiposJornada.Morning},
                            new Curso(){Nombre = "301",Jornada = TiposJornada.Morning},
            };        

            escuela.Cursos =listaCursos;

            escuela.Cursos.Add( new Curso {Nombre="102", Jornada = TiposJornada.afternoon});
            
            var otrosCursos = new List<Curso>(){
                new Curso(){Nombre = "401",Jornada = TiposJornada.Morning},
                new Curso(){Nombre = "501",Jornada = TiposJornada.Morning},
                new Curso(){Nombre = "501",Jornada = TiposJornada.Night},
            };

            escuela.Cursos.AddRange(otrosCursos);
            



            // delete using predicate
            //escuela.Cursos.RemoveAll(Predicado);

            // Another way to delete: Delegate
            // escuela.Cursos.RemoveAll(delegate(Curso cur){return cur.Nombre == "301";} );

            // Another way to delete: Lambda functions
            //escuela.Cursos.RemoveAll((cur)=> cur.Nombre == "501" && cur.Jornada == TiposJornada.Morning);
            
            ImprimirCursosEscuela(escuela);

        }
        private static void ImprimirCursosEscuela(Escuela escuela)
            {
                WriteLine("=================");
                WriteLine("Cursos de la Escuela");
                WriteLine("=================");

                if( escuela?.Cursos != null) 
                {
                    foreach (var curso in escuela.Cursos)
                    {
                        Console.WriteLine($"Nombre {curso.Nombre}, ID: {curso.UniqueId}");
                    }
                }

            }
        // private static bool Predicado(Curso cur)
        // {
        //     return cur.Nombre == "301" ;
        // }
    }
}
