using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BTH2_TranBaoAn_20520377
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int main()
            {
                int month, year;
                Console.Write("Month: ");
                month = int.Parse(Console.ReadLine());
                Console.Write("Year: ");
                year = int.Parse(Console.ReadLine());
                if (year < 1582)
                {
                    Console.WriteLine("Nam khong hop le! Nam bat dau tu 1582");
                    return 1;
                }
                if (month < 1 || month > 12)
                {
                    Console.WriteLine("Thang khong hop le");
                    return 2;
                }
                int date = 31;
                switch (month)
                {

                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        date = 30;
                        break;
                    case 2:
                        date = ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0)) ? 29 : 28;
                        break;
                }

                int tmp = 1;
                int extra = (14 - month) / 12;
                int y = year - extra;
                int m = month + 12 * extra - 2;
                int dateOfWeek = (tmp + y + y / 4 - y / 100 + y / 400 + (31 * m) / 12) % 7;
                Console.WriteLine("S\t"+"M\t"+"T\t"+"W\t"+"T\t"+"F\t"+"S");
                for (int i = 0; i < 7; i++)
                    if (i < dateOfWeek)
                        Console.Write("\t");
                    else
                        Console.Write(tmp++ + "\t");
                Console.Write("\n");
                do
                {
                    for (int i = 0; i < 7; i++)
                        if (tmp <= date)
                            Console.Write(tmp++ + "\t");
                    Console.Write("\n");
                } while (tmp <= date);

                Console.ReadLine();

                return 0;
            }
            main();
        }
    }
}
