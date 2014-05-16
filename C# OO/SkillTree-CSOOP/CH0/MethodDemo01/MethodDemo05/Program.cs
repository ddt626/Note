using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDemo05
{
    class Program
    {
        public class TestClass
        {
            public int x = 0;
        }
        static void Main(string[] args)
        {
            TestClass y = new TestClass();
            TestClass r1 = ChangeByVal(y);
            Console.WriteLine("r1 和 y 指向同實體 : " + (r1 == y).ToString());
            TestClass r2 = ChangeByRef(ref y);
            Console.WriteLine("r2 和 y 指向同實體 : " + (r2 == y).ToString());
            Console.ReadLine();
        }

        private static TestClass ChangeByVal(TestClass y)
        {
            y = new TestClass();
            return y;
        }

        private static TestClass ChangeByRef(ref TestClass y)
        {
            y = new TestClass();
            return y;
        }


    }
}
