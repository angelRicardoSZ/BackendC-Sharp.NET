using System;
using System.Collections.Generic;

namespace ArrayAndLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }


            List<int> lista = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7 };
            foreach(var item in lista)
            {
                Console.WriteLine(item);
            }


            
        }
    }
}
