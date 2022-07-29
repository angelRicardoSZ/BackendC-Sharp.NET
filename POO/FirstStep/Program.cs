// See https://aka.ms/new-console-template for more information
using CoreEscuela.Entidades;

using System.Collections.Generic;
using static System.Console;

var engine = new EscuelaEngine();
engine.Inicializar();




ImprimirCursosEscuela(engine.Escuela);


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