// See https://aka.ms/new-console-template for more information
using CoreEscuela.Entidades;

var escuela = new Escuela("school1",2022,TiposEscuela.Primaria,pais:"MX", ciudad:"Pue");

var curso1 = new Curso() {
    Nombre="101",
};

var curso2 = new Curso() {
    Nombre="201",
};

var curso3 = new Curso() {
    Nombre="301",
};

Console.WriteLine(escuela);
System.Console.WriteLine("-----------");
Console.WriteLine(curso1.Nombre + ", "+ curso1.UniqueId);

Console.WriteLine($"{curso2.Nombre}, {curso2.UniqueId}" );

Console.WriteLine(curso3);

