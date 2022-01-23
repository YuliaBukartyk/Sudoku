using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SudokuServer.Controllers
{
    public class VerifyUserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
