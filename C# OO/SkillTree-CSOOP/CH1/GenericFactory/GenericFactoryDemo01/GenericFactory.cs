using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericFactoryDemo01
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
