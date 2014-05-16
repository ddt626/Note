using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainInstanceDemo01
{
    class Program
    {
        static void Main(string[] args)
        {
            Object obj1 = AppDomain.CurrentDomain.CreateInstanceAndUnwrap("TestLibrary01", "TestLibrary01.Class1");
            Console.WriteLine(obj1.GetType().ToString());
            Console.WriteLine("============================");
            Object obj2 = AppDomain.CurrentDomain.CreateInstanceAndUnwrap("TestLibrary02", "TestLibrary02.Class2");
            Console.WriteLine(obj2.GetType().ToString());
            Console.WriteLine("============================");
            ObjectHandle objhandle = AppDomain.CurrentDomain.CreateInstance("TestLibrary02", "TestLibrary02.Class2");
            Console.WriteLine(objhandle.GetType().ToString());
            Console.WriteLine(objhandle.Unwrap().GetType().ToString());

            Console.ReadLine();

        }
    }
}
