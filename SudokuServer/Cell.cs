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
    public List<int> AvailableValues { get; set; }
    public int AvailableValuesCount { get; set; }
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



    // reset a cell with default values 
    public void reset()
    {
        Filled = false;
        Value = 0;
    }

    public void setValue(int num)
    {
        this.Value = num;
    }

    public void setRow(int num)
    {
        this.Row = num;
    }

    public void setColumn(int num)
    {
        this.Column = num;
    }

    public void setSquare(int num)
    {
        this.Square = num;
    }

    public void setIndex(int num)
    {
        this.Index = num;
    }
}
