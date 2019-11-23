using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Configuration;

namespace CwrkWebApp // provide scope to organise code into packages
{
    public static class database
    {

        public static OleDbConnection GetConnection() // initalise OleDb connection method for database connection
        { 
            string connString;
            connString = System.Configuration.ConfigurationManager.ConnectionStrings["database"].ConnectionString; //get database location
            var newCON = new OleDbConnection(connString); // open connection
            return newCON;
        }

        public static bool pullUsernameandPass(string username, string password) // method to get username and password
        {

            OleDbConnection myConnection = GetConnection(); // get database path and connect to it
            string executeQueryStr = "SELECT * FROM UserInfo WHERE UserName = '" + username + "' AND Password = '" + password + "'"; // SQL statement to get username and password fromt the database
            OleDbCommand dbCommand = new OleDbCommand(executeQueryStr, myConnection); // convert string into a OleDbCommand
            dbCommand.Connection = myConnection; // initalise connection


            try
            {
                myConnection.Open(); // open connection in database
                OleDbDataReader reader = dbCommand.ExecuteReader(); //  // 

                if (reader.HasRows) 
                {
                    return true;

                }
                else
                {
                    return false;
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot Write Query To Database", ex); // run if there is exception, output in console
            }
            finally
            {

                myConnection.Close();
            }


            return false;
        }
        public static string getQuestions(string ageGroup, string id) //gets questions from database table
        {


            OleDbConnection myConnection = GetConnection(); // get connection
            string query = "SELECT * FROM "+ ageGroup +" WHERE QID = '" + id + "'"; // SQL statement to get question from database
            OleDbCommand command = new OleDbCommand(query, myConnection); // convert string SQL STATEMENT into a OleDbCommand 
            command.Connection = myConnection;

            try
            {
                myConnection.Open();
                OleDbDataReader reader = command.ExecuteReader(); //read data from the database

                if (reader.Read())
                {
                    return reader.GetString(1).ToString(); // return second column


                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Error:"+e);
            }

            myConnection.Close();
            return "ERRROR!!!!!";


        }
        public static string storeScore(string user, string score, string date, string time, string medal) { // method to get high score info
            try
            {
                OleDbConnection myConnection = GetConnection();
                OleDbCommand dbCommand = new OleDbCommand();
                
                dbCommand.CommandText = "insert into HallOfFame ([UserName],[Score],[Date],[Time],[Medal]) values (?,?,?,?,?)"; // command to get high score data
                dbCommand.Parameters.AddWithValue("@user", user); //adds variable "user" value to the SQL statement
                dbCommand.Parameters.AddWithValue("@score", score); //  adds variable "score" value to the SQL statement
                dbCommand.Parameters.AddWithValue("@date", date);
                dbCommand.Parameters.AddWithValue("@time", time);
                dbCommand.Parameters.AddWithValue("@time", medal);
                dbCommand.Connection = myConnection;
                myConnection.Open();
                dbCommand.ExecuteNonQuery();
                myConnection.Close();
            }
            catch (Exception ex)
            {

            }
            return "ERROR";


        }
    }
}
