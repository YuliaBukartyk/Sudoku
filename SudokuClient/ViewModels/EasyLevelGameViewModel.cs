using SudokuClient.Commands;
using SudokuClient.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using System.Windows.Threading;
using SudokuClient.Models;

namespace SudokuClient.ViewModels
{
    public class EasyLevelGameViewModel : BaseViewModel
    {
        public ICommand BackToMenuCommand { get; }

        public ICommand SaveTheGameCommand { get; }

        private readonly DispatcherTimer dispatcherTimer = null;

        private string _timerText;

        private int _totalSeconds = 0;

        private readonly Game _game;

        public string TimerText
        {
            get
            {
                return this._timerText;
            }
            set
            {
                this._timerText = value;
                OnPropertyChanged("TimerText");
            }
        }



        public EasyLevelGameViewModel(NavigationService MenuViewNavigationService)
        {
            _game = new Game();
            BackToMenuCommand = new NavigateCommand(MenuViewNavigationService);
            SaveTheGameCommand = new SaveTheGameCommand(_game);
            dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(DispatcherTimerTick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
        }

        private void DispatcherTimerTick(object sender, EventArgs e)
        {
            this._totalSeconds += 1;
            _game.Duraion = _totalSeconds;
            TimerText = string.Format("{0:hh\\:mm\\:ss}", TimeSpan.FromSeconds(this._totalSeconds).Duration());
            CommandManager.InvalidateRequerySuggested();
        }

    }
}
