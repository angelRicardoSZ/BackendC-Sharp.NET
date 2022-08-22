using static System.Console;

namespace CoresEscuela.Util
{
    public static class Printer
    {
        public static void DibujarLinea(int tam = 10)
        {
            var linea = "".PadLeft(tam,'=');
            WriteLine(linea);

        }


        public static void WriteTitle(string titulo)
        {
            int tam =  titulo.Length +4;
            DibujarLinea(tam);
            WriteLine($"| {titulo} |");
            DibujarLinea(tam);

        }
    }

}