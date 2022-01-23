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
        public IEnumerable<Game> AddGameInfo(string duration, string level)
        {
            using (var _context = new SudokuDBContext())
            {
                Game game = new Game();
                game.duration = duration;
                game.level = level;
                _context.Games.Add(game);
                _context.SaveChanges();

                return _context.Games.ToList();
            }
        }
    }
}