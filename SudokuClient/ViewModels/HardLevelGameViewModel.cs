using SudokuClient.Models;
using SudokuClient.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SudokuClient.ViewModels
{
    public class HardLevelGameViewModel : LevelsViewModel
    {

        public HardLevelGameViewModel(NavigationService MenuViewNavigationService) : base(MenuViewNavigationService)
        {
            //sudokuString = Utils.Utils.SendHttpGetRequest("http://localhost:5000/Board/getsudokuboard?");
            //sudokuStringPlayer = Utils.Utils.SendHttpGetRequest("http://localhost:5000/Board/getsudokuboard?");
            sudokuString = "223498673879797453681233939993860785951988831616162626454545478787544128541221213";
            sudokuStringPlayer = "023098673079790453680003939993860785950988830606060606454545478787544128541221213";
            FillCellsBoard();
        }

    }
}
