using System;
using System.Collections.Generic;
using System.Text;
using ModifilerLibrary;

namespace TypeModifilerDemo01
{
    class Program
    {
        static void Main(string[] args)
        {
           

            IPublic obj = PublicFactory.GetInstance("class1");
            Console.WriteLine(obj.WhoIs());

            Console.ReadLine(); 
        }
    }
}
