using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyInstance01
{
    class Program
    {
        static void Main(string[] args)
        {
            //load by assembly string
            Assembly asm = Assembly.Load("TestLibrary02");
            Object obj = asm.CreateInstance("TestLibrary02.Class1");
            Console.WriteLine(obj.GetType().ToString());

            Console.ReadLine();
        }
    }
}
