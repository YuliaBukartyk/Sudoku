using SudokuClient.Commands;
using SudokuClient.Models;
using SudokuClient.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace SudokuClient.ViewModels
{
    public class LogInViewModel : BaseViewModel
    {
        public ICommand BackToEntryCommand { get; }
        public ICommand LogedToGameCommand { get; }

        private string _password;

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));

            }
        }


        public LogInViewModel(NavigationService EntryViewNavigationService, NavigationService MenuGameViewNavigationService)
        {
            BackToEntryCommand = new NavigateCommand(EntryViewNavigationService);
            LogedToGameCommand = new NavigateCommand(MenuGameViewNavigationService);
        }



    }
}
