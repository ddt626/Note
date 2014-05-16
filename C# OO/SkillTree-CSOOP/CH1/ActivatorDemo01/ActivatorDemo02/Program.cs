using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivatorDemo02
{
    class Program
    {
        static void Main(string[] args)
        {
            Object obj;
            // Activator.CreateInstanceFrom (string,string) , 這個回傳是 ObjectHandle, 注意組件名稱要加副檔名
            obj = Activator.CreateInstanceFrom("TestLibrary.DLL", "TestLibrary.Class1").Unwrap();
            Console.WriteLine(obj.GetType().GetProperty("Text").GetValue(obj).ToString());
            Console.WriteLine();

           

            Console.ReadLine();
        }
    }
}
