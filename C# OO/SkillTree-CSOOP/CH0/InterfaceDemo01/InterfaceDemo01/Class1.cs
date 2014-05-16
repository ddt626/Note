using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDemo01
{
     
    public interface IPublic
    {
         String GetString();      
    }

    // 實作介面    
    public class ImplementIPublic : IPublic
    {
        public string GetString()
        {
            return "ImplementIPublic";
        }
    }

    // IExtend 拓展 IPublic, 但沒有同名成員
    public interface IExtend : IPublic 
    {
        String GetExtendString();
    }

    // 實做 IExtend 會連同 IPublic 一起要求實作
    public class ImplementIExtend : IExtend
    {

        public string GetExtendString()
        {
            throw new NotImplementedException();
        }

        public string GetString()
        {
            throw new NotImplementedException();
        }
    }

    // 即使你宣告實作 IExtend 和 IPublic , IPublic 中的 GetString() 仍然只需要實做一次
    public class ImplementIExtendIPublic : IExtend, IPublic
    {

        public string GetExtendString()
        {
            throw new NotImplementedException();
        }

        public string GetString()
        {
            throw new NotImplementedException();
        }
    }
}
