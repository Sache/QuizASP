using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CwrkWebApp // provide scope to organise code into packages
{
    public partial class hardmode : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String userId = Session["UserName"] as String; // gets value from session to strig
            loggedAs.Text = "LOGOUT: " + userId; //  text put onto a button

            q1.Text = database.getQuestions("age14plus", "1"); // call method located in database.cs to set parameters  TABLE and ID for SQL execution
            q2.Text = database.getQuestions("age14plus", "2"); // call method located in database.cs to set parameters  TABLE and ID for SQL execution
            q3.Text = database.getQuestions("age14plus", "3");
            q4.Text = database.getQuestions("age14plus", "4");
            q5.Text = database.getQuestions("age14plus", "5");
            q6.Text = database.getQuestions("age14plus", "6"); // call method located in database.cs to set parameters  TABLE and ID for SQL execution
            q7.Text = database.getQuestions("age14plus", "7");
            q8.Text = database.getQuestions("age14plus", "8"); // call method located in database.cs to set parameters  TABLE and ID for SQL execution
            q9.Text = database.getQuestions("age14plus", "9");
            q10.Text = database.getQuestions("age14plus", "10"); // call method located in database.cs to set parameters  TABLE and ID for SQL execution

        }

        protected void sbmtbtn_Click(object sender, EventArgs e)
        {//  executes the content of the method an action is performed

            int score = 0; // 
            string s1 = RadioButtonList1.SelectedValue; // get selected value from the RadioButtonList 
            string s2 = RadioButtonList2.SelectedValue;  // get selected value from the RadioButtonList
            string s3 = RadioButtonList3.SelectedValue; // get selected value from the RadioButtonList
            string s4 = RadioButtonList4.SelectedValue;
            string s5 = RadioButtonList5.SelectedValue;
            string s6 = RadioButtonList6.SelectedValue;
            string s7 = RadioButtonList7.SelectedValue;
            string s8 = RadioButtonList8.SelectedValue; // get selected value from the RadioButtonList
            string s9 = RadioButtonList9.SelectedValue;
            string s10 = RadioButtonList10.SelectedValue; // get selected value from the RadioButtonList

            if (s1 == "4") { score += 10; } // if the condition is met, 10 is added into the integer score
            if (s2 == "6.6") { score += 10; } // if the condition is met, 10 is added into the integer score
            if (s3 == "324") { score += 10; }
            if (s4 == "20") { score += 10; }
            if (s5 == "9") { score += 10; }
            if (s6 == "4") { score += 10; }
            if (s7 == "3") { score += 10; }// if the condition is met, 10 is added into the integer score
            if (s8 == "2") { score += 10; }
            if (s9 == "1000") { score += 10; }
            if (s10 == "11.3") { score += 10; }// if the condition is met, 10 is added into the integer score

            DateTime.Now.ToString("dd/mm/yyyy"); // get date time from system and format
            DateTime.Now.ToString("hh:mm:ss"); // get data and time from the system and format
            Session["Score"] = score.ToString(); //  take score value and change it to string to store it as Session
            Session["Date"] = DateTime.Now.ToString("dd/mm/yyyy"); //  get date fromt the system and store as session
            Session["Time"] = DateTime.Now.ToString("hh:mm:ss"); // get time and store it as session

            Response.Redirect("/HighScore.aspx"); // redirect to high score page if the button is pressed
        }

        protected void loggedAs_Click(object sender, EventArgs e)
        {
            Session["UserName"] = null; // session value cleared to logout the user
            Response.Redirect("/MainLogin.aspx"); // redirects to the home page
        }
    }
}
