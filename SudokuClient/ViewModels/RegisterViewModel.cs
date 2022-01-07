﻿using SudokuClient.Commands;
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

        private readonly User _user;
        private string _username;
        private string _password;

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


        public RegisterViewModel(NavigationService EntryViewNavigationService)
        {
            _user = new User();
            BackToEntryCommand = new NavigateCommand(EntryViewNavigationService);
            SubmitCommand = new SubmitCommand(_user);

        }
    }
}
