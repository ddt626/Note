using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyDemo01
{
    public class Class1
    {
        private int x = 0;

        public int GetX()
        { return x; }

        public void SetX(int value)
        { x = value; }
    }

    public class Class2
    {
        private int x = 0;
        public int X
        {
            get { return x; }
            set { x = value; }
        }
    }
}
