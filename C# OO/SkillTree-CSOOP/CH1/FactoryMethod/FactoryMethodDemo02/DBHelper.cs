using FactoryMethodLibrary02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDemo02
{
    public class DBHelper
    {
        public static IDbOperation GetDBOperation()
        {
            // 這邊可以改成由設定檔取得
            //IDBFactory dbfactory= new SqlDBFactory();
            IDBFactory dbfactory = new AccessDBFactory();

            return dbfactory.GetDBFactory();
        }
    }
}
