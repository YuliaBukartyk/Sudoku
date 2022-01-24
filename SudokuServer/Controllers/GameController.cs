using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using SudokuServer.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;



namespace SudokuServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GameController : ControllerBase
    {
        [HttpGet("addgameinfo")]
        public IEnumerable<Game> AddGameInfo(string duration, string level, string name)
        {
            using (var _context = new SudokuDBContext())
            {
                Game game = new Game();
                game.duration = duration;
                game.level = level;
                game.name = name;
                _context.Games.Add(game);
                _context.SaveChanges();
                var x = _context.Games;
                return _context.Games.ToList();
            }
        }

        [HttpGet("getgameinfo")]
        public IEnumerable<Game> GetGameInfo()
        {
            using (var _context = new SudokuDBContext())
            {
                //return _context.Games.ToList();

               List<Game> GamesHistory = _context.Games
                   .Where(g => g.name == "Yael")
                   .Select(group => new Game() 
                   {
                       duration = group.duration,
                       level = group.level,
                   }).ToList();

                return GamesHistory;
            }
        }
    }
}