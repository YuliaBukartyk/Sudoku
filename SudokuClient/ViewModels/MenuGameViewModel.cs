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

        public ICommand OpenUserProfileViewCommand { get; }

        public MenuGameViewModel(NavigationService GameLevelsViewNavigationService, NavigationService UserProfileViewNavigationService)
        {
            OpenGameLevelsViewCommand = new NavigateCommand(GameLevelsViewNavigationService);
            OpenUserProfileViewCommand = new NavigateCommand(UserProfileViewNavigationService);
        }
    }
}
