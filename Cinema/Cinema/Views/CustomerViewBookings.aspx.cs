using Cinema.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cinema.Views
{
    public partial class CustomerViewBookings : System.Web.UI.Page
    {
        public static int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            tableLoad();
        }


        protected void tableLoad()
        {

            // Bind the data to the HTML table in the web form
            Gridview1.DataSource = Movies.getinstance().getMoviesInfo();
            Gridview1.DataBind();

        }

        protected void GoBackBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("CustomerDashboard.aspx");
        }
    }
}