using System;
using System.Collections.Generic;
using System.Text;

namespace newMethodDemo01
{
    public class BaseType
    {
        public void Show()
        {
            Console.WriteLine("BaseType"); 
        }
    }

    public class Derived1 : BaseType
    {
        new public void Show()
        {
            Console.WriteLine("Derived1");
        }
    }

    public class VBaseType
    {
        public virtual void Show()
        {
            Console.WriteLine("VBaseType");
        }
    }  

    public class VDerived2 : VBaseType
    {
        public override void Show()
        {
            Console.WriteLine("VDerived2");
        }
    }

    public class VDerived1 : VBaseType
    {
        new public void Show()
        {
            Console.WriteLine("VDerived1");
        }
    }
}
