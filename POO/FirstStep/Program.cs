// See https://aka.ms/new-console-template for more information
using CoreEscuela.Entidades;

var escuela = new Escuela("school1",2022);
escuela.Pais = "Mx";
escuela.Ciudad = "Pue";
escuela.TipoEscuela = TiposEscuela.Primaria;
Console.WriteLine(escuela);
