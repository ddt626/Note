using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodLibrary02
{
    public interface IDbOperation
    {
        string ConnectDB();
        string Query();
        string Insert();
        string Delete();
        string Update();
    }



    internal  class SqlDbOpration : IDbOperation 
    {

        public string ConnectDB()
        {
            return "連接 SQL Server";
        }

        public string Query()
        {
            return "從 SQL Server 讀取資料";
        }

        public string Insert()
        {
            return "新增資料到 SQL Server";
        }

        public string Delete()
        {
            return "刪除 SQL Server 資料";
        }

        public string Update()
        {
            return "更新 SQL Server 資料";
        }
    }

    internal class AccessDbOperation : IDbOperation
    {
        public string ConnectDB()
        {
            return "連接 Access";
        }

        public string Query()
        {
            return "從 Access 讀取資料";
        }

        public string Insert()
        {
            return "新增資料到 Access";
        }

        public string Delete()
        {
            return "刪除 Access 資料";
        }

        public string Update()
        {
            return "更新 Access 資料";
        }
    }
}
