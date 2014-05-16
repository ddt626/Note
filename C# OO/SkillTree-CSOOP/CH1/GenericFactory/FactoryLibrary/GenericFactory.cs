using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryLibrary
{
    public class GenericFactory
    {
        public static T CreateInastance<T>(string assemblyname, string typename) where T : class
        {
            Object instance = Activator.CreateInstance(assemblyname, typename).Unwrap();
            return instance as T;
        }
    }


}
