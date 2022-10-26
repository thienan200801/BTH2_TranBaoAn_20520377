using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Row: ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Col: ");
            int col = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("a. Print the matrix: ");
            Utils matrix = new Utils(row, col);
            matrix.Input();
            matrix.Print();

            Console.Write("b. Item that you want to find: ");
            int itemToFind = int.Parse(Console.ReadLine());
            Console.Write(matrix.FindItem(itemToFind));
            Console.WriteLine();

            Console.Write("c. Print prime numbers in the array: ");
            matrix.printPrimeNumber();
            Console.WriteLine();

            Console.Write("d. Row contains max prime number: ");
            List<int> res = matrix.containMaxPrime();
            for(int i = 0; i < res.Count; i++)
            {
                Console.Write(res[i] + "\t");
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
