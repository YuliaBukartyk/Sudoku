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

        public ICommand NormalLevelGameCommand { get; }

        public ICommand HardLevelGameCommand { get; }

        public ICommand BackToEntryCommand { get; }


        public GameLevelsViewModel(NavigationService EasyLevelGameViewNavigationService, NavigationService NormalLevelGameViewNavigationService,
                                    NavigationService HardLevelGameViewNavigationService, NavigationService EntryViewNavigationService)
        {

            EasyLevelGameCommand = new NavigateCommand(EasyLevelGameViewNavigationService);

            NormalLevelGameCommand = new NavigateCommand(NormalLevelGameViewNavigationService);

            HardLevelGameCommand = new NavigateCommand(HardLevelGameViewNavigationService);

            BackToEntryCommand = new NavigateCommand(EntryViewNavigationService);

        }
    }
}
