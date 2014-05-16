using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BoxingDemo01
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            object o = i;
            i.GetType();
            i.CompareTo(11);
            ((IComparable)i).CompareTo(12);
            ((IComparable<int>)i).CompareTo(13);
            ArrayList list = new ArrayList();
            list.Add(i);
          
        }
    }
}
