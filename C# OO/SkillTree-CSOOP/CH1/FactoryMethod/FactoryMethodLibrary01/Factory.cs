using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodLibrary01
{
    public interface IBMIFactory 
    {
        BMIStrategy GetStrategy(Human human);
    }

    public class ManBMIFactory : IBMIFactory
    {

        public BMIStrategy GetStrategy(Human human)
        {
            return new ManBMIStrategy(human);
        }
    }

    public class WomanBMIFactory : IBMIFactory
    {

        public BMIStrategy GetStrategy(Human human)
        {
            return new WomanBMIStrategy(human);
        }
    }
}
