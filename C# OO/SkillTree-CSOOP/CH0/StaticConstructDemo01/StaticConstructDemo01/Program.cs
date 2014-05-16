using System;
using System.Collections.Generic;
using System.Text;

namespace StaticConstructDemo01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Class1._y);
            Class1.GetW(new Class1 ());
            Console.ReadLine(); 
        }
    }
}
