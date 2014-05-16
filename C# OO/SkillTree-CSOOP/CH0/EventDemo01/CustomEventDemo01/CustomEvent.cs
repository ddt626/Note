using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEventDemo01
{


    public class CustomEventArgs : EventArgs
    {
        public int OldValue
        { get; set; }
        public int NewValue
        { get; set; }
    }

    public delegate void CustomEventHandler(Object sender, CustomEventArgs e);

    public class CustomEvent
    {
        private int _x;
        public int X
        {
            get { return _x; }
            set
            {
                if (_x != value)
                {
                    int old = _x;
                    _x = value;
                    OnXChanged(old, value);
                }
            }
        }

        private List<CustomEventHandler> handlers = new List<CustomEventHandler>();
        public event CustomEventHandler XChanged
        {
            add
            {
                lock (handlers)
                {
                    handlers.Add(value);
                }
            }
            remove
            {
                lock (handlers)
                {
                    handlers.Remove(value);
                }
            }
        }

        private void OnXChanged(int oldvalue, int newvalue)
        {            
                foreach (var handle in handlers)
                {
                    handle.Invoke(this, new CustomEventArgs() { OldValue = oldvalue, NewValue = newvalue });
                }           
        }


    }
}
