using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDemo7
{
    class Program
    {
        static void Main(string[] args)
        {
            SomeBase s = new Derived1();
            s.Test();
            ((Derived1)s).Test(1);
            Console.ReadLine();
        }
    }
}
