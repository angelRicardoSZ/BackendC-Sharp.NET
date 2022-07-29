using CoreEscuela.Entidades;

namespace CoreEscuela
{
    public class EscuelaEngine
    {
        public Escuela Escuela{get; set;}

        public EscuelaEngine()
        {
            
        }

        public void Inicializar()
        {
            Escuela = new Escuela("school1",2022,TiposEscuela.Primaria,pais:"MX", ciudad:"Pue");

            Escuela.Cursos = new List<Curso>(){
            new Curso(){Nombre = "101", Jornada = TiposJornada.Manana},
            new Curso(){Nombre = "201", Jornada = TiposJornada.Manana},
            new Curso(){Nombre = "301", Jornada = TiposJornada.Manana}
            };

            
        }
    }
}