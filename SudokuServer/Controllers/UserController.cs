using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using SudokuServer.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace SudokuServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        [HttpGet("adduser")]
        public IEnumerable<User> AddUser(string name, string password)
        {
            
            using (var _context = new SudokuDBContext())
            {
                User user = new User();
                user.name = name;
                user.password = password;

                _context.Users.Add(user);
                _context.SaveChanges();

                return _context.Users.ToList();
            }
        }


        [HttpGet("verifyuser")]
        public string VerifyUser(string name, string password)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-N53TO97U;Initial Catalog=Sudoku;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("select * from Users where name = @name and password = @password;");
                cmd.Parameters.AddWithValue("@name", name);
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
                    return "true";
                }
                else
                {
                    return "false";
                }
            }


                /*
                User user = new User();
                user.name = name;

                _context.Users.Add(user);
                _context.SaveChanges();

                return _context.Users.ToList();
                */

                //return false;
            
        }


    }
}
