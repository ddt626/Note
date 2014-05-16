using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace InterfaceDemo04
{
    public interface IPublic
    {
        String GetString();
    }

    public interface IExtend : IPublic
    {
        new String GetString();
    }


    public class ImplementIPublicExtend : IExtend
    {


        string IExtend.GetString()
        {
            throw new NotImplementedException();
        }

        string IPublic.GetString()
        {
            throw new NotImplementedException();
        }
    }


    public interface IGen<T1, T2>
    {
        void Test(T1 value);
        T2 Test2();
    }

    public class GEN<T1, T2> : IGen<T1, T2>
        where T1 : IComparable, new()
        where T2 : DataTable
    {

        public void Test(T1 value)
        { T1 x = new T1(); }

        public T2 Test2()
        { return default(T2); }
    }

}
