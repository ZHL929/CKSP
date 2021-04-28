using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TJCU.CKSP.Common
{
    public class SqlSugarHelper
    {
        //private static string m_ConnectStr = Configuration.GetConnectionString("yk");

        /// <summary>
        /// 创建 SqlSugarClient
        /// </summary>
        public static SqlSugarClient Instance
        {
            get
            {
                //Configuration..GetConnectionString("yk");
                //创建数据库对象
                SqlSugarClient db = new SqlSugarClient(new ConnectionConfig()
                {
                    ConnectionString = "user id = ZHL;password = 123456;data source=(DESCRIPTION =(ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST =localhost)(PORT = 1521)))(CONNECT_DATA =(SERVICE_NAME =XE)))",//连接符字串
                    DbType = DbType.Oracle,
                    IsAutoCloseConnection = true,
                    InitKeyType = InitKeyType.Attribute//从特性读取主键自增信息
                });

                //添加Sql打印事件，开发中可以删掉这个代码
                db.Aop.OnLogExecuting = (sql, pars) =>
                {
                    Console.WriteLine($"{sql}\r\n参数{string.Join(",", pars.Select(s => s.Value + s.ParameterName))}");
                };
                return db;
            }
        }
    }
}
