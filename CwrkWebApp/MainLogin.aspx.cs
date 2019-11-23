using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CwrkWebApp // provide scope to organise code into packages
{
    public partial class MainLogin : System.Web.UI.Page // inherit ystem.Web.UI.Page
    {
        String getusername; // instanciate string variable
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void loginbtn_Click(object sender, EventArgs e)
        {
            getusername = usertb.Text; // get username and store it in getusername
            string getpassword = passtb.Text; // get password  store it in getpassword 
            

            if (database.pullUsernameandPass(getusername, getpassword)) // check if the user input matches with usernames and passwords stored on database
            {
                Session["UserName"] = usertb.Text; // create session named "UserName" and store usertb.Text value in it
   
                Response.Redirect("/ageGroup.aspx"); // redirect if the button is clicked

            } else
            {
                wronglbl.Visible = true; //if the password or username is wrong display label as validation message
                
                
            }
        }

        }
}