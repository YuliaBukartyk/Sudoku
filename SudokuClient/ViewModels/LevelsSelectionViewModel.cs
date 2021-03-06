using SudokuClient.Commands;
using SudokuClient.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;


namespace SudokuClient.ViewModels
{
    public class LevelsSelectionViewModel : BaseViewModel
    {
        public ICommand EasyLevelGameCommand { get; }

        public ICommand NormalLevelGameCommand { get; }

        public ICommand HardLevelGameCommand { get; }

        public ICommand BackToMenuCommand { get; }


        public LevelsSelectionViewModel(NavigationService EasyLevelGameViewNavigationService, NavigationService NormalLevelGameViewNavigationService,
                                    NavigationService HardLevelGameViewNavigationService, NavigationService MenuGameViewNavigationService)
        {

            EasyLevelGameCommand = new NavigateCommand(EasyLevelGameViewNavigationService);

            NormalLevelGameCommand = new NavigateCommand(NormalLevelGameViewNavigationService);

            HardLevelGameCommand = new NavigateCommand(HardLevelGameViewNavigationService);

            BackToMenuCommand = new NavigateCommand(MenuGameViewNavigationService);

        }
    }
}
