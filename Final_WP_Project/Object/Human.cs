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
        public bool InsertHummans(string id, string acc, string pass, string name, int phone, int age, string usertype, string gender)
        {
            MY_DB my_db = new MY_DB();
            SqlCommand command = new SqlCommand("sp_InsertEmployee @id, @acc, @pass, @name, @phone, @age, @usertype, @gender");
            command.Connection = my_db.getConnection;
            my_db.openConnection();
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
            command.Parameters.Add("@acc", SqlDbType.NVarChar).Value = acc;
            command.Parameters.Add("@pass", SqlDbType.NVarChar).Value = pass;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@phone", SqlDbType.Int).Value = phone;
            command.Parameters.Add("@age", SqlDbType.Int).Value = age;
            command.Parameters.Add("@usertype", SqlDbType.NVarChar).Value = usertype;
            command.Parameters.Add("@gender", SqlDbType.NVarChar).Value = gender;
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
        public bool InsertHummansII(string id, string name, int phone, int age, string usertype,string gender)
        {
            MY_DB my_db = new MY_DB();
            SqlCommand command = new SqlCommand("sp_InsertEmployeeII @id, @name, @phone, @age, @usertype, @gender; ");
            command.Connection = my_db.getConnection;
            my_db.openConnection();
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@phone", SqlDbType.Int).Value = phone;
            command.Parameters.Add("@age", SqlDbType.Int).Value = age;
            command.Parameters.Add("@usertype", SqlDbType.NVarChar).Value = usertype;
            command.Parameters.Add("@gender", SqlDbType.NVarChar).Value = gender;

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
            SqlCommand command = new SqlCommand(" sp_UpdateEmployee @id, @name, @phone, @age, @usertype, @gender", mydb.getConnection);
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
            SqlCommand command = new SqlCommand("sp_DeleteEmployee @id", mydb.getConnection);
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
        public bool CreateSchedule(string[,] A)
        {
            Human h = new Human();
            MY_DB db = new MY_DB();
            SqlCommand command4 = new SqlCommand("sp_DeleteWorkday");
            h.gethummans(command4);
            int k = 0;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    string start="";
                    string end="";
                    string week="";
                    if(i==0)
                    {
                        start = "7h";
                        end = "9h30";
                    }
                    if (i == 1)
                    {
                        start = "10h";
                        end = "12h30";
                    }
                    if (i == 2)
                    {
                        start = "13h";
                        end = "15h30";
                    }
                    if (i == 3)
                    {
                        start = "16h";
                        end = "18h30";
                    }
                    if (i == 4)
                    {
                        start = "19h";
                        end = "21h30";
                    }
                    if (i == 5)
                    {
                        start = "22h";
                        end = "0h30";
                    }
                    if (i == 6)
                    {
                        start = "1h";
                        end = "3h30";
                    }
                    if (i == 7)
                    {
                        start = "4h";
                        end = "6h30";
                    }
                    if(j==0)
                    {
                        week = "2";
                    }
                    if (j == 1)
                    {
                        week = "3";
                    }
                    if (j == 2)
                    {
                        week = "4";
                    }
                    if (j == 3)
                    {
                        week = "5";
                    }
                    if (j ==4)
                    {
                        week = "6";
                    }
                    if (j == 5)
                    {
                        week = "7";
                    }
                    if (j == 6)
                    {
                        week = "cn";
                    }
                    if ( (i == 0 && j != 6) || (i == 4 && j != 6))
                    {
                        
                        string[] arrListStr = A[i, j].Split(')');
                        string mana = arrListStr[0].Substring(0, arrListStr[0].Length - 6);
                        string recep = arrListStr[1].Substring(0, arrListStr[1].Length - 6);
                        string labo = arrListStr[2].Substring(0, arrListStr[2].Length - 4);

                         SqlCommand command1 = new SqlCommand("Select id from Employee where name = @name1",db.getConnection);
                        command1.Parameters.Add("@name1", SqlDbType.NVarChar).Value = mana.Trim();
                        DataTable table1 = h.gethummans(command1);

                         SqlCommand command2 = new SqlCommand("Select id from Employee where name = @name2", db.getConnection);
                        command2.Parameters.Add("@name2", SqlDbType.NVarChar).Value = recep.Trim();
                        DataTable table2 = h.gethummans(command2);

                        SqlCommand command3 = new SqlCommand("Select id from Employee where name = @name3", db.getConnection);
                        command3.Parameters.Add("@name3", SqlDbType.NVarChar).Value = labo.Trim();
                        DataTable table3 = h.gethummans(command3);
                            
                        SqlCommand command = new SqlCommand("INSERT INTO WorkDay(EmployeeID, StartTime, EndTime, DayofWeek, IDShift) VALUES(@id1, @start, @end, @week, @idshift1) INSERT INTO WorkDay(EmployeeID, StartTime, EndTime, DayofWeek, IDShift) VALUES(@id2, @start, @end, @week, @idshift2) INSERT INTO WorkDay(EmployeeID, StartTime, EndTime, DayofWeek, IDShift) VALUES(@id3, @start, @end, @week, @idshift3);", db.getConnection);

                        command.Parameters.Add("@id1", SqlDbType.NVarChar).Value = table1.Rows[0][0];
                        command.Parameters.Add("@id2", SqlDbType.NVarChar).Value = table2.Rows[0][0];
                        command.Parameters.Add("@id3", SqlDbType.NVarChar).Value = table3.Rows[0][0];
                        command.Parameters.Add("@start", SqlDbType.NVarChar).Value = start;
                        command.Parameters.Add("@end", SqlDbType.NVarChar).Value = end;
                        command.Parameters.Add("@week", SqlDbType.NVarChar).Value = week;
                        command.Parameters.Add("@idshift1", SqlDbType.NVarChar).Value = k;
                        command.Parameters.Add("@idshift2", SqlDbType.NVarChar).Value = k+1;
                        command.Parameters.Add("@idshift3", SqlDbType.NVarChar).Value = k+2;
                        k = k + 3;
                        db.openConnection();
                        if (command.ExecuteNonQuery()<=0)
                        {
                            db.closeConnection();
                            return false;
                        }
                      
                    }
                    else if (((i != 0 && j != 6) || (i != 4 && j != 6)))
                    {

                        string[] arrListStr = A[i, j].Split(')');
                        string mana = arrListStr[0].Substring(0, arrListStr[0].Length - 6);
                        string recep = arrListStr[1].Substring(0, arrListStr[1].Length - 6);
                       

                        SqlCommand command1 = new SqlCommand("Select id from Employee where name = @name1", db.getConnection);
                        command1.Parameters.Add("@name1", SqlDbType.NVarChar).Value = mana.Trim();
                        DataTable table1 = h.gethummans(command1);

                        SqlCommand command2 = new SqlCommand("Select id from Employee where name = @name2", db.getConnection);
                        command2.Parameters.Add("@name2", SqlDbType.NVarChar).Value = recep.Trim();
                        DataTable table2 = h.gethummans(command2);

                        

                        SqlCommand command = new SqlCommand("INSERT INTO WorkDay(EmployeeID, StartTime, EndTime, DayofWeek, IDShift) VALUES(@id1, @start, @end, @week, @idshift1) INSERT INTO WorkDay(EmployeeID, StartTime, EndTime, DayofWeek, IDShift) VALUES(@id2, @start, @end, @week, @idshift2) ;", db.getConnection);

                        command.Parameters.Add("@id1", SqlDbType.NVarChar).Value = table1.Rows[0][0];
                        command.Parameters.Add("@id2", SqlDbType.NVarChar).Value = table2.Rows[0][0];
                        
                        command.Parameters.Add("@start", SqlDbType.NVarChar).Value = start;
                        command.Parameters.Add("@end", SqlDbType.NVarChar).Value = end;
                        command.Parameters.Add("@week", SqlDbType.NVarChar).Value = week;
                        command.Parameters.Add("@idshift1", SqlDbType.NVarChar).Value = k;
                        command.Parameters.Add("@idshift2", SqlDbType.NVarChar).Value = k + 1;
                        k = k + 2;
                        db.openConnection();
                        if (command.ExecuteNonQuery() <= 0)
                        {
                            db.closeConnection();
                            return false;
                        }

                    }
                    else
                    {
                        string[] arrListStr = A[i, j].Split(')');
                        string mana = arrListStr[0].Substring(0, arrListStr[0].Length - 6);
                        
                        string labo = arrListStr[1].Substring(0, arrListStr[1].Length - 6);

                        SqlCommand command1 = new SqlCommand("Select id from Employee where name = @name1", db.getConnection);
                        command1.Parameters.Add("@name1", SqlDbType.NVarChar).Value = mana.Trim();
                        DataTable table1 = h.gethummans(command1);

                        SqlCommand command3 = new SqlCommand("Select id from Employee where name = @name3", db.getConnection);
                        command3.Parameters.Add("@name3", SqlDbType.NVarChar).Value = labo.Trim();
                        DataTable table3 = h.gethummans(command3);

                        SqlCommand command = new SqlCommand("INSERT INTO WorkDay(EmployeeID, StartTime, EndTime, DayofWeek,IDShift) VALUES(@id1, @start, @end, @week,@idshift1) INSERT INTO WorkDay(EmployeeID, StartTime, EndTime, DayofWeek, IDshift) VALUES(@id3, @start, @end, @week, @idshift2);", db.getConnection);

                        command.Parameters.Add("@id1", SqlDbType.NVarChar).Value = table1.Rows[0][0];
                        command.Parameters.Add("@id3", SqlDbType.NVarChar).Value = table3.Rows[0][0];
                        command.Parameters.Add("@start", SqlDbType.NVarChar).Value = start;
                        command.Parameters.Add("@end", SqlDbType.NVarChar).Value = end;
                        command.Parameters.Add("@week", SqlDbType.NVarChar).Value = week;
                        command.Parameters.Add("@idshift1", SqlDbType.NVarChar).Value = k;
                        command.Parameters.Add("@idshift2", SqlDbType.NVarChar).Value = k + 1;
                        k = k + 2;
                        db.openConnection();
                        if (command.ExecuteNonQuery() <= 0)
                        {
                            db.closeConnection();
                            return false;
                        }
                    }

                }
            }
            return true;
        }
        public string[] GetSalaryDay(int id, int day)
        {
            string dayy = "";
            if(day==2)
            {
                dayy = "2";
            }
            if (day == 3)
            {
                dayy = "3";
            }
            if (day == 4)
            {
                dayy = "4";
            }
            if (day == 5)
            {
                dayy = "5";
            }
            if (day == 6)
            {
                dayy = "6";
            }
            if (day == 7)
            {
                dayy = "7";
            }
            if (day == 8)
            {
                dayy = "cn";
            }

            SqlCommand command = new SqlCommand("Select * from fn_CheckAttendanceDay (@id, @day)");
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
            command.Parameters.Add("@day", SqlDbType.VarChar).Value = dayy;
            DataTable table = gethummans(command);
            string[] attendance = new string[100];
            for(int i = 0; i < table.Rows.Count;i++)
            {
                if(table.Rows[i][0] == DBNull.Value)
                {
                    attendance[i] = "Absent";
                }
                else
                {
                    attendance[i] = table.Rows[i][0].ToString();
                }
            }
            return attendance;
        }
    }
}
