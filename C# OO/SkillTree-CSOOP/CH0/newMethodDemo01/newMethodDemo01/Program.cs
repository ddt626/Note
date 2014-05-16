using System;
using System.Collections.Generic;
using System.Text;

namespace newMethodDemo01
{
    class Program
    {
        static void Main(string[] args)
        {
            Derived1 derived1 = new Derived1();
            derived1.Show();
            BaseType basetype = derived1;
            basetype.Show();

            //VDerived1 vderived1 = new VDerived1();
            //vderived1.Show();
            //VBaseType vbasetype = vderived1;
            //vbasetype.Show();

            //VDerived2 vderived2 = new VDerived2();
            //vderived2.Show();
            //VBaseType vbasetype2 = vderived2;
            //vbasetype2.Show();


            Console.ReadLine();
        }
    }
}
