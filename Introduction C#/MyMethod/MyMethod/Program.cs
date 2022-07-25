using System;

namespace MyMethod
{
    class Methods
    {
        public void IntegerAddition(int a, int b)
        {
            int Addition = a + b;
            Console.WriteLine("El resultado es " + Addition);
        }

        public int IntegerMultiplication(int a, int b)
        {
            int Multiplication = a * b;
            return Multiplication;
        }
    }
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Methods MyProgram = new Methods();
            MyProgram.IntegerAddition(3, 6);

            int result = MyProgram.IntegerMultiplication(12, 2);
            Console.WriteLine("El resultado de la multiplicación es " + result);

        }
    }
}

