using SudokuClient.Commands;
using SudokuClient.Services;
using SudokuClient.Stores;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace SudokuClient.ViewModels
{
    public class EntryViewModel : BaseViewModel
    {
        public ICommand LogInCommand { get; }
        public ICommand RegisterCommand { get; }

        public EntryViewModel(NavigationService LogInViewNavigationService, NavigationService RegisterViewNavigationService)
        {
            LogInCommand = new NavigateCommand(LogInViewNavigationService);
            RegisterCommand = new NavigateCommand(RegisterViewNavigationService);
        }
    }
}
