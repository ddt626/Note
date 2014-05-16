using SimpleLibrary04;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryDemo04
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human() { Age = 19, Gender = GenderType.Woman, Height = 1.72, Weight = 58 };

            BMIStrategy bmistrategy = BMIStrategyFactory.GetStrategy(human);         
            Console.WriteLine(bmistrategy.BMI.ToString());
            Console.WriteLine(bmistrategy.Result);

            Console.WriteLine();

            StandardWightStrategy standardweightstrategy = StandardWightStrategyFactory.GetStrategy(human);
            Console.WriteLine(standardweightstrategy.StandardWeight ); 

            Console.ReadLine();
        }
    }
}
