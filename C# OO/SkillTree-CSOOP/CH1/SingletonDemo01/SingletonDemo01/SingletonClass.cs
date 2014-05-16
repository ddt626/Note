using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDemo01
{
    public class SingletonClass
    {
        private int i = 0;
        private SingletonClass()
        {

        }

        public void Show()
        {
            System.Windows.Forms.MessageBox.Show("Hello " + i.ToString());
            i += 1;
        }

        private static SingletonClass _singletonObject;
        public static SingletonClass SingletonObject
        {
            get
            {
                if (_singletonObject == null)
                {                   
                        GetSingleton();    
                }
                return _singletonObject;
            }
        }

        private static void GetSingleton()
        {
            _singletonObject = new SingletonClass();
        }
    }
}
