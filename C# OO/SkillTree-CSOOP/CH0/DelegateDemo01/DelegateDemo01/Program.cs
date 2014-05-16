using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo01
{
    class Program
    {
        public delegate void SomeAction(string message);
        static void Main(string[] args)
        {
            SomeAction action = ShowMessage;
            action += ShowText;
            action.Invoke("Test");
            Console.ReadLine();
        }

        public static void ShowMessage(string message)
        {
            Console.WriteLine("ShowMessage :" + message);
        }

        public static void ShowText(string text)
        {
            Console.WriteLine("ShowText :" + text);
        }
    }
}
