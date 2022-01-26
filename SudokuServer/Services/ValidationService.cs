using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;


namespace SudokuServer.Services
{
    public class ValidationService : IValidationService //using Facade design pattern

    {
        public bool IsValidated(string userName, string password)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=YROTBER-MOBL;Initial Catalog=SudokuDB;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("select * from Users where name = @name and password = @password;");
                cmd.Parameters.AddWithValue("@name", userName);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Connection = con;
                con.Open();

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                con.Close();

                bool loginSuccessful = ((ds.Tables.Count > 0) && (ds.Tables[0].Rows.Count > 0));

                if (loginSuccessful)
                {
                    //return "true";
                    return true;
                }
                else
                {
                    return false;
                    // check what wrong - username or password
                    //using (SqlConnection con1 = new SqlConnection(@"Data Source=YROTBER-MOBL;Initial Catalog=SudokuDB;Integrated Security=True")) // using is used here because these objects implement IDisposable
                    //{
                    //    con1.Open(); // Using will take care of closing the connection when it leaves scope.
                    //    using (SqlCommand cmd1 = new SqlCommand("SELECT * FROM Users WHERE name = @usename", con1))
                    //    {
                    //        cmd1.Parameters.AddWithValue("@usename", userName);
                    //        using (SqlDataReader dr = cmd1.ExecuteReader())
                    //        {
                    //            if (dr.Read())
                    //            {
                    //                //return "password is invalid";
                    //                return false;
                    //            }
                    //            //else
                    //            //{
                    //            //    return "no such user name";
                    //            //}
                    //        }
                    //    }
                    //}
                }
            }
        }
    }
}