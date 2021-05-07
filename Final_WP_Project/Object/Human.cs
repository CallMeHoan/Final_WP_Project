using Final_WP_Project.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_WP_Project
{
    class Human
    {
        public DataTable gethummans(SqlCommand command)
        {
            MY_DB mydb = new MY_DB();
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            mydb.closeConnection();
            return table;
        }
        public bool InsertHummans(string id, string acc, string pass, string name, int phone, int age, string usertype )
        {
            MY_DB my_db = new MY_DB();
            SqlCommand command = new SqlCommand("INSERT INTO Login VALUES( @id, @acc, @pass); INSERT INTO Employee(ID, Name, Phone,Age, UserType) VALUES(@id, @name, @phone, @age, @usertype); ");
            command.Connection = my_db.getConnection;
            my_db.openConnection();
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
            command.Parameters.Add("@acc", SqlDbType.NVarChar).Value = acc;
            command.Parameters.Add("@pass", SqlDbType.NVarChar).Value = pass;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@phone", SqlDbType.Int).Value = phone;
            command.Parameters.Add("@age", SqlDbType.Int).Value = age;
            command.Parameters.Add("@usertype", SqlDbType.NVarChar).Value = usertype;
            if ((command.ExecuteNonQuery() > 0))
            {
                my_db.closeConnection();
                return true;
            }
            else
            {
                my_db.closeConnection();
                return false;
            }
        }
    }
}
