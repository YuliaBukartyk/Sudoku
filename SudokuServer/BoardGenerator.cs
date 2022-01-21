using System;
using SudokuServer.Models;
using System.Collections.Generic;
using System.Text;
//using sudokuLogic.Models;
//using SudokuServer.Models;

public class BoardGenerator
{
	
	public Cell[,] sudokuBoard { get; set; } // created a 2 dimension array to represent the sudoku board
    Random rand = new Random();
    private Board board;
    Random randomValue = new Random(); // range (1,10)	
	
	public BoardGenerator()
	{
        List<int> returnList = new List<int>();
        returnList = SudokuBoardGenerator(true);

    }
    
    public List<int> SudokuBoardGenerator(bool fillBoard)
    {
        //Cell cell = new Cell();
        board = new Board();

        List<int> returnList = new List<int>();
        sudokuBoard = new Cell[9, 9];
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                sudokuBoard[i, j] = new Cell();

            }
        }

        initializeCellValues(); // put default values in cells
        if (fillBoard)
        {
            if (solveSudoku())
            {

                printBoard();
                makeListOfValues();

            }
            else
            {
                Console.WriteLine("No solution\n");
                return returnList;
            }

        }
        return returnList;
    }

    public void PopulateCellArray()
    {
        int index = 0;
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                sudokuBoard[i, j].Index = index;
                index++;
                sudokuBoard[i, j].Row = i;
                sudokuBoard[i, j].Column = j;
                sudokuBoard[i, j].Square = calculateSquareIndex(i, j);
            }
        }
    }


    public bool solveSudoku()
    {
        int row = -1;
        int column = -1;
        int valueToTry = -1;
        bool boardIsEmpty = false;
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                if (sudokuBoard[i, j].Value == 0)

                {
                    row = i;
                    column = j;

                    // We still have some remaining
                    // missing values in Sudoku
                    //isEmpty = false;
                    boardIsEmpty = true;
                    break;
                }
            }
            if (boardIsEmpty)
            {
                break;
            }
        }

        // no empty space left
        if (!boardIsEmpty)
        {
            return true;
        }

        // else for each-row backtrack
        // now choose randomly a valid number 

        List<int> allNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        for (int num = 0; num < 9; num++)

        {
            // now need to randomly choose a number of the valid values available for this cell.
            // if the value is valid, update the list, the count and asiign the value.
            // else, remove value from list, and choose again until the list is empty.
            // generate a random value;
            valueToTry = randomValue.Next(1, 10);
            if (allNumbers.IndexOf(valueToTry) == -1) // the number already been checked
            {
                while (allNumbers.IndexOf(valueToTry) != -1)
                    valueToTry = randomValue.Next(1, 10);
            }
            allNumbers.Remove(valueToTry);
            if (checkIfValid(row, column, sudokuBoard[row, column].Index, valueToTry))
            {
                sudokuBoard[row, column].Value = valueToTry;
                //Console.WriteLine("im in cell " + row + " , " + column + "with the value " + valueToTry + "\n");

                if (solveSudoku())
                {
                    return true;
                }
                else
                {
                    sudokuBoard[row, column].Value = 0;
                    //Console.WriteLine("im in cell " + row + " , " + column + "back to ZERO \n");

                }
            }
        }
        return false; // no valid solution
    }


    public bool checkIfValid(int row, int column, int indexCell, int valueToCheck)
    {

        //return (checkRow(row, valueToCheck) && checkColumn(column, valueToCheck) && checkUpdateSquare(indexCell, valueToCheck, false));
        // Row has the unique (row-clash)
        for (int d = 0; d < 9; d++)
        {

            // Check if the number
            // we are trying to
            // place is already present in
            // that row, return false;
            if (sudokuBoard[row, d].Value == valueToCheck)
            {
                return false;
            }
        }

        // Column has the unique numbers (column-clash)
        for (int r = 0; r < 9; r++)
        {

            // Check if the number 
            // we are trying to
            // place is already present in
            // that column, return false;
            if (sudokuBoard[r, column].Value == valueToCheck)
            {
                return false;
            }
        }

        // corresponding square has
        // unique number (box-clash)
        int sqrt = (int)Math.Sqrt(9);
        int boxRowStart = row - row % sqrt;
        int boxColStart = column - column % sqrt;

        for (int r = boxRowStart; r < boxRowStart + sqrt; r++)
        {
            for (int d = boxColStart; d < boxColStart + sqrt; d++)
            {
                if (sudokuBoard[r, d].Value == valueToCheck)
                {
                    return false;
                }
            }
        }

        // it's safe, no conflicts on row, column or square
        return true;

        //return (checkRow(row, valueToCheck) && checkColumn(column, valueToCheck) && checkUpdateSquare(indexCell, valueToCheck, false));
    }


    public int calculateSquareIndex(int row, int column) //TODO check
    {
        if (row / 3 == 0 && column / 3 == 0)
            return 0;
        else if (row / 3 == 0 && column / 3 == 1)
            return 1;
        else if (row / 3 == 0 && column / 3 == 2)
            return 2;
        else if (row / 3 == 1 && column / 3 == 0)
            return 3;
        else if (row / 3 == 1 && column / 3 == 1)
            return 4;
        else if (row / 3 == 1 && column / 3 == 2)
            return 5;
        else if (row / 3 == 2 && column / 3 == 0)
            return 6;
        else if (row / 3 == 2 && column / 3 == 1)
            return 7;
        else if (row / 3 == 2 && column / 3 == 2)
            return 8;
        else
            return -1; //error value
    }

    public void printBoard()
    {
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                Console.Write("( " + sudokuBoard[i, j].Value + " )");
                if (j == 8)
                    Console.WriteLine("\n");
            }
        }

    }


    // function to initialize each cell with the relevant values for rows number, column, square and index. 
    public void initializeCellValues()
    {
        int index = 1; // is the index number of each cell. from 1 to 81.
                       //List<int> allNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        for (int i = 0; i < 9; i++) // i is rows in the grid
        {
            for (int j = 0; j < 9; j++) // j is columns in the grid
            {
                sudokuBoard[i, j].Row = i;
                sudokuBoard[i, j].Column = j;
                sudokuBoard[i, j].Index = index;
                index++;
                sudokuBoard[i, j].Filled = false;
                sudokuBoard[i, j].Square = calculateSquareIndex(i, j);


            }
        }
    }



    public void DifficultySudokuString()
    {
        // easyMode
        string gameMode = "";

        int cellsToHide = 32;
        int index = 0;
        string playerString = "";
        List<char> playerList = new List<char>();

        if (gameMode.Equals("easy"))
        {
            cellsToHide = 32;
        }
        else if (gameMode.Equals("normal"))
        {
            cellsToHide = 44;
        }
        else if (gameMode.Equals("hard"))
        {
            cellsToHide = 50;
        }

        

        for (int i = 0; i < 81; i++)
        {
            //index = rand.Next(0,81);
            //playerString = board.sudokuString.Substring(0, 1);
            playerList.Add(board.sudokuString[i]); // get the i char of string

        }

        for (int i = 0; i < cellsToHide; i++)
        {
            index = rand.Next(0, 81);
            playerList[index] = '0'; // change random cells according to difficulty level to zero, to hide from player

        }

        for (int i = 0; i < 81; i++)
        {
            playerString = playerString + playerList[i];
            board.sudokuStringPlayer = board.sudokuStringPlayer + playerList[i].ToString();

        }

        playerString = playerString + "";
        //board.sudokuStringPlayer = board.sudokuStringPlayer + playerString;
        //playerString = array.ToString();
        //return playerString;

    }


    public void makeListOfValues()
    {
        int i = 0;
        int j = 0;
        for (i = 0; i < 9; i++)
        {
            for (j = 0; j < 9; j++)
            {
                //sudokuString = sudokuString + sudokuBoard[i, j].Value.ToString();
                board.sudokuString = board.sudokuString + sudokuBoard[i, j].Value.ToString();
            }
        }
        DifficultySudokuString();

        // enters to the DB the board created
        using (var _context = new sudokuLogic.Models.SudokuDBContext())
        {

            _context.Boards.Add(board);

            _context.SaveChanges();

        }

    }










}
