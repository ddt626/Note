using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDemo01
{
    class Program
    {
        static void Main(string[] args)
        {
            Coupe coupe = new Coupe();
            Truck truck = new Truck(10);
            Fighter fighter = new Fighter();
            Console.ReadLine(); 
        }
    }
}
