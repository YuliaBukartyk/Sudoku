using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuClient.Models
{
    public class Board
    {

        private string _sudokuString;  // the sudoku string

        private string _sudokuStringPlayer; // with zeros to represent empty cells

        public string SudokuString
        {
            get
            {
                return this._sudokuString;
            }
            set
            {
                this._sudokuString = value;
            }
        }

        public string SudokuStringPlayer
        {
            get
            {
                return this._sudokuStringPlayer;
            }
            set
            {
                this._sudokuStringPlayer = value;
            }
        }
    }
}
