using System;
using System.Collections.Generic;
using System.Linq;
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
            Escuela = new Escuela("school 1", 2022, TiposEscuela.Primaria, pais: "MX", ciudad: "TLX");
            cargarCursos();
            cargarAsignaturas();

            cargarEvaluaciones();
        }

        private void cargarEvaluaciones()
        {
            throw new NotImplementedException();
        }

        private void cargarAsignaturas()
        {
            foreach (var curso in Escuela.Cursos)
            {
                List<Asignatura> listaAsignaturas = new List<Asignatura>(){
                    new Asignatura{Nombre="Matemáticas"} ,
                    new Asignatura{Nombre="Educación Física"},
                    new Asignatura{Nombre="Castellano"},
                    new Asignatura{Nombre="Ciencias Naturales"}
                } ;
                curso.Asignaturas= listaAsignaturas;
            }
        }

        private List<Alumno> generarAlumnos( int cantidad)
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };

            var listaAlumnos =  from n1 in nombre1
                                from n2 in nombre2
                                from a1 in apellido1
                                select new Alumno{Nombre=$"{n1} {n2} {a1}"} ;
            return listaAlumnos.OrderBy((al)=>al.UniqueId ).Take(cantidad).ToList();
        }

        private void cargarCursos()
        {
            Escuela.Cursos = new List<Curso>(){
                new Curso(){Nombre = "101",Jornada = TiposJornada.Morning},
                new Curso(){Nombre = "201",Jornada = TiposJornada.Morning},
                new Curso(){Nombre = "301",Jornada = TiposJornada.Morning},
                new Curso(){Nombre = "401",Jornada = TiposJornada.afternoon},
                new Curso(){Nombre = "501",Jornada = TiposJornada.afternoon},
            };
            Random rnd = new Random();
            
            foreach (var curso in Escuela.Cursos)
            {
                int cantidadRandom = rnd.Next(5,20);
                curso.Alumnos= generarAlumnos(cantidadRandom);
            }
        }
    }


}