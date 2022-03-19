using System;
using System.Collections.Generic;
using System.Text;

public class Cell
{
    public bool Filled { get; set; } // true if a cell has a value, false if doesnt. default value is false for a new game.
    public int Value { get; set; } // default value of a new sudoku board is 0 to represent unfilled cell. possible numbers are 0-9.
    public int Square { get; set; }
    public int Row { get; set; }
    public int Column { get; set; }
    public int Index { get; set; } // the index number from 1 to 81 of the cell 



    // constructor for all variables
    public Cell()
    {
        this.Index = 0;
        this.Value = 0;
        this.Square = 0;
        Row = 0;
        Column = 0;
        Filled = false;
    }

}
