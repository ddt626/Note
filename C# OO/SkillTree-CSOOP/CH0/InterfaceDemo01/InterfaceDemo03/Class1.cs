using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDemo03
{
    public interface IPublic
    {
        String GetString();
    }

    public interface IExtend
    {
        String GetString(Object value);
    }

    public interface IEx
    {
        int GetString();
    }

    // 參數簽章不同可以同時實作, 簽章相同回傳值不同需明確實作
    public class ImplementIPublicExtendEx : IPublic ,IExtend,IEx
    {

        public string GetString()
        {
            throw new NotImplementedException();
        }

        public string GetString(object value)
        {
            throw new NotImplementedException();
        }

        int IEx.GetString()
        {
            throw new NotImplementedException();
        }
    }
}
