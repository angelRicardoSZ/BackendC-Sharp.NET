// See https://aka.ms/new-console-template for more information
using Humanizer;

Console.WriteLine("Ingrese nombre");
var nombre = Console.ReadLine();
Console.WriteLine("Ingrese cargo");
var cargo = Console.ReadLine();
Console.WriteLine("Ingrese edad en años");
var edad = int.Parse(Console.ReadLine());

Console.WriteLine($"Mi nombre es {nombre}, mi cargo es {cargo} y tengo {edad.ToWords()} años");
