namespace CoreEscuela.Entidades
{
    class Escuela
    {
        string nombre;

        public string Nombre
        {
            get{return nombre;}
            set{nombre = value.ToUpper();}
        }
        public int AnnioCreacion {get;set;}

        public string Pais{get;set;} 
        public string Ciudad{get;set;}

        public TiposEscuela TipoEscuela{get;set;}
        
        public Escuela(string nombre, int annio) => (Nombre, AnnioCreacion) = (nombre,annio);

        public Escuela(string nombre, int annio, TiposEscuela tipo, string pais = "", string ciudad = "")
        {
            (Nombre, AnnioCreacion) = (nombre,annio);
            Pais = pais;
            Ciudad = ciudad;

        }

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Tipo: {TipoEscuela} \nPais:{Pais}, Ciudad: {Ciudad} ";
        }
    }
}