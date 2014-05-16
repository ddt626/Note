using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDemo03
{
public class Truck
{
    protected int _wheels;
    protected int _displacement;

    public Truck()
    {
        _wheels = 8;
        _displacement = 3500;
    }

    public Truck(int wheels)
        : this()
    { _wheels = wheels; }

    public Truck(int wheels, int displacement)
        : this(wheels)
    { _displacement = displacement; }
}
}
