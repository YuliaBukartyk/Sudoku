using SudokuClient.Commands;
using SudokuClient.Models;
using SudokuClient.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SudokuClient.ViewModels
{
    public class HardLevelViewModel : BaseLevelViewModel
    {

        public HardLevelViewModel(NavigationService MenuViewNavigationService, Game game) : base(MenuViewNavigationService, game)
        {
            Level = "Hard";
            sudokuString = Utils.Utils.SendHttpGetRequest("http://localhost:5000/Board/getsudokuboard?level=" + "hard");
            sudokuStringPlayer = Utils.Utils.SendHttpGetRequest("http://localhost:5000/Board/getsudokustringplayer?");
            FillCellsBoard();
            SaveTheGameCommand = new SaveTheGameCommand(_game, Cells, MenuViewNavigationService);
        }

    }
}
