using System; // imports IDisposable objects from System
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CwrkWebApp // provide scope to organise code into packages
{
    public partial class mediummode : System.Web.UI.Page // inherit from System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String userId = Session["UserName"] as String; // get the value from Session named "UserName" and store it as a string on a variable
            loggedAs.Text = "LOGOUT: "+ userId; // input text onto LOGOUT button

            q1.Text = database.getQuestions("age11plus", "1"); //  call method located in database.cs to set parameters  TABLE and ID for SQL execution
            q2.Text = database.getQuestions("age11plus", "2"); //  call method located in database.cs to set parameters  TABLE and ID for SQL execution
            q3.Text = database.getQuestions("age11plus", "3");
            q4.Text = database.getQuestions("age11plus", "4");
            q5.Text = database.getQuestions("age11plus", "5");
            q6.Text = database.getQuestions("age11plus", "6");
            q7.Text = database.getQuestions("age11plus", "7");
            q8.Text = database.getQuestions("age11plus", "8");
            q9.Text = database.getQuestions("age11plus", "9");
            q10.Text = database.getQuestions("age11plus", "10");

        }

        protected void sbmtbtn_Click(object sender, EventArgs e)
        {
            int score = 0;
            string s1 = RadioButtonList1.SelectedValue;
            string s2 = RadioButtonList2.SelectedValue;// get selected value from RadioButtonList and store it into a string
            string s3 = RadioButtonList3.SelectedValue;// get selected value from RadioButtonList and store it into a string
            string s4 = RadioButtonList4.SelectedValue;// get selected value from RadioButtonList and store it into a string
            string s5 = RadioButtonList5.SelectedValue;
            string s6 = RadioButtonList6.SelectedValue;
            string s7 = RadioButtonList7.SelectedValue;
            string s8 = RadioButtonList8.SelectedValue;
            string s9 = RadioButtonList9.SelectedValue;
            string s10 = RadioButtonList10.SelectedValue;

            if (s1 == "2500") { score += 10; } // add 10 into score if the condition is met
            if (s2 == "440") { score += 10; } //  add 10 into score if answer is correct
            if (s3 == "4") { score += 10; }
            if (s4 == "121") { score += 10; }
            if (s5 == "6") { score += 10; }
            if (s6 == "3") { score += 10; }
            if (s7 == "5") { score += 10; }
            if (s8 == "8") { score += 10; }
            if (s9 == "9") { score += 10; }
            if (s10 == "488") { score += 10; }

            DateTime.Now.ToString("dd/mm/yyyy"); //get date from sysstem
            DateTime.Now.ToString("hh:mm:ss"); //get time from system
            Session["Score"] = score.ToString(); // initialise system
            Session["Date"] = DateTime.Now.ToString("dd/mm/yyyy");
            Session["Time"] = DateTime.Now.ToString("hh:mm:ss");

            Response.Redirect("/HighScore.aspx");  // redirect user to high score page
        }

        protected void loggedAs_Click(object sender, EventArgs e)
        {
            Session["UserName"] = null; // logout the user
            Response.Redirect("/MainLogin.aspx"); // redirect user to Man login page
        }
    }
}
