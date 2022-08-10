using System;

namespace school
{
    internal class Program
    {   
        class CoreEscuela
        {
            public string nombre;

            public string direccion;

        }
        static void Main(string[] args)
        {
            var miEscuela = new CoreEscuela();

            miEscuela.nombre = "School1";

            miEscuela.direccion = "street";




        }
    }
}
