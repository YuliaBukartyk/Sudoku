using SudokuClient.Commands;
using SudokuClient.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace SudokuClient.ViewModels
{
    public class EasyLevelGameViewModel : BaseViewModel
    {
        public ICommand BackToMenuCommand { get; }

        public EasyLevelGameViewModel(NavigationService MenuViewNavigationService)
        {
            BackToMenuCommand = new NavigateCommand(MenuViewNavigationService);
        }

    }
}
