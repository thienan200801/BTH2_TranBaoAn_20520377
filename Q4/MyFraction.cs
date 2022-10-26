using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Q4
{
    class MyFraction
    {
        private int numerator;
        private int denominator;

        public MyFraction(int numerator = 0, int denominator = 1)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }
        public void Print(string s = "")
        {
            Console.Write(this.numerator + "/" + this.denominator + s);
        }
        public int LCM(int a, int b)
        {
            int temp = a % b;
            while (temp != 0)
            {
                a = b;
                b = temp;
                temp = a % b;
            }
            return b;
        }
        public void Reduce()
        {
            int lcm = LCM(numerator, denominator);
            numerator /= lcm;
            denominator /= lcm;
        }

        public static MyFraction operator +(MyFraction A, MyFraction B)
        {
            MyFraction Result = new MyFraction();
            Result.numerator = A.numerator * B.denominator + A.denominator * B.numerator;
            Result.denominator = A.denominator * B.denominator;
            Result.Reduce();
            return Result;
        }

        public static MyFraction operator -(MyFraction A, MyFraction B)
        {
            MyFraction Result = new MyFraction();
            Result.numerator = A.numerator * B.denominator - A.denominator * B.numerator;
            Result.denominator = A.denominator * B.denominator;
            Result.Reduce();
            return Result;
        }

        public static MyFraction operator *(MyFraction A, MyFraction B)
        {
            MyFraction Result = new MyFraction();
            Result.numerator = A.numerator * B.numerator;
            Result.denominator = A.denominator * B.denominator;
            Result.Reduce();
            return Result;
        }
        public static MyFraction operator /(MyFraction A, MyFraction B)
        {
            MyFraction Result = new MyFraction();
            Result.numerator = A.numerator * B.denominator;
            Result.denominator = A.denominator * B.numerator;
            return Result;
        }
        public static bool operator >(MyFraction A, MyFraction B)
        {
            return A.numerator / (double)A.denominator > B.numerator / (double)B.denominator;
        }

        public static bool operator <(MyFraction A, MyFraction B)
        {
            return A.numerator / (double)A.denominator < B.numerator / (double)B.denominator;
        }

        public static implicit operator string(MyFraction a)
        {
            return (a.numerator + "/" + a.denominator);
        }
        public static MyFraction MaxItem(MyFraction[] fracArr)
        {
            MyFraction maxNumber = fracArr[0];
            for(int i=1; i< fracArr.Length; i++)
            {
                if (fracArr[i] > maxNumber) {
                    maxNumber = fracArr[i];
                }
            }
            return maxNumber;
        }

        public static MyFraction[] Sort(MyFraction[] fracArr) {
            for (int i = 0; i < fracArr.Length - 1; i++)
            {
                for (int j = 0; j < fracArr.Length - i - 1; j++) {
                    if (fracArr[j] > fracArr[j+1]) { 
                        MyFraction tmp = fracArr[j];
                        fracArr[j] = fracArr[j+1];
                        fracArr[j+1] = tmp;
                    }
                }
            }
            return fracArr;
        }
    }
}
