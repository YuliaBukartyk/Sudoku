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
        private string _name;
        private User user;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                user.Name = Name;
                OnPropertyChanged(nameof(Name));

            }
        }

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
                user.Password = Password;
                OnPropertyChanged(nameof(Password));

            }
        }


        public LogInViewModel(NavigationService EntryViewNavigationService, NavigationService MenuGameViewNavigationService)
        {
            user = new User();
            BackToEntryCommand = new NavigateCommand(EntryViewNavigationService);
            LogedToGameCommand = new LogedToGameCommand(user, MenuGameViewNavigationService);
        }



    }
}
