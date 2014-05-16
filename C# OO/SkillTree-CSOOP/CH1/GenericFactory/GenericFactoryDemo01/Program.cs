using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericFactoryDemo01
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = GenericFactory.CreateInastance<GenericLibrary01.Class1>("GenericLibrary01", "GenericLibrary01.Class1");
            Console.WriteLine(c.GetType().ToString());

            Console.ReadLine();
        }
    }
}
