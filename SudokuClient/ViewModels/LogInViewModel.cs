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

        //private readonly User user;

        
        public LogInViewModel(NavigationService EntryViewNavigationService)
        {
            BackToEntryCommand = new NavigateCommand(EntryViewNavigationService);

        }



    }
}
