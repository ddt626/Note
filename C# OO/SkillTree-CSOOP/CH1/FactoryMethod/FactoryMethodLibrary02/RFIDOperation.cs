using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodLibrary02
{
    public interface  IRfidOperation
    {
        string Connect();
        string Read();
        string Write();        
    }


    internal class NXPRfidOperation : IRfidOperation
    {

        public string Connect()
        {
            return "連接 NXP 讀卡機";
        }

        public string Read()
        {
            return "NXP 讀卡機讀取資料";
        }

        public string Write()
        {
            return "NXP 讀卡機寫入資料";
        }
    }

    internal class SonyRfidOperation : IRfidOperation
    {
        public string Connect()
        {
            return "連接 Sony 讀卡機";
        }

        public string Read()
        {
            return "Sony 讀卡機讀取資料";
        }

        public string Write()
        {
            return "Sony 讀卡機寫入資料";
        }
    }
}
