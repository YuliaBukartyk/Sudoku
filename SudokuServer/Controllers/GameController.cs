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
        public IEnumerable<Game> AddGameInfo(string duration, string level, string name, string result)
        {
            using (var _context = new SudokuDBContext())
            {
                Game game = new Game();
                game.duration = duration;
                game.level = level;
                game.name = name;
                game.result = result;
                _context.Games.Add(game);
                _context.SaveChanges();
                var x = _context.Games;
                return _context.Games.ToList();
            }
        }

        [HttpGet("getgameinfo")]
        public IEnumerable<Game> GetGameInfo(string name)
        {
            using (var _context = new SudokuDBContext())
            {
               List<Game> GamesHistory = _context.Games
                   .Where(g => g.name == name)
                   .Select(group => new Game() 
                   {
                       duration = group.duration,
                       level = group.level,
                       result = group.result,
                   }).ToList();

                return GamesHistory;
            }
        }
    }
}