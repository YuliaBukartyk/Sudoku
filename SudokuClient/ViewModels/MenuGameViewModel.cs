using SudokuClient.Commands;
using SudokuClient.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace SudokuClient.ViewModels
{
    public class MenuGameViewModel : BaseViewModel
    {

        public ICommand OpenGameLevelsViewCommand { get; }
        public ICommand ShowGamesHistoryViewCommand { get; }
        public ICommand BackToEntryCommand { get; }

        public MenuGameViewModel(NavigationService GameLevelsViewNavigationService, NavigationService GamesHistoryViewNavigationService, NavigationService EntryViewNavigationService)
        {
            OpenGameLevelsViewCommand = new NavigateCommand(GameLevelsViewNavigationService);
            ShowGamesHistoryViewCommand = new NavigateCommand(GamesHistoryViewNavigationService);
            BackToEntryCommand = new NavigateCommand(EntryViewNavigationService);
        }
    }
}
