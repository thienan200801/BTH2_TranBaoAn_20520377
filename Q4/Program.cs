using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Q4
{
    class Program: MyFraction
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Question 4.a");
            Console.Write("A.numerator: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("A.denominator: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("B.numerator: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write("B.denominator: ");
            int d = Convert.ToInt32(Console.ReadLine());

            MyFraction A = new MyFraction(a, b);
            MyFraction B = new MyFraction(c, d);

            Console.WriteLine((string)A + " + " + (string)B + " = " + (string)(A + B));
            Console.WriteLine((string)A + " - " + (string)B + " = " + (string)(A - B));
            Console.WriteLine((string)A + " * " + (string)B + " = " + (string)(A * B));
            Console.WriteLine((string)A + " / " + (string)B + " = " + (string)(A / B));

            Console.WriteLine("Question 4.b");
            Console.WriteLine("Numbers of fractions: ");
            int n = Convert.ToInt32(Console.ReadLine());
            MyFraction[] fractionsList = new MyFraction[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} numerator: ", i);
                int tmp1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("{0} denominator: ", i);
                int tmp2 = Convert.ToInt32(Console.ReadLine());
                fractionsList[i] = new MyFraction(tmp1, tmp2);
            }

            for(int i = 0; i < n; i++)
            {
                fractionsList[i].Print();
                Console.WriteLine();
            }

            MyFraction maxNum = MyFraction.MaxItem(fractionsList);
            Console.WriteLine("Max of arrays = ");
            maxNum.Print();

            Console.WriteLine("\n Sorted array = ");
            MyFraction[] sorted = MyFraction.Sort(fractionsList);

            for (int i = 0; i < n; i++)
            {
                sorted[i].Print();
                Console.WriteLine();
            }

            Console.ReadLine();



        }
    }
}
