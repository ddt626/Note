using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RelectionMembersDemo02
{
    //取得方法並執行之
    class Program
    {
        static void Main(string[] args)
        {
            Object obj = AppDomain.CurrentDomain.CreateInstanceAndUnwrap("TestLibrary", "TestLibrary.Class1");
            MethodInfo[] methods;

            Console.WriteLine("==GetMethods()==");
            methods = obj.GetType().GetMethods();
            ShowResult(methods);
            //執行方法
            Console.WriteLine("==Invoke PublicShow==");
            MethodInfo method = methods.Where((x) => x.Name == "PublicShow").FirstOrDefault();

            method.Invoke(obj, null);
            Console.WriteLine("=======================");
            Console.WriteLine();
            Console.WriteLine("==Invoke PublicShow overloading==");
            method = methods.Where((x) => x.Name == "PublicShow" && x.GetParameters().Count() == 1).FirstOrDefault();
            method.Invoke(obj, new object[] { "ABC" });
            Console.WriteLine("=======================");
            Console.WriteLine();

            Console.WriteLine("==GetMethods() BindingFlag==");
            methods = obj.GetType().GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
            ShowResult(methods);

            Console.WriteLine("==Invoke PrivateShow==");
            method = methods.Where((x) => x.Name == "PrivateShow").FirstOrDefault();
            method.Invoke(obj, null);
            Console.WriteLine("=======================");
            Console.WriteLine();

            Console.WriteLine("==GetMethod() BindingFlag==");
            Console.WriteLine(obj.GetType().GetMethod("ProtectedShow", BindingFlags.Instance | BindingFlags.NonPublic).Name);
            Console.WriteLine("=======================");
            Console.WriteLine();

            Console.WriteLine("==GetMethod() and Invoke==");
            Type[] types = new Type []{typeof(String) };
            method = obj.GetType().GetMethod("PublicShow", types);
            method.Invoke(obj, new object[] { "XYZ" });
            Console.WriteLine("=======================");
            Console.WriteLine();


            Console.ReadLine();

        }

        static void ShowResult(MethodInfo[] methods)
        {
            foreach (var m in methods)
            {
                Console.WriteLine(m.Name + ":" + m.ReflectedType.ToString());
            }
            Console.WriteLine("=======================");
            Console.WriteLine();
        }
    }
}
