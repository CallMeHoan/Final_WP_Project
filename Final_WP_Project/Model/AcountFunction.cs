using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_WP_Project.Model
{
    class AcountFunction
    {
        public bool InnsertAccount(string accountName, string password)
        { 
            using (var conn = DbConnectFactory.GetConnection())
            {
                using (var cmd = DbConnectFactory.GetCommand(conn))
                {
                    cmd.CommandText = "INSERT INTO account (acc,pass)" + " VALUES (@acc,@pass)";
                    cmd.Parameters.Add(DbConnectFactory.CreateParameter("@acc", accountName));
                    cmd.Parameters.Add(DbConnectFactory.CreateParameter("@pass", password));
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            return true;
        }
    }
}
