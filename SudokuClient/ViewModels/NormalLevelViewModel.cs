using SudokuClient.Models;
using SudokuClient.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuClient.ViewModels
{
    public class NormalLevelViewModel : BaseLevelViewModel
    {
        public NormalLevelViewModel(NavigationService MenuViewNavigationService, Game game) : base(MenuViewNavigationService, game)
        {
            Level = "Normal";
            sudokuString = Utils.Utils.SendHttpGetRequest("http://localhost:5000/Board/getsudokuboard?level=" + "normal");
            sudokuStringPlayer = Utils.Utils.SendHttpGetRequest("http://localhost:5000/Board/getsudokustringplayer?");
            FillCellsBoard();
        }
    }
}
