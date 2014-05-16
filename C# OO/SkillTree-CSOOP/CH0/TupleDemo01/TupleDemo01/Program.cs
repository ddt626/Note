using System;
using System.Collections.Generic;
using System.Text;

namespace TupleDemo01
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "ABC";
            double d = 7.9;
            Tuple<string ,double,Boolean > para=  Tuple.Create(s,d,false );
            Show(para);
            Console.ReadLine();
        }

        public static void Show(Tuple<string,double,bool > value)
        {
            Console.WriteLine(value.Item1 + value.Item2.ToString());
           
        }
    }
}
