using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;


namespace SudokuServer.Models
{
    public class Board
    {
        [Key]
        public int Id { get; set; }

        //public List<int> sudokuValues;

        public string sudokuString { get; set; } // the sudoku string

        public string sudokuStringPlayer { get; set; } // with zeros to represent empty cells

        // public string sudokuValuesPlayer;




    }
}