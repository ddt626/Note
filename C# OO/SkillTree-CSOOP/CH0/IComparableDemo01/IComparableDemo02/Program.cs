using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableDemo02
{
    class Program
    {
        static void Main(string[] args)
        {
           Int32 x = 1;
            Int32 y = 2;
            Console.WriteLine(Compare(x, y));
            Double m = 3.2;
            Double n = 1.79;
            Console.WriteLine(Compare2(m, n));
            Console.ReadLine(); 
        }

        private static Boolean Compare<T>(T x, T y) 
            where T : IComparable<T>
        {
            if (x.CompareTo(y) >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static Boolean Compare2<T>(IComparable<T> x, T y)
        {

            if (x.CompareTo(y) >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
