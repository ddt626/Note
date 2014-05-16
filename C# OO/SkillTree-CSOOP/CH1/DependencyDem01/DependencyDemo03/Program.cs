using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyDemo03
{
    //建構子注入
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    interface ICar
    {
        void Run();
    }

    public class Benz : ICar
    {

        public void Run()
        {
            Console.WriteLine("Benz Run");
        }
    }

    public class BMW : ICar
    {
        public void Run()
        {
            Console.WriteLine("BMW Run");
        }
    }

    public class Driver
    {
        private ICar _car;
        public Driver(ICar car)
        {
            _car = car;
        }

        public void Run()
        {
            _car.Run(); 
        }
    }
}
