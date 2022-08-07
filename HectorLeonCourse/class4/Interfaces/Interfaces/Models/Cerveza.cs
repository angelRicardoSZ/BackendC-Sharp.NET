using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Models
{
    class Cerveza : Bebida, IBebidaAlcoholica
    {
        public int Alcohol { get; set; }
        public void MaxRecomendado()
        {
            Console.WriteLine("El máximo permitido son 10 copas");
        }
        public Cerveza( int Cantidad, string Name="cerveza")
            : base(Name, Cantidad)
        {

        }
    }
}
