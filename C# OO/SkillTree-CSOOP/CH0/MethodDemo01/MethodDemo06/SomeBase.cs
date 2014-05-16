using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDemo06
{
    public abstract class SomeBase
    {
        public abstract void Test();
    }

    public class Derived1 : SomeBase 
    {

        public override void Test()
        {
            Console.WriteLine("Derived 1");
        }
    }

    public class Derived2 : Derived1
    {
        public override  void Test()
        {
            Console.WriteLine("Derived 2");
        }
    }

    public class Derived3 : Derived2
    {
        public override sealed  void Test()
        {
            Console.WriteLine("Derived 3");
        }
    }

    // 試著覆寫 sealed
   

  
}
