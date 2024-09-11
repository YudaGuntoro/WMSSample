using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMS.Infrastructure.Shared
{
    public static class dbConfig
    {
        private static string Server = Singletone.Instance.Read("Server", "Connections");
        private static string Port = Singletone.Instance.Read("Port", "Connections");
        private static string UserID = Singletone.Instance.Read("UserID", "Connections");
        private static string Password = Singletone.Instance.Read("Password", "Connections");
        private static string Db = Singletone.Instance.Read("Db", "Connections");

        public static readonly string MysqlConnString = "Server=" + Server + ";" +
           "Port=" + Port + ";" +
           "User ID=" + UserID + ";" +
           "Password=" + Password + ";" +
           "Database=" + Db + ";";



    }
}
