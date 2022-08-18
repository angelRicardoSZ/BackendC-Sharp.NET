using System.Collections.Generic;

namespace CoresEscuela.Entidades
{
    class Escuela
    {
        string nombre;

        public string Nombre
        {
            get { return "Copia:" + nombre; }
            set { nombre = value.ToUpper(); }
        }

        public int YearOfCreation { get; set; }

        public string Pais { get; set; }

        public string Ciudad { get; set; }
        public TiposEscuela TipoEscuela {get; set;}
        public List<Curso> Cursos {get; set;}
        public Escuela(string nombre, int year) => (Nombre, YearOfCreation) = (nombre,year);
        public Escuela(string nombre, int year, TiposEscuela tipo, string pais = "", string ciudad = "")
        {
            (Nombre, YearOfCreation) = (nombre,year);
            Pais = pais;
            Ciudad = ciudad;
        }

        public override string ToString()
        {
            return $"Nombre: \"{Nombre}\", Tipo: {TipoEscuela} \nPais: {Pais}, Ciudad: {Ciudad}";
        }
    }
}