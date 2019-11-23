using System;// imports IDisposable objects from System
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CwrkWebApp //// provide scope to organise code into packages and modules
{
    public partial class ageGroup : System.Web.UI.Page   // inherit contents from   System.Web.UI.Page class
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String userId = Session["UserName"] as String;  // gets Session value and store it into string variable
            loggedAs.Text = "LOGOUT: " + userId; // gets username and puts it as button label

            maths.ImageUrl = "~/images/maths.jpg"; // set picture
        }

        protected void easybtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("/easymode.aspx"); // redirect user to easy mode page
        }

        protected void mediumbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("/mediummode.aspx"); // redirect user to easy mode page
        }

        protected void hardbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("/hardmode.aspx"); // redirect user to easy mode
        }

        protected void loggedAs_Click(object sender, EventArgs e)
        {
            Session["UserName"] = null; // logs out the user
            Response.Redirect("/MainLogin.aspx"); // redirects the user to main login
        }
    }
}