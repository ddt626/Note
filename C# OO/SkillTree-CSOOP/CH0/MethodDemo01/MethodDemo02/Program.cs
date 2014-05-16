using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDemo02
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            Console.WriteLine("x 的初始值為 " + x.ToString());
            int y = ChangeX(ref x);
            Console.WriteLine("推出 ChangeX 方法回到 Main 方法後, x 的值為 " + x.ToString());
            Console.ReadLine();
        }

        private static int ChangeX(ref int x)
        {
            Console.WriteLine("進入 ChangeX 方法的時候, x 的值為 " + x.ToString());
            x = 10;
            Console.WriteLine("在 ChangeX 方法重新指派後, x 的值為 " + x.ToString());
            return x;
        }
    }
}
