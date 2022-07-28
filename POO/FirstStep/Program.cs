// See https://aka.ms/new-console-template for more information
using CoreEscuela.Entidades;
using System.Collections.Generic;
using static System.Console;

var escuela = new Escuela("school1",2022,TiposEscuela.Primaria,pais:"MX", ciudad:"Pue");

escuela.Cursos = new List<Curso>(){
    new Curso(){Nombre = "101", Jornada = TiposJornada.Manana},
    new Curso(){Nombre = "201", Jornada = TiposJornada.Manana},
    new Curso(){Nombre = "301", Jornada = TiposJornada.Manana}
};

escuela.Cursos.Add(new Curso(){Nombre = "102", Jornada = TiposJornada.Noche});
escuela.Cursos.Add(new Curso(){Nombre = "202", Jornada = TiposJornada.Noche});

var otraColeccion = new List<Curso>(){
    new Curso(){Nombre = "401", Jornada = TiposJornada.Manana},
    new Curso(){Nombre = "501", Jornada = TiposJornada.Manana},
    new Curso(){Nombre = "502", Jornada = TiposJornada.Manana}
};
Curso tmp = new Curso{Nombre="601",Jornada=TiposJornada.Noche };
escuela.Cursos.AddRange(otraColeccion);
escuela.Cursos.Add(tmp);
ImprimirCursosEscuela(escuela);
escuela.Cursos.Remove(tmp);

escuela.Cursos.RemoveAll(delegate (Curso cur){
    return cur.Nombre == "301";
});

// lambda 
escuela.Cursos.RemoveAll((cur)=> cur.Nombre == "501"); 


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