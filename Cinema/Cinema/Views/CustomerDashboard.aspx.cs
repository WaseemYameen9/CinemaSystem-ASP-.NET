using Cinema.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cinema.Views
{
    public partial class CustomerDashboard : System.Web.UI.Page
    {
        
        public static int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            tableLoad();
        }

        protected void AddBtn_Click(object sender, EventArgs e)
        {
            /*            string name = Nametxt.Value.ToString();
                        int NumberOfSeats = int.Parse(NoOfSeatsTxt.Value.ToString());*/
            Bookings.getinstance().addBooking(Utilities.loginer, id, int.Parse(NoOfSeatsTxt.Value.ToString()));
            Response.Redirect("CustomerDashboard.aspx");
        }

        protected void ViewBookingsBtn_Click(object sender, EventArgs e) 
        {
            Response.Redirect("CustomerViewBookings.aspx");
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
                Nametxt.Attributes["value"] = Name;
            }
        }

        protected void check()
        {
            Response.Redirect("SignUp.aspx");
        }

        protected void tableLoad()
        {
            Gridview1.DataSource = Movies.getinstance().getMoviesInfo();
            Gridview1.DataBind();
        }
    }
}
