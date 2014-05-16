using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodLibrary02
{
    // 如果有越來越多不同的工廠, 則拓展此介面
    public interface IDBFactory
    {
        IDbOperation GetDBFactory();

        //IDbBackup GetBackupFactory();
    }

    public class SqlDBFactory : IDBFactory
    {
        public IDbOperation GetDBFactory()
        {
            return new SqlDbOpration();
        }


        //public IDbBackup GetBackupFactory()
        //{
        //    return new SqlDbBackup();
        //}
    }

    public class AccessDBFactory : IDBFactory
    {
        public IDbOperation GetDBFactory()
        {
            return new AccessDbOperation();
        }
        
        //public IDbBackup GetBackupFactory()
        //{
        //    return new AccessDbBackup();
        //}
    }

   
}

   
