using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cinema.Model
{
    public class Movies
    {
        private static Movies _instance = null;
        public static Movies getinstance()
        {
            if (_instance == null)
                _instance = new Movies();
            return _instance;
        }
        public void Delete(int id) {
            SqlConnection con = DBHandler.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand($"Delete  from movies where movieId={id}", con);


            cmd.ExecuteNonQuery();

        }
        public void editMovie(string name, string desc,int pricePerSeat,string status, int checkID)
        {
            try
            {
                SqlConnection con = DBHandler.getInstance().getConnection();
                //MovieId Name    Description PricePerSeat    Status
                SqlCommand cmd = new SqlCommand($"Update [dbo].[Movies] set Name='{name}' , Description='{desc}' , PricePerSeat={pricePerSeat},status='{status}' where MovieId={checkID}", con);


                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable getMoviesName() {

            SqlConnection con = DBHandler.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select Name from movies", con);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            cmd.ExecuteNonQuery();
            return dt;
        }
        public DataTable getMoviesInfo()
        {

            SqlConnection con = DBHandler.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from movies", con);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            cmd.ExecuteNonQuery();
            return dt;
        }
        public int getMovieID(string name) {
            try
            {

                SqlConnection con = DBHandler.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand($"Select top(1) name from movies where name = {name}", con);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                cmd.ExecuteNonQuery();
                if (dt.Rows.Count > 0) {
                    return int.Parse(dt.Rows[1].ItemArray[1].ToString());
                }
                return 0;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void addMovies(string movieName,string Description,int PricePerSeat,string status)
        {
            try
            {
                SqlConnection con = DBHandler.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("INSERT INTO Movies VALUES (@movieName,@Description,@PricePerSeat,@status)", con);

                cmd.Parameters.AddWithValue("@movieName", movieName);
                cmd.Parameters.AddWithValue("@Description", Description);
                cmd.Parameters.AddWithValue("@PricePerSeat", PricePerSeat);
                cmd.Parameters.AddWithValue("@status", status);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}