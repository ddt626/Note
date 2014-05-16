using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerDemo01
{
    public class Person
    {
        public String Name
        { get; set; }

        public int Age
        { get; set; }

    }

    // 聚合 Collection 的用法
    public class People
    {
        private List<Person> _items = new List<Person>();
        public List<Person> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        // 可以用原有的 Index
        public Person this[int index]
        {
            get { return _items[index]; }
            set { _items[index] = value; }
        }

        // 也可以自訂
        public Person this[string name]
        {

            get
            {
                return _items.Where((x) => x.Name == name).FirstOrDefault();
            }
            set
            {
                var item = _items.Where((x) => x.Name == name).FirstOrDefault();
                if (item != null)
                {
                    item = value;
                }
                else
                {
                    throw new IndexOutOfRangeException();  
                }
            }
        }
    }


    // 繼承 Collection 的用法
    public class PeopleCollection : List<Person>
    {
        public Person this[String name]
        {
            get
            {
                return this.Where((x) => x.Name == name).FirstOrDefault();
            }
            set
            {
                var item = this.Where((x) => x.Name == name).FirstOrDefault();
                if (item != null)
                {
                    item = value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }
    }
}
