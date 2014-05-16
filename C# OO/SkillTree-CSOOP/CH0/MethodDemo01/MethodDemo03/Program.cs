using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDemo03
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
            Console.WriteLine("y 實體中的 x 的初始值為 " + y.x.ToString());
            ChangeX(y);
            Console.WriteLine("推出 ChangeX 方法回到 Main 方法後,y 實體中的 x 的值為 " + y.x.ToString());
            Console.ReadLine();
        }

        private static TestClass ChangeX(TestClass y)
        {
            Console.WriteLine("進入 ChangeX 方法的時候, y 實體中的 x 的值為 " + y.x.ToString());
            y.x = 10;
            Console.WriteLine("在 ChangeX 方法重新指派後,y 實體中的 x 的值為 " + y.x.ToString());
            y = new TestClass();
            Console.WriteLine("在 ChangeX 方法重新產生 TestClass 的實體後,y 實體中的 x 的值為 " + y.x.ToString());
            return y;
        }
    }
}
