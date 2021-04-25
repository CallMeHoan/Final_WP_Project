using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_WP_Project.Model
{
    public static class DbConnectFactory
    {
        public static DbConnection GetConnection()
        {
            return new SqlConnection(@"Data Source=DESKTOP-1559CCJ;Initial Catalog=StudentManage;Integrated Security=True");
        }
        public static DbCommand GetCommand(DbConnection conn)
        {
            DbCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            return cmd;
        }
        public static DbParameter CreateParameter(string name, Object value)
        {
            return new SqlParameter(name, value);
        }
    }
}
