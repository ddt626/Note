using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDemo02
{
    public class SingletonClass
    {
        private int i = 0;
        private SingletonClass()
        {

        }

        public void Show()
        {
            System.Windows.Forms.MessageBox.Show("Hello lock " + i.ToString());
            i += 1;
        }

        private static volatile SingletonClass _singletonObject;
        private static object _syncRoot = new Object();
        public static SingletonClass SingletonObject
        {
            get
            {
                if (_singletonObject == null)
                {
                    lock (_syncRoot)
                    {
                        GetSingleton();
                    }
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
