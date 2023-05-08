using Cinema.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cinema.Views
{
    public partial class AdminDashboard : System.Web.UI.Page
    {
        
      public static int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            tableLoad();
        }

        protected void AddBtn_Click(object sender, EventArgs e)
        {
            string name = Nametxt.Value.ToString();
            string Description = DescriptionTxt.Value.ToString();
            int PricePerSeat = int.Parse(PricePerSeatTxt.Value.ToString());
            string Status = statusTxt.Value.ToString();
            Movies.getinstance().addMovies(name, Description, PricePerSeat, Status);
            Response.Redirect("AdminDashboard.aspx");
        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {

            Movies.getinstance().Delete(id);
            Response.Redirect("AdminDashboard.aspx");

        }

        protected void ViewBookingsBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminViewBookings.aspx");
        }
        protected void Gridview1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "CellClick")
            {
                // Get the index of the row where the cell was clicked
                int rowIndex = Convert.ToInt32(e.CommandArgument);
                TableCell cell = Gridview1.Rows[rowIndex].Cells[1];
                id = Convert.ToInt32(cell.Text);
                TableCell cell1 = Gridview1.Rows[rowIndex].Cells[2];
                string Name = cell1.Text;
                TableCell cell2 = Gridview1.Rows[rowIndex].Cells[3];
                string Desc = cell2.Text;
                TableCell cell3 = Gridview1.Rows[rowIndex].Cells[4];
                string Price = cell3.Text;
                TableCell cell4 = Gridview1.Rows[rowIndex].Cells[5];
                string Status = cell4.Text;
                Nametxt.Attributes["value"] = Name;
                statusTxt.Attributes["value"] = Status;
                DescriptionTxt.Attributes["value"] = Desc;
                PricePerSeatTxt.Attributes["value"] = Price;
            }
        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            Movies.getinstance().editMovie(Nametxt.Value.ToString(), DescriptionTxt.Value.ToString(), int.Parse(PricePerSeatTxt.Value.ToString()), statusTxt.Value.ToString(), id);
            Response.Redirect("AdminDashboard.aspx");
        }
        protected void check()
        {
            Response.Redirect("SignUp.aspx");
        }

        protected void tableLoad()
        {

            // Bind the data to the HTML table in the web form
            Gridview1.DataSource = Movies.getinstance().getMoviesInfo();
            Gridview1.DataBind();

        }

    }
}
