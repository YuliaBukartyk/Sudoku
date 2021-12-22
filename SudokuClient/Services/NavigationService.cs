using SudokuClient.Stores;
using SudokuClient.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuClient.Services
{
    public class NavigationService
    {
        private readonly NavigationStore navigationStore;
        private readonly Func<BaseViewModel> createViewModel;

        public NavigationService(NavigationStore navigationStore, Func<BaseViewModel> createViewModel)
        {
            this.navigationStore = navigationStore;
            this.createViewModel = createViewModel;
        }

        public void Navigate()
        {
            navigationStore.CurrentViewModel = createViewModel();
        }
    }
}
