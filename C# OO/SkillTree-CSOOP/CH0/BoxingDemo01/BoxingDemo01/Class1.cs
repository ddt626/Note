using System;
using System.Collections.Generic;
using System.Text;

namespace BoxingDemo01
{
    class Class1
    {
        private int _x = 0;
        public int X
        { get { return _x; } }

        
        public int Y
        { get; protected set; }

        public void Test(out object  value)
        {
            value = new Object();
            T1("a", "b", "c");
            
        }

        public void T1 (params string[] x)
        {

        }
    }
}
