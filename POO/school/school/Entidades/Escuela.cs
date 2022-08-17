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

        public Escuela(string nombre, int year) => (Nombre, YearOfCreation) = (nombre,year);

    }
}