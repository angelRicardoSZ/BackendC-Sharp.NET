// See https://aka.ms/new-console-template for more information
using CoreEscuela.Entidades;

var escuela = new Escuela("school1",2022);
escuela.Pais = "Mx";
Console.WriteLine(escuela.Nombre);
