using SudokuClient.Commands;
using SudokuClient.Models;
using SudokuClient.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace SudokuClient.ViewModels
{
    public class RegisterViewModel : BaseViewModel
    {
        public ICommand BackToEntryCommand { get; }
        public ICommand SubmitCommand { get; }

        public User user;

        private string username;
        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
                OnPropertyChanged(nameof(Username));
                user.Name = username;

            }
        }

        private string password;
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
                OnPropertyChanged(nameof(Password));
                user.Password = password;

            }
        }


        public RegisterViewModel(NavigationService EntryViewNavigationService)
        {
            user = new User();
            BackToEntryCommand = new NavigateCommand(EntryViewNavigationService);
            SubmitCommand = new SubmitCommand(user);

        }
    }
}
