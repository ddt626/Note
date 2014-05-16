using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifilerLibrary
{
    public interface IPublic
    {
        string WhoIs();
    }

    internal class Class1 : IPublic
    {

        public string WhoIs()
        {
            return "I am class 1";
        }
    }

    internal class Class2 : IPublic
    {

        public string WhoIs()
        {
            return "I am class 2";
        }
    }

  

    public class PublicFactory
    {
        public static IPublic GetInstance(string classname)
        {
            classname = classname.ToLower();
            switch (classname)
            {
                case "class1":
                    return new Class1();
                case "class2":
                    return new Class2();
                default :
                    throw new InvalidOperationException();
            }
        }
    }
}
