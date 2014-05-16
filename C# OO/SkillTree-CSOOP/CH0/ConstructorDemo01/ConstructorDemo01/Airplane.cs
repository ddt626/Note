using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDemo01
{
public class Airplane
{
    protected string _engine;
    public Airplane (string engine)
    {
        _engine = engine;
    }
}

public class Fighter : Airplane
{
    public Fighter(): base("噴射引擎")
    {
        Console.WriteLine (_engine);
    }
}
}
