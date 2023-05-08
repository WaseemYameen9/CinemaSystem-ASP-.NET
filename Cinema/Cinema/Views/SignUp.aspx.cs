using Cinema.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cinema.Views
{
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }
        protected void btn_Click(object sender, EventArgs e)
        {
           Users.getinstance().addUser(emailTxt.Value.ToString(), passwordtxt.Value.ToString(), roleCB.Value.ToString());
            Response.Redirect("Loginaspx.aspx");
        }
}
}