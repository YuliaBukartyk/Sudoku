using SudokuClient.Commands;
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

        public RegisterViewModel(NavigationService EntryViewNavigationService)
        {
            BackToEntryCommand = new NavigateCommand(EntryViewNavigationService);

        }
    }
}
