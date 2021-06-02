using Final_WP_Project.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_WP_Project.Object
{
    class RoomFunction
    {
        MY_DB my_db = new MY_DB();
        public bool Booking(string empid, string roomid, string cusid, TimeSpan start, TimeSpan end, string date, string state)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Booking (EmployeeID, RoomID, CustomerID, StartTime, EndTime, Date, State) VALUES( @empID, @RoomID, @CusID, @start, @end, @date, @state ); ");
            command.Connection = my_db.getConnection;
            my_db.openConnection();
            command.Parameters.Add("@empID", SqlDbType.NVarChar).Value = empid;
            command.Parameters.Add("@RoomID", SqlDbType.NVarChar).Value = roomid;
            command.Parameters.Add("@CusID", SqlDbType.NVarChar).Value = cusid;
            command.Parameters.Add("@start", SqlDbType.Time).Value = start;
            command.Parameters.Add("@end", SqlDbType.Time).Value = end;
            command.Parameters.Add("@date", SqlDbType.Date).Value = date;
            command.Parameters.Add("@state", SqlDbType.NVarChar).Value = state;
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
        public bool NewCustomer(string cusid, string cusname, string phone, string cmnd)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Customer (CustomerID, Name, Phone, CMND) VALUES(@CusID, @Cusname, @phone, @cmnd); ");
            command.Connection = my_db.getConnection;
            my_db.openConnection();
            command.Parameters.Add("@CusID", SqlDbType.NVarChar).Value = cusid;
            command.Parameters.Add("@Cusname", SqlDbType.NVarChar).Value = cusname;
            command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = phone;
            command.Parameters.Add("@cmnd", SqlDbType.NVarChar).Value = cmnd;
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
        public bool ChangeStatusToAvailable(string date, string roomid)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Booking WHERE RoomID = @roomid and Date = @date and State = 'Unavailable'", my_db.getConnection);
            command.Parameters.Add("@roomid", SqlDbType.NVarChar).Value = roomid;
            command.Parameters.Add("@date", SqlDbType.Date).Value = date;
            my_db.openConnection();
            if ((command.ExecuteNonQuery() == 1))
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
        public bool ChangeStatusToUnavailable(string date, string roomid)
        {
            SqlCommand command = new SqlCommand("insert into Booking (RoomID, Date, State) values (@roomid,@date,'Unavailable' )", my_db.getConnection);
            command.Parameters.Add("@roomid", SqlDbType.NVarChar).Value = roomid;
            command.Parameters.Add("@date", SqlDbType.Date).Value = date;
            my_db.openConnection();
            if ((command.ExecuteNonQuery() == 1))
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
        public bool Import(string name, int amount, float money)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Goods (Name, Amount, UnitPrice) VALUES(@name, @amount, @unitprice); ");
            command.Connection = my_db.getConnection;
            my_db.openConnection();
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@amount", SqlDbType.Int).Value = amount;
            command.Parameters.Add("@unitprice", SqlDbType.Money).Value = money;
            if ((command.ExecuteNonQuery() == 1))
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
        public bool UpdateGood(string name, int amount, float money)
        {
            SqlCommand command = new SqlCommand("  Update Goods set Amount += @amount, UnitPrice = @unitprice where Name = @name");
            command.Connection = my_db.getConnection;
            my_db.openConnection();
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@amount", SqlDbType.Int).Value = amount;
            command.Parameters.Add("@unitprice", SqlDbType.Int).Value = money;
            if ((command.ExecuteNonQuery() == 1))
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
        public bool UpdateAmountGood(string name, int amount)
        {
            SqlCommand command = new SqlCommand("  Update Goods set Amount -= @amount where Name = @name");
            command.Connection = my_db.getConnection;
            my_db.openConnection();
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@amount", SqlDbType.Int).Value = amount;
            if ((command.ExecuteNonQuery() == 1))
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
        public DataTable getService(SqlCommand command)
        {
            DataTable table = new DataTable();
            try
            {
                command.Connection = my_db.getConnection;
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                return table;
            }
            catch
            {
                table = null;
                return table;
            }
            finally
            {
                my_db.closeConnection();
            }
        }
        public bool NewService(string rid, string cid, string goodid, int amount)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Service (RoomID, CustomerID, GoodID, Amount) VALUES(@rid, @cid, @gid, @amount); ");
            command.Connection = my_db.getConnection;
            my_db.openConnection();
            command.Parameters.Add("@rid", SqlDbType.NVarChar).Value = rid;
            command.Parameters.Add("@cid", SqlDbType.NVarChar).Value = cid;
            command.Parameters.Add("@gid", SqlDbType.NVarChar).Value = goodid;
            command.Parameters.Add("@amount", SqlDbType.Int).Value = amount;
            if ((command.ExecuteNonQuery() == 1))
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
        public bool deleteService(string rid, string cid)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Service WHERE RoomID =  @rid and CustomerID = @cid");
            command.Connection = my_db.getConnection;
            command.Parameters.Add("@rid", SqlDbType.NVarChar).Value = rid.Trim();
            command.Parameters.Add("@cid", SqlDbType.NVarChar).Value = cid.Trim();
            my_db.openConnection();
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
        public DataTable getCustomer(SqlCommand command)
        {
            DataTable table = new DataTable();
            try
            {
                command.Connection = my_db.getConnection;
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                return table;
            }
            catch
            {
                table = null;
                return table;
            }
            finally
            {
                my_db.closeConnection();
            }
        }
        public bool Bill(string rid, string cusid, double service, double roomMoney, double total)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Bill (RoomID, CustomerID, Service, RoomPrice, Total) VALUES(@rid, @cusid, @service, @rMoney, @total); ");
            command.Connection = my_db.getConnection;
            my_db.openConnection();
            command.Parameters.Add("@rid", SqlDbType.NVarChar).Value = rid;
            command.Parameters.Add("@cusid", SqlDbType.NVarChar).Value = cusid;
            command.Parameters.Add("@service", SqlDbType.Money).Value = service;
            command.Parameters.Add("@rMoney", SqlDbType.Money).Value = roomMoney;
            command.Parameters.Add("@total", SqlDbType.Money).Value = total;
            if ((command.ExecuteNonQuery() == 1))
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
        public bool UpdateBooking(string empid, string roomid, string cusid, TimeSpan start, TimeSpan end, string date)
        {
            SqlCommand command = new SqlCommand("  Update Booking set State = 'Paid' where EmployeeID = @empID and RoomID = @RoomID and CustomerID = @CusID and StartTime = @start and EndTime = @end and Date = @date");
            command.Connection = my_db.getConnection;
            my_db.openConnection();
            command.Parameters.Add("@empID", SqlDbType.NVarChar).Value = empid;
            command.Parameters.Add("@RoomID", SqlDbType.NVarChar).Value = roomid;
            command.Parameters.Add("@CusID", SqlDbType.NVarChar).Value = cusid;
            command.Parameters.Add("@start", SqlDbType.Time).Value = start;
            command.Parameters.Add("@end", SqlDbType.Time).Value = end;
            command.Parameters.Add("@date", SqlDbType.Date).Value = date;
            if ((command.ExecuteNonQuery() == 1))
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
