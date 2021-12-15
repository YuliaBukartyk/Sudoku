using SudokuClient.Services;
using SudokuClient.Stores;
using SudokuClient.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace SudokuClient
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly NavigationStore navigationStore;

        public App()
        {
            navigationStore = new NavigationStore();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            navigationStore.CurrentViewModel = CreateEntryViewModel();

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(navigationStore)

            };
            MainWindow.Show();

            base.OnStartup(e);
        }




        private EntryViewModel CreateEntryViewModel()
        {
            return new EntryViewModel(new NavigationService(navigationStore,CreateLogInViewModel), new NavigationService(navigationStore, CreateRegisterViewModel));
        }
        private LogInViewModel CreateLogInViewModel()
        {
            return new LogInViewModel(new NavigationService(navigationStore, CreateEntryViewModel));
        }

        private RegisterViewModel CreateRegisterViewModel()
        {
            return new RegisterViewModel(new NavigationService(navigationStore, CreateEntryViewModel));
        }


    }
}
