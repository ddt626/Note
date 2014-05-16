using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOCDemo01
{
    class Program
    {
        static void Main(string[] args)
        {
            //非 IOC 呼叫, 上層類別 (Program) 直接倚賴實作, 而且由 Program 決定實做類別
            NoneIOC.Benz car = new NoneIOC.Benz();
            car.WhoIs();

            // IOC 呼叫,上層類別 (Program) 倚賴 ICar 介面, 由 CarFactory 決定實做類別, Program 無法得知有哪些類別實作的 ICar 
            IOC.ICar ioccar = IOC.CarFactory.GetCar("BMW");
            ioccar.WhoIs(); 

            Console.ReadLine();
        }
    }
}
