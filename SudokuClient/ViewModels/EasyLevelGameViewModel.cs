using SudokuClient.Commands;
using SudokuClient.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using System.Windows.Threading;
using SudokuClient.Models;
using System.Collections.ObjectModel;

namespace SudokuClient.ViewModels
{
    public class EasyLevelGameViewModel : LevelsViewModel
    {

        public EasyLevelGameViewModel(NavigationService MenuViewNavigationService, Game game) : base(MenuViewNavigationService, game)
        {
            Level = "Easy";
            sudokuString = Utils.Utils.SendHttpGetRequest("http://localhost:5000/Board/getsudokuboard?level=" + "easy");
            sudokuStringPlayer = Utils.Utils.SendHttpGetRequest("http://localhost:5000/Board/getsudokustringplayer?");
            //sudokuString = "223498673879797453681233939993860785951988831616162626454545478787544128541221213";
            //sudokuStringPlayer = "023098673079790453680003939993860785950988830606060606454545478787544128541221213";
            FillCellsBoard();

        }
    }
}
