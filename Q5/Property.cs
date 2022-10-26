using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Q5
{
    namespace NBatDongSan
    {
        public abstract class BatDongSan
        {
            protected BatDongSan(string location = "", int price = 0, int area = 0)
            {
                Location = location;
                Price = price;
                Area = area;
            }

            public string Location { get; set; }
            public int Price { get; set; }
            public int Area { get; set; }

            public abstract void Input();
            public abstract void Print();
        }
        public class DatDai : BatDongSan
        {
            public DatDai(string location = "", int price = 0, int area = 0) : base(location, price, area) { }

            public override void Input()
            {
                Console.Write("Location: ");
                Location = Console.ReadLine();
                Console.Write("Price: ");
                Price = Convert.ToInt32(Console.ReadLine());
                Console.Write("Area: ");
                Area = Convert.ToInt32(Console.ReadLine());
            }
            public override void Print()
            {
                Console.WriteLine("Dat dai: Location: {0}, Price: {1}, Area: {2}", Location, Price, Area);
            }
        }

        public class NhaPho : BatDongSan
        {
            public int Year { get; set; }
            public int Floor { get; set; }
            public NhaPho(string location = "", int price = 0, int area = 0, int year = 0, int floor = 0) : base(location, price, area)
            {
                Year = year;
                Floor = floor;
            }

            public override void Input()
            {
                Console.Write("Location: ");
                Location = Console.ReadLine();
                Console.Write("Price: ");
                Price = Convert.ToInt32(Console.ReadLine());
                Console.Write("Area: ");
                Area = Convert.ToInt32(Console.ReadLine());
                Console.Write("Year: ");
                Year = Convert.ToInt32(Console.ReadLine());
                Console.Write("Floor: ");
                Floor = Convert.ToInt32(Console.ReadLine());
            }
            public override void Print()
            {
                Console.WriteLine("Nha pho: Location: {0}, Price: {1}, Area: {2}, Year: {3},Floor: {4}", Location, Price, Area, Year, Floor);
            }
        }

        public class ChungCu : BatDongSan
        {
            public int Floor { get; set; }
            public ChungCu(string location = "", int price = 0, int area = 0, int floor = 0) : base(location, price, area)
            {
                Floor = floor;
            }

            public override void Input()
            {
                Console.Write("Location: ");
                Location = Console.ReadLine();
                Console.Write("Price: ");
                Price = Convert.ToInt32(Console.ReadLine());
                Console.Write("Area: ");
                Area = Convert.ToInt32(Console.ReadLine());
                Console.Write("Floor: ");
                Floor = Convert.ToInt32(Console.ReadLine());
            }
            public override void Print()
            {
                Console.WriteLine("Chung cu: Location: {0}, Price: {1}, Area: {2},Floor: {3}", Location, Price, Area, Floor);
            }
        }

    }
}
