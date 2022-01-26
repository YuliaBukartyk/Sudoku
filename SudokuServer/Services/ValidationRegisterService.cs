using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;


namespace SudokuServer.Services
{
    public class ValidationRegisterService : IValidationService
    {
        public bool IsValidated(string userName, string password)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=YROTBER-MOBL;Initial Catalog=SudokuDB;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("select * from Users where name = @name;");
                cmd.Parameters.AddWithValue("@name", userName);
                cmd.Connection = con;
                con.Open();

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                con.Close();

                bool usernameExists = ((ds.Tables.Count > 0) && (ds.Tables[0].Rows.Count > 0));

                if (usernameExists)
                {
                    return false;
                }
                else
                {
                    return true;

                }
            }
        }
    }
}