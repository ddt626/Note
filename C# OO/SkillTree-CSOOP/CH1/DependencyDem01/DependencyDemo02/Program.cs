using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyDemo02
{
    //介面注入
    class Program
    {
        static void Main(string[] args)
        {
            Driver sam = new Driver();
            sam.Drive(new Benz()); 
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

    public class BMW :ICar
    {
        public void Run()
        {
            Console.WriteLine("BMW Run");
        }
    }

    /// <summary>
    /// 使用 abstract class 效果差不多
    /// </summary>
    interface IDriver
    {
        /// <summary>
        /// 倚賴 ICar 而非實做類別
        /// </summary>
        /// <param name="car"></param>
        void Drive(ICar car);
    }

    public class Driver : IDriver 
    {
        public void Drive(ICar car)
        {
            car.Run();
        }
    }
}
