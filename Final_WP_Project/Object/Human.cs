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
        public bool InsertHummans(string id, string acc, string pass, string name, int phone, int age, string usertype)
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
        public bool UpdateHumans(string id, string name, int phone, int age, string usertype, string gender)
        {
            MY_DB mydb = new MY_DB();
            SqlCommand command = new SqlCommand("UPDATE Employee SET id = @id, name = @name, phone = @phone, age = @age, Usertype = @usertype, gender = @gender WHERE id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
            command.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@age", SqlDbType.Int).Value = age;
            command.Parameters.Add("@Usertype", SqlDbType.VarChar).Value = usertype;
            command.Parameters.Add("@gender", SqlDbType.VarChar).Value = gender;
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool deleteEmployee(string id)
        {
            MY_DB mydb = new MY_DB();
            SqlCommand command = new SqlCommand("Delete from Employee where id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
    }
}
