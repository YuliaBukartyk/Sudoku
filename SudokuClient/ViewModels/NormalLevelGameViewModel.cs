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
            sudokuString = Utils.Utils.SendHttpGetRequest("http://localhost:5000/Board/getsudokuboard?");
            sudokuStringPlayer = Utils.Utils.SendHttpGetRequest("http://localhost:5000/Board/getsudokuboard?");
            FillCellsBoard();
        }
    }
}
