using System;
using System.Collections.Generic;
using Interfaces.Models;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var bebidaAlcoholica = new Vino(100);

            Console.WriteLine("Vino");
            MostrarRecomendacion(bebidaAlcoholica);

            var bebidaAlcoholica2 = new Cerveza(100);
            Console.WriteLine("Cerveza");
            MostrarRecomendacion(bebidaAlcoholica2);

            List<string> hola = new List<string>();
        }

        static void MostrarRecomendacion(IBebidaAlcoholica bebida)
        {
            bebida.MaxRecomendado();
        }
    }
}
