using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableDemo01
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        /// <summary>
        /// 如果 x >=y true;
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        private Boolean Compare(Int32 x, Int32 y)
        {
            if (x >= y)
            { return true; }
            else
            { return false; }
        }

        private Boolean Compare(Byte x, Byte y)
        {
            if (x >= y)
            { return true; }
            else
            { return false; }
        }

        private Boolean Compare(Double x, Double y)
        {
            if (x >= y)
            { return true; }
            else
            { return false; }
        }
    }
}
