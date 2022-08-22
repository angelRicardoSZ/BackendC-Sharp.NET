using System;

using CoresEscuela.Entidades;
using CoresEscuela.Util;
using static System.Console;

namespace CoresEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new EscuelaEngine();
            engine.Inicializar();
            // var escuela = new Escuela("school 1", 2022, TiposEscuela.Primaria, ciudad: "TLX");

            // escuela.Pais = "Mx";

            // var listaCursos = new List<Curso>(){
            //                 new Curso(){Nombre = "101",Jornada = TiposJornada.Morning},
            //                 new Curso(){Nombre = "201",Jornada = TiposJornada.Morning},
            //                 new Curso(){Nombre = "301",Jornada = TiposJornada.Morning},
            // };        

            // escuela.Cursos =listaCursos;

            // escuela.Cursos.Add( new Curso {Nombre="102", Jornada = TiposJornada.afternoon});
            
            // var otrosCursos = new List<Curso>(){
            //     new Curso(){Nombre = "401",Jornada = TiposJornada.Morning},
            //     new Curso(){Nombre = "501",Jornada = TiposJornada.Morning},
            //     new Curso(){Nombre = "501",Jornada = TiposJornada.Night},
            // };

            // escuela.Cursos.AddRange(otrosCursos);
            



            // delete using predicate
            //escuela.Cursos.RemoveAll(Predicado);

            // Another way to delete: Delegate
            // escuela.Cursos.RemoveAll(delegate(Curso cur){return cur.Nombre == "301";} );

            // Another way to delete: Lambda functions
            //escuela.Cursos.RemoveAll((cur)=> cur.Nombre == "501" && cur.Jornada == TiposJornada.Morning);
            
            Printer.WriteTitle("Bienvenidos a la escuela");
            ImprimirCursosEscuela(engine.Escuela);

        }
        private static void ImprimirCursosEscuela(Escuela escuela)
            {

                Printer.WriteTitle("Cursos escuela");


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
