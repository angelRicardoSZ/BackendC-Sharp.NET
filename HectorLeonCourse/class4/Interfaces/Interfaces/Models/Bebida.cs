using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Models
{
    class Bebida
    {
        public string Name { get; set; }

        public int Cantidad { get; set; }

        public Bebida(string Name, int Cantidad)
        {
            this.Name = Name;
            this.Cantidad = Cantidad;
        }

        public void Beberse(int CuantoBebio)
        {
            this.Cantidad -= CuantoBebio;
        }
    }
}
