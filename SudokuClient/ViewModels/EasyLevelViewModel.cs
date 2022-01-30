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
    public class EasyLevelViewModel : BaseLevelViewModel
    {

        public EasyLevelViewModel(NavigationService MenuViewNavigationService, Game game) : base(MenuViewNavigationService, game)
        {
            Level = "Easy";
            sudokuString = Utils.Utils.SendHttpGetRequest("http://localhost:5000/Board/getsudokuboard?level=" + "easy");
            sudokuStringPlayer = Utils.Utils.SendHttpGetRequest("http://localhost:5000/Board/getsudokustringplayer?");
            FillCellsBoard();
            SaveTheGameCommand = new SaveTheGameCommand(_game, Cells, MenuViewNavigationService);


        }
    }
}
