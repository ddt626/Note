using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDemo7
{
    public class SomeBase
    {
        public virtual void Test()
        {
            Console.WriteLine("SomeBase");
        }
    }

    public class Derived1 : SomeBase
    {
        public override void Test()
        {
            Console.WriteLine("Derived1");
        }

        public void Test(int x)
        {
            Console.WriteLine("Derived1 overloading");
        }

     
    }


}
