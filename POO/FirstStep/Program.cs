// See https://aka.ms/new-console-template for more information
using CoreEscuela.Entidades;
using static System.Console;

var escuela = new Escuela("school1",2022,TiposEscuela.Primaria,pais:"MX", ciudad:"Pue");

escuela.Cursos = new Curso[] {
    new Curso(){Nombre = "101"},
    new Curso(){Nombre = "201"},
    new Curso(){Nombre = "301"}
};

ImprimirCursosEscuela(escuela);


static void ImprimirCursosEscuela(Escuela escuela)
{
    WriteLine("-----------");
    WriteLine("Cursos de la escuela");
    WriteLine("-----------");

    if( escuela?.Cursos != null)
    {
        foreach (var curso in escuela.Cursos)
        {
            WriteLine($"Nombre {curso.Nombre}, Id {curso.UniqueId}");
        }    
    }
    
};