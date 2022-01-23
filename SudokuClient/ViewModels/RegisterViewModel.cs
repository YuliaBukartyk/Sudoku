using SudokuClient.Commands;
using SudokuClient.Models;
using SudokuClient.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace SudokuClient.ViewModels
{
    public class RegisterViewModel : BaseViewModel
    {
        public ICommand BackToEntryCommand { get; }
        public ICommand SubmitCommand { get; }

        private readonly User _user;
        private string _username;
        private string _password;
        private string _verificationPassword;

        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
                OnPropertyChanged(nameof(Username));
                _user.Name = _username;

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
                OnPropertyChanged(nameof(Password));
                _user.Password = _password;

            }
        }


        public string VerificationPassword
        {
            get
            {
                return _verificationPassword;
            }
            set
            {
                _verificationPassword = value;
                OnPropertyChanged(nameof(VerificationPassword));
                _user.VerificationPassword = _verificationPassword;
                
            }
        }


        public RegisterViewModel(NavigationService EntryViewNavigationService, NavigationService LogInViewNavigationService, User user)
        {
            _user = user;
            BackToEntryCommand = new NavigateCommand(EntryViewNavigationService);
            SubmitCommand = new SubmitCommand(_user, LogInViewNavigationService);

            
        }
    }
}
