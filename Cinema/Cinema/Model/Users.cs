using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;



namespace Cinema.Model
{
    public class Users
    {
        private static Users _instance=null;
        public static Users getinstance() {
            if(_instance==null)
                _instance = new Users();
            return _instance;
        }
        public DataTable getUsersAllInfo()
        {

            SqlConnection con = DBHandler.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from [dbo].[User]", con);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            cmd.ExecuteNonQuery();
            return dt;
        }
        public string getUserRole(string userName,string userPassword)
        {
            try
            {

                SqlConnection con = DBHandler.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand($"Select top(1) * from [dbo].[User] where userName ='{userName}' and userPassword= '{userPassword}'", con);
                string m = $"Select top(1) * from[dbo].[User] where userName = {userName} and userPassword = {userPassword}";
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                cmd.ExecuteNonQuery();
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    return dr["userRole"].ToString();
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int getUserID(string userName, string userPassword)
        {
            try
            {

                SqlConnection con = DBHandler.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand($"Select top(1) * from [dbo].[User] where username = '{userName}' and userpassword= '{userPassword}'", con);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                cmd.ExecuteNonQuery();
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    return int.Parse(dr["userID"].ToString());
                }
                return 0;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void addUser(string name, string password,string role)
        {
            try
            {
                SqlConnection con = DBHandler.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[User] VALUES (@name,@password,@role)", con);

                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@role", role);
                

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void editUser(string name, int password, string role,int checkID)
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