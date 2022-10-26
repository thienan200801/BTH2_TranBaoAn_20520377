using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Q3
{
    class Utils
    {
        private int row, col;
        private int[,] data;
        public Utils(int r, int c)
        {
            this.row = r;
            this.col = c;
            data = new int[row, col];
        }
        public void Input()
        {
            Console.WriteLine("Matrix's items are generated randomly");

            var rand = new Random();
            for (int i = 0; i < this.row; i++)
            {
                for (int j = 0; j < this.col; j++)
                {
                    data[i, j] = rand.Next(0, 10);
                }
            }
            
        }
        public void Print()
        {
            for(int i = 0; i<this.row; i++)
            {
                for(int j=0; j<this.col; j++)
                {
                    Console.Write(data[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        public int FindItem(int item)
        {
            int id = -1;

            for(int i=0; i<this.row; i++)
            {
                for(int j=0; j<this.col; j++)
                {
                    if (data[i, j] == item) id = i * this.col + j;
                }
            }
            return id;
        }

        public bool isPrimeNumber(int n)
        {
            if (n < 2) return false;
            if (n == 2) return true;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        public void printPrimeNumber()
        {
            for(int i=0; i < this.row; i++)
            {
                for(int j=0; j<this.col; j++)
                {
                    if(isPrimeNumber(data[i, j])) Console.Write(data[i, j] + "\t");
                }
            }
        }

        public List<int> containMaxPrime()
        {
            int count, maxPrime = -1;
            int maxRow = -1;
            List<int> res = new List<int>();

            List<int> countPrime = new List<int>();

            for(int i=0; i<this.row; i++)
            {
                count = 0;
                for(int j=0; j<this.col; j++)
                {
                    //Console.WriteLine("aaaa: "+data[i, j]);
                    if(isPrimeNumber(data[i, j])) count++;
                }
                countPrime.Add(count);
                if (count > maxPrime)
                {
                        maxPrime = count;
                        maxRow = i;
                }
            }
            res.Add(maxRow);
            for (int i = 0; i < countPrime.Count; i++)
            {
                if (countPrime[i] == maxPrime && i != maxRow) res.Add(i); 
            }

            return res;
        }
    }
}
