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

        public string GetSudokuBoard(string level)
        {
            string returnString = "";
            List<Board> sudokuBoardList;
            int listSize = 0;
            List<int> sudokuList = new List<int>();
            BoardGenerator sudokuBoard = new BoardGenerator(level);
            //sudokuBoard.DifficultySudokuString(level);
            
            using (var _context = new sudokuLogic.Models.SudokuDBContext())
            {
                sudokuBoardList = _context.Boards.ToList(); // has the contect of the table 
                listSize = sudokuBoardList.Count();
                returnString = sudokuBoardList[listSize - 1].sudokuString;// now we have the last sodoku string created.
                //returnStringPlayer = sudokuBoardList[listSize - 1].sudokuStringPlayer;
                //returnString = sudokuBoardList[listSize - 1].sudokuStringPlayer;// now we have the last sodoku string created.
                // make the string to be according to level
                _context.SaveChanges();
            }
            return returnString;
        }


        [HttpGet("getsudokustringplayer")]
        public string GetSudokuStringPlayer()
        {   
            string returnStringPlayer = "";
            List<Board> sudokuBoardList;
            int listSize = 0;
            List<int> sudokuList = new List<int>();

            using (var _context = new sudokuLogic.Models.SudokuDBContext())
            {
                sudokuBoardList = _context.Boards.ToList(); // has the contect of the table 
                listSize = sudokuBoardList.Count();
                returnStringPlayer = sudokuBoardList[listSize - 1].sudokuStringPlayer;
                //_context.SaveChanges();
            }
            return returnStringPlayer;
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