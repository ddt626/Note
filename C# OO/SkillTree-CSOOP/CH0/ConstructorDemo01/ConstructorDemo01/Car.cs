using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDemo01
{
public class Car
{
    protected int _wheels;
    public Car()
    { _wheels = 4; }
}

public class Coupe : Car
{
    public Coupe():base()       
    { Console.WriteLine("Coupe" + _wheels.ToString()); }
}

public class Truck : Car
{
    public Truck(int wheels):base()
    {
        _wheels = wheels;
        Console.WriteLine("Truck: " + _wheels.ToString());
    }
}



}
