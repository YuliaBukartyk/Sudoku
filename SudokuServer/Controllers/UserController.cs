using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using SudokuServer.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using SudokuServer.Services;

namespace SudokuServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILoginService _login;

        public UserController(ILoginService login)
        {
            _login = login;
        }
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

            if (_login.CanLogin(name, password))
            {
                return "true";
            }
            else
            {
                return "false";
            }
        }


        [HttpGet("verifyuniqueusername")]
        public string VerifyUniqueUsername(string name)
        {

            using (SqlConnection con = new SqlConnection(@"Data Source=YROTBER-MOBL;Initial Catalog=SudokuDB;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("select * from Users where name = @name;");
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Connection = con;
                con.Open();

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                con.Close();

                bool usernameExists = ((ds.Tables.Count > 0) && (ds.Tables[0].Rows.Count > 0));

                if (usernameExists)
                {
                    return "UserName not available";
                }
                else
                {
                    return "successfully registered";

                }
            }
        }

    }
}
