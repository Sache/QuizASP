using System; // imports IDisposable objects from System
using System.Collections.Generic; // imports IDisposable objects in this class
using System.Data; // imports IDisposable objects in this class
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient; // 
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CwrkWebApp //// provide scope to organise code into packages
{
    public partial  class easymode : System.Web.UI.Page // inherit from System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String userId = Session["UserName"] as String; // get the value from Session named "UserName" and store it as a string on a variable
            loggedAs.Text = "LOGOUT: " + userId; // input text onto LOGOUT button

            q1.Text = database.getQuestions("age6plus","1"); //  call method located in database.cs to set parameters  TABLE and ID for SQL execution
            q2.Text = database.getQuestions("age6plus","2"); // call method located in database.cs to set parameters  TABLE and ID for SQL execution
            q3.Text = database.getQuestions("age6plus","3");
            q4.Text = database.getQuestions("age6plus","4");
            q5.Text = database.getQuestions("age6plus","5");
            q6.Text = database.getQuestions("age6plus","6");
            q7.Text = database.getQuestions("age6plus","7");
            q8.Text = database.getQuestions("age6plus","8");
            q9.Text = database.getQuestions("age6plus","9"); // call method located in database.cs to set parameters  TABLE and ID for SQL execution
            q10.Text = database.getQuestions("age6plus","10"); // call method located in database.cs to set parameters  TABLE and ID for SQL execution

        }

        protected void sbmtbtn_Click(object sender, EventArgs e)
        {
            int score = 0; // integer initialised
            string s1 = RadioButtonList1.SelectedValue; // get selected value from RadioButtonList and store it into a string
            string s2 = RadioButtonList2.SelectedValue; // get selected value from RadioButtonList and store it into a string
            string s3 = RadioButtonList3.SelectedValue; // get selected value from RadioButtonList and store it into a string
            string s4 = RadioButtonList4.SelectedValue;
            string s5 = RadioButtonList5.SelectedValue;
            string s6 = RadioButtonList6.SelectedValue;
            string s7 = RadioButtonList7.SelectedValue;
            string s8 = RadioButtonList8.SelectedValue;
            string s9 = RadioButtonList9.SelectedValue;
            string s10 = RadioButtonList10.SelectedValue; // get selected value from RadioButtonList and store it into a string

            if (s1 == "7") { score += 10; } // if the condition is met,  add +10 to score varaible
            if (s2 == "9") { score += 10; } // if the condition is met,  add +10 to score varaible
            if (s3 == "2") { score += 10; }
            if (s4 == "0") { score += 10; }
            if (s5 == "89") { score += 10; }
            if (s6 == "3") { score += 10; }
            if (s7 == "11") { score += 10; }
            if (s8 == "1") { score += 10; }
            if (s9 == "5") { score += 10; }// if the condition is met,  add +10 to score varaible
            if (s10 == "40") { score += 10; } // if the condition is met,  add +10 to score varaible

            DateTime.Now.ToString("dd/mm/yyyy"); // get the date from the system and format it as date/ month/ year
            DateTime.Now.ToString("hh:mm:ss"); // get the time from the system and format it as hour : minutes :seconds
            Session["Score"] = score.ToString(); // get score  and store as a session
            Session["Date"] = DateTime.Now.ToString("dd/mm/yyyy"); // get date and store it as session
            Session["Time"] = DateTime.Now.ToString("hh:mm:ss"); // get time and store it as session

            Response.Redirect("/HighScore.aspx"); //redirect to HighScore.aspx when smbtn_clcik button is pressed

        }

        protected void loggedAs_Click(object sender, EventArgs e)
        {
            Session["UserName"] = null; // set "UserName" Session as nothing to logout the user
            Response.Redirect("/MainLogin.aspx"); //redirect the user to the login page
        }
    }
}