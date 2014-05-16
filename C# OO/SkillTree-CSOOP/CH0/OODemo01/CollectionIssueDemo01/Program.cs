using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionIssueDemo01
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<MyType> list = new List<MyType>();
            //MyType obj = new MyType();
            //obj.x = 10;
            //list.Add(obj);
            //Console.WriteLine(obj.x.ToString());
            //Console.WriteLine(list[0].x.ToString());
            //Console.WriteLine("====================");
            //obj.x = 20;
            //Console.WriteLine(obj.x.ToString());
            //Console.WriteLine(list[0].x.ToString());
            //Console.WriteLine("====================");
            //obj = new MyType();
            //obj.x = 9;
            //Console.WriteLine(obj.x.ToString());
            //Console.WriteLine(list[0].x.ToString());
            //Console.WriteLine("====================");
            //obj = list[0];            
            //Console.WriteLine(obj.x.ToString());
            //Console.WriteLine(list[0].x.ToString());
            //Console.WriteLine("====================");
            //obj = list[0];
            //obj = new MyType();
            //Console.WriteLine(obj.x.ToString());
            //Console.WriteLine(list[0].x.ToString());

            //Console.ReadLine();
            MyStruct x = new MyStruct();
            x.x = 8;
            x.test();
            x.ToString();
            x.GetType();

            MyType z = new MyType();
            z.test();
            Console.ReadLine();

        }

        public class MyType
        {
            public int x;
            public void test()
            {
            }
        }

        public struct MyStruct
        {
            public int x;
            public void test()
            {
                Console.WriteLine(x);
            }

            public override string ToString()
            {
                return x.ToString();
            }

            
        }
     
       
    }
}
