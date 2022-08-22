using System.Collections.Generic;
using CoresEscuela.Entidades;

namespace CoresEscuela
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }

        // constructor

        public EscuelaEngine()
        {
            
        }

        public void Inicializar()
        {
            Escuela = new Escuela("school 1", 2022, TiposEscuela.Primaria, pais:"MX", ciudad: "TLX" );
            Escuela.Cursos = new List<Curso>(){
                new Curso(){Nombre = "101",Jornada = TiposJornada.Morning},
                new Curso(){Nombre = "201",Jornada = TiposJornada.Morning},
                new Curso(){Nombre = "301",Jornada = TiposJornada.Morning},
                new Curso(){Nombre = "401",Jornada = TiposJornada.afternoon},
                new Curso(){Nombre = "501",Jornada = TiposJornada.afternoon},
            };
        }

    }


}