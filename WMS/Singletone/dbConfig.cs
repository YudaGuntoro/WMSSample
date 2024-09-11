using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMS.Singletone
{
    public class dbConfig
    {
        private static string Server = Config.Instance.Read("Server", "Connections");
        private static string Port = Config.Instance.Read("Port", "Connections");
        private static string UserID = Config.Instance.Read("UserID", "Connections");
        private static string Password = Config.Instance.Read("Password", "Connections");
        private static string Db = Config.Instance.Read("Db", "Connections");


        public static readonly string MysqlConnString = "Server=" + Server + ";" +
           "Port=" + Port + ";" +
           "User ID=" + UserID + ";" +
           "Password=" + Password + ";" +
           "Database=" + Db + ";";
    }
}
