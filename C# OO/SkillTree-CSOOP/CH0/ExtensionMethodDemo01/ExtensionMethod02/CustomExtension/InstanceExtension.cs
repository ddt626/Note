using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod02.CustomExtension
{
    public static class InstanceExtension
    {
        public static string  GetArea(this InstanceClass obj)
        {
            return "擴充方法";
        }
    }
}
