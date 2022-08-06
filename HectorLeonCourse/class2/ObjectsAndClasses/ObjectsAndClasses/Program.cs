using System;
using ObjectsAndClasses.Models;
namespace ObjectsAndClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bebida bebida = new Bebida("Pepsi",1200);
            bebida.Beberse(120);
            Console.WriteLine(bebida.Cantidad);

            Cerveza cerveza = new Cerveza("XX",100);
            cerveza.Beberse(10);
            Console.WriteLine(cerveza.Cantidad);
        }
    }
}
