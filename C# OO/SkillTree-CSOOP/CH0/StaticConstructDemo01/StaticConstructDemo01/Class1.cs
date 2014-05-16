using System;
using System.Collections.Generic;
using System.Text;

namespace StaticConstructDemo01
{
    public class Class1
    {

        private static Int32 _x;
        public static String _y;
        static Class1()
        {
            _x = 1;
            _y = "ABC";

        }

        public int _w;

        public static int GetW(Class1 obj)
        {
            return obj._w;
        }
    }
}
