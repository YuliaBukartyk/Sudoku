using SudokuClient.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuClient.ViewModels
{
    public class NormalLevelGameViewModel : LevelsViewModel
    {
        public NormalLevelGameViewModel(NavigationService MenuViewNavigationService) : base(MenuViewNavigationService)
        {
            Level = "Normal";
            sudokuString = Utils.Utils.SendHttpGetRequest("http://localhost:5000/Board/getsudokuboard?level=" + "normal");
            sudokuStringPlayer = Utils.Utils.SendHttpGetRequest("http://localhost:5000/Board/getsudokustringplayer?");
            FillCellsBoard();
        }
    }
}
