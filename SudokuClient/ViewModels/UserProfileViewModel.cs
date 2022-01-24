using SudokuClient.Commands;
using SudokuClient.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace SudokuClient.ViewModels
{
    public class UserProfileViewModel : BaseViewModel
    {
        public ICommand ShowGamesHistoryViewCommand { get; }
        public UserProfileViewModel(NavigationService GamesHistoryViewNavigationService)
        {
            ShowGamesHistoryViewCommand = new NavigateCommand(GamesHistoryViewNavigationService);

        }
            
    }
    
    
}
