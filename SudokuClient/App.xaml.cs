using SudokuClient.Models;
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
        private readonly Game game;
        private readonly User user;

        public App()
        {
            navigationStore = new NavigationStore();
            game = new Game();
            user = new User();
            game.User = user;
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
            return new LogInViewModel(new NavigationService(navigationStore, CreateEntryViewModel), new NavigationService(navigationStore, CreateMenuGameViewModel), user);
        }

        private RegisterViewModel CreateRegisterViewModel()
        {
            return new RegisterViewModel(new NavigationService(navigationStore, CreateEntryViewModel), new NavigationService(navigationStore, CreateLogInViewModel), user);
        }

        private GameLevelsViewModel CreateGameLevelsViewModel()
        {
            return new GameLevelsViewModel(new NavigationService(navigationStore, CreateEasyLevelGameViewModel), new NavigationService(navigationStore, CreateNormalLevelGameViewModel),
                new NavigationService(navigationStore, CreateHardLevelGameViewModel), new NavigationService(navigationStore, CreateEntryViewModel));
        }

        private EasyLevelGameViewModel CreateEasyLevelGameViewModel()
        {
            return new EasyLevelGameViewModel(new NavigationService(navigationStore, CreateMenuGameViewModel), game);
        }

        private NormalLevelGameViewModel CreateNormalLevelGameViewModel()
        {
            return new NormalLevelGameViewModel(new NavigationService(navigationStore, CreateMenuGameViewModel), game);
        }

        private HardLevelGameViewModel CreateHardLevelGameViewModel()
        {
            return new HardLevelGameViewModel(new NavigationService(navigationStore, CreateMenuGameViewModel), game);
        }

        private MenuGameViewModel CreateMenuGameViewModel()
        {
            return new MenuGameViewModel(new NavigationService(navigationStore, CreateGameLevelsViewModel), new NavigationService(navigationStore, CreateUserProfileViewModel));
        }

        private UserProfileViewModel CreateUserProfileViewModel()
        {
            return new UserProfileViewModel();
        }

    }
}
