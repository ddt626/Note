using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDemo02
{
    // 明確實作介面範例
    class Program
    {
        static void Main(string[] args)
        {
            ImplementIPublicProtectedX x = new ImplementIPublicProtectedX();
            Console.WriteLine(x.GetString());
            Console.WriteLine(((IProtected)x).GetString());


            ImplementIPublic obj = new ImplementIPublic();
            ((IPublic)obj).GetString();
            Console.ReadLine();
        }
    }
}
