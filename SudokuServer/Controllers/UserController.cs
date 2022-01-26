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
        private readonly IRegisterService _register;

        public UserController(ILoginService login, IRegisterService register)
        {
            _login = login;
            _register = register;
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
        public string VerifyUniqueUsername(string name, string password)
        {
            if (_register.CanRegister(name, password))
            {
                return "true";
            }
            else
            {
                return "false";
            }

        }

    }
}
