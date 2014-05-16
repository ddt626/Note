using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodLibrary02
{
    public interface  IDbBackup
    {
        string Backup();
        string Restore();
    }

    internal class SqlDbBackup : IDbBackup
    {
        public string Backup()
        {
            return "備份 SQL Server 資料";
        }

        public string Restore()
        {
            return "還原 SQL Server 資料";
        }
    }

    internal class AccessDbBackup : IDbBackup
    {
        public string Backup()
        {
            return "備份 Access 資料";
        }

        public string Restore()
        {
            return "還原 Access 資料";
        }
    }
}
