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
            sudokuString = Utils.Utils.SendHttpGetRequest("http://localhost:5000/Board/getsudokuboard?level=" + "hard");
            sudokuStringPlayer = Utils.Utils.SendHttpGetRequest("http://localhost:5000/Board/getsudokustringplayer?");
            FillCellsBoard();
        }

    }
}
