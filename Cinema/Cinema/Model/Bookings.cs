using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Cinema.Model
{
    public class Bookings
    {
        private static Bookings _instance = null;
        public static Bookings getinstance()
        {
            if (_instance == null)
                _instance = new Bookings();
            return _instance;
        }
        public DataTable getBookingsAllInfo()
        {

            SqlConnection con = DBHandler.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Bookings", con);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            cmd.ExecuteNonQuery();
            return dt;
        }
        public void addBooking(int UserID, int MovieID, int noOfSeat)
        {
            try
            {
                SqlConnection con = DBHandler.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[Bookings] VALUES (@userID,@MovieID,@noOfSeat)", con);

                cmd.Parameters.AddWithValue("@userID", UserID);
                cmd.Parameters.AddWithValue("@MovieID", MovieID);
                cmd.Parameters.AddWithValue("@noOfSeat", noOfSeat);


                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void editUser(string name, int password, string role, int checkID)
        {
            try
            {
                SqlConnection con = DBHandler.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Update from [dbo].[User] set userName=@name , userPassword=@password , role=@role where userId=@checkID", con);

                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@role", role);
                cmd.Parameters.AddWithValue("@checkID", checkID);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool deleteUser(int ID)
        {
            try
            {
                SqlConnection con = DBHandler.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Delete from [dbo].[User] where userId=@ID", con);

                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return false;
        }
    }
}