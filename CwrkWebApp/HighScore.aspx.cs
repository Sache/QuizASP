using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CwrkWebApp
{
    public partial class HighScore : System.Web.UI.Page
    {
        string medal; // initalise variable as string
        double scoreDouble; // initalise variable as double
        protected void Page_Load(object sender, EventArgs e)
        {

            String user = Session["UserName"] as String; // get stored session valuse 
            loggedAs.Text = "LOGOUT: " + user; // and put it as a button label
            usertbx.Text = user; // get  username fromt the session

            String score = Session["Score"] as String; // get score from session
            scoretbx.Text = score + "%"; // display it as a percentage on texbox

            String date = Session["Date"] as String; // get date from session
            datetbx.Text = date; // display it on a textbox

            String time = Session["Time"] as String;
            timetbx.Text = time;




            if (user == null) { //  if value of user varable is null set all the objects invisible if the condition is met
                childPic.Visible = false; loggedAs.Visible = false; // make image  and button disappear
                usertbx.Visible = false; usernamelbl.Visible = false; // make text box and label disappear
                scoretbx.Visible = false; scorelbl.Visible = false;
                datetbx.Visible = false; datelbl.Visible = false;
                timetbx.Visible = false; timelbl.Visible = false;
                medaltbx.Visible = false; medalbl.Visible = false;
            }

            Double.TryParse(score, out scoreDouble); // convert string as a double
            scoreDouble = scoreDouble / 100 * 100; // convert to  percentage and store as varaible
            if (scoreDouble < 70) { medal = "Pass"; } //  if condtion met the set text 
            if (scoreDouble < 40) { medal = "Fail"; } //  if condtion met the set text 
            if (scoreDouble >= 70 && scoreDouble < 80) {medal = "Silver Medal Awarded"; }//  if condtion met the set text 
            if (scoreDouble > 80) { medal = "Gold Medal Awarded"; }//  if condtion met the set text 
            medaltbx.Text = medal; // store the text value into a variable
          
             
            database.storeScore(user, score, date, time, medal); //  call the method to store user,  score,  date , time and medal into database
            try { if (user != null) { childPic.ImageUrl = "~/images/" + user + ".jpg"; } // try to display pic if user is not null
            else { childPic.ImageUrl = "~/images/child.jpg"; } // display a default pic
           } catch(Exception) { childPic.ImageUrl = "~/images/child.jpg"; } // if exception is catched then default image loaded

        }

        protected void loggedAs_Click(object sender, EventArgs e)
        {
            Session["UserName"] = null; // set session null to logout the user
            Response.Redirect("/MainLogin.aspx"); //  redirect to login page when logged out
        }
    }
}