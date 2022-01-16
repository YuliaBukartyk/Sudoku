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
    public class BoardController : ControllerBase
    {
        [HttpGet("getsudokuboard")]

        public string GetSudokuBoard()
        {
            return "023098673079790453680003939993860785950988830606060606454545478787544128541221213";
        }

        //public IEnumerable<Board> GetSudokuBoard(string level)
        //{
        //    if (level == "Easy")
        //    {
        //        
        //    }
        //}
    }
}