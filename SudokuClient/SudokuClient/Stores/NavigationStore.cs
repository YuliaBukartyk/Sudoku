using SudokuClient.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuClient.Stores
{
    public class NavigationStore
    {

        private BaseViewModel currentViewModel;

        public BaseViewModel CurrentViewModel
        {
            get => currentViewModel;
            set
            {          
                currentViewModel = value;
                OnCurrentViewModelChanged();
            }
        }

        private void OnCurrentViewModelChanged()
        {
            CurrentViewModelChanged?.Invoke();
        }

        public event Action CurrentViewModelChanged;
    }
}
