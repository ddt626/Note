using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDemo01
{
    class Program
    {
        
        static void Main(string[] args)
        {
            ImplementIPublic obj = new ImplementIPublic();
            IPublic x = obj;
            obj.GetString();
            x.GetString();
        }
    }
}
