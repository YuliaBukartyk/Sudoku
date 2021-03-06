using SudokuClient.Services;
using SudokuClient.Stores;
using SudokuClient.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuClient.Commands
{
    class NavigateCommand : CommandBase //using Command design pattern
    {

        private readonly NavigationService navigationService;

        public NavigateCommand(NavigationService navigationService)
        {
            this.navigationService = navigationService;
        }

        public override void Execute(object parameter)
        {
            navigationService.Navigate();
          
        }
    }
}
