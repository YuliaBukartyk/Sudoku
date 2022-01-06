using Microsoft.AspNetCore.Mvc;
using SudokuServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace SudokuServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GameController : ControllerBase
    {
        [HttpGet("addgameinfo")]
        public IEnumerable<Game> AddGameInfo(int duration, string level)
        {
            using (var _context = new DataContext())
            {
                Game game = new Game();


                // _context.Users.Add();
                //  _context.SaveChanges();

                return _context.Games.ToList();
            }
        }
    }
}