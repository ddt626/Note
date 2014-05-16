using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDemo01
{

    class Program
    {
        static void Main(string[] args)
        {

           
            BMIBridge bridge = new BMIBridge();
            bridge.Measurement = new Human();
            bridge.Measurement.Height = 1.72;
            bridge.Measurement.Weight = 58;
 
            bridge.BMIValue = new BMIValue();
            bridge.Comment = new ManBMIComment();

            Console.WriteLine(bridge.GetBMI());
            Console.WriteLine(bridge.GetComment());

            Console.WriteLine("===換成女生===");
            bridge.Comment = new WomanBMIComment();
            Console.WriteLine(bridge.GetComment());

            Console.WriteLine("===換成豬===");
            bridge.Comment = new PigBMIComment();
            Console.WriteLine(bridge.GetComment());


            Console.ReadLine();






        }
    }
}
