using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodDemo01
{
public static class ExtensionClass
{
    public static String[] Splitline(this string str)
    {
        return str.Split(new String[] { Environment.NewLine }, StringSplitOptions.None );                      
    }
}
}
