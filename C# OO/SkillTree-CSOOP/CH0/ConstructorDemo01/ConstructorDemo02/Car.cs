using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDemo02
{
    public class Car
    {
        private Wheel _wheelsA;
        public Car()
        {
            _wheelsA = new Wheel();
            _wheelsA.Wheels = 4;
            Initial();
        }
        protected virtual void Initial()
        { Console.WriteLine("Car :" + _wheelsA.Wheels.ToString()); }
    }

    public class Truck : Car
    {
        private Wheel _wheelsB;
        public Truck()
        {
            _wheelsB = new Wheel();
            _wheelsB.Wheels = 10;
        }

        protected override void Initial()
        { Console.WriteLine("Truck :" + _wheelsB.Wheels.ToString()); }
    }



    public class Wheel
    {
        public int Wheels
        {
            get;
            set;
        }
    }
}
