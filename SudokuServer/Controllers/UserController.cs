using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SudokuServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SudokuServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        [HttpGet("adduser")]
        public IEnumerable<User> AddUser(string name)
        {
            using (var _context = new DataContext())
            {
                User user = new User();
                user.name = name;

                _context.Users.Add(user);
                _context.SaveChanges();




                return _context.Users.ToList();
            }
        }


    }
}
