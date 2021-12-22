using SudokuClient.Commands;
using SudokuClient.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;


namespace SudokuClient.ViewModels
{
    public class GameLevelsViewModel : BaseViewModel
    {
        public ICommand EasyLevelGameCommand { get; }
        public ICommand BackToEntryCommand { get; }


        public GameLevelsViewModel(NavigationService EasyLevelGameViewNavigationService, NavigationService EntryViewNavigationService)
        {

            EasyLevelGameCommand = new NavigateCommand(EasyLevelGameViewNavigationService);
            BackToEntryCommand = new NavigateCommand(EntryViewNavigationService);

        }
    }
}
