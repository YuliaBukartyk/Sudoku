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
    public class BoardController : ControllerBase
    {
        [HttpGet("getsudokuboard")]

        public string GetSudokuBoard()
        {
            string returnString = "";
            //int gameMode = 0;
            List<Board> sudokuBoardList;
            //string str = "";
            int listSize = 0;
            List<int> sudokuList = new List<int>();
            BoardGenerator sudokuBoard = new BoardGenerator();
            
            
            ////////////////////////////////////////
            
            /////////////////////////////////////
            using (var _context = new sudokuLogic.Models.SudokuDBContext())
            {
                sudokuBoardList = _context.Boards.ToList(); // has the contect of the table 
                listSize = sudokuBoardList.Count();
                returnString = sudokuBoardList[listSize - 1].sudokuString;// now we have the last sodoku string created.
                //returnString = sudokuBoardList[listSize - 1].sudokuStringPlayer;// now we have the last sodoku string created.
                // make the string to be according to level
                _context.SaveChanges();
            }
            //return "023098673079790453680003939993860785950988830606060606454545478787544128541221213";
            return returnString;
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