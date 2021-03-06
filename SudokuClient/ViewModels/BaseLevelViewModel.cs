using SudokuClient.Commands;
using SudokuClient.Models;
using SudokuClient.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using System.Windows.Threading;

namespace SudokuClient.ViewModels
{
    public class BaseLevelViewModel : BaseViewModel
    {
        public ICommand BackToMenuCommand { get; }
        public ICommand SaveTheGameCommand { get; set; }

        public DispatcherTimer dispatcherTimer = null;

        public string _timerText;

        public int _totalSeconds = 0;

        public string sudokuString;

        public string sudokuStringPlayer;

        public Game _game;

        public string _level;
        public Cell[] Cells { get; set; }

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
        public string Level
        {
            get
            {
                return this._level;
            }
            set
            {
                this._level = value;
                _game.Level = Level;
                OnPropertyChanged(nameof(Level));
                
            }
        }

        public BaseLevelViewModel(NavigationService MenuViewNavigationService, Game game)
        {
            _game = game;
            _game.EndGame = false;
            _game.IsSuccess = false;
            BackToMenuCommand = new NavigateCommand(MenuViewNavigationService);
            dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(DispatcherTimerTick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
        }

        public void DispatcherTimerTick(object sender, EventArgs e)
        {
            this._totalSeconds += 1;
            TimerText = string.Format("{0:hh\\:mm\\:ss}", TimeSpan.FromSeconds(this._totalSeconds).Duration());
            _game.Duration = TimerText;
            CommandManager.InvalidateRequerySuggested();
            if (_game.EndGame)
            {
                dispatcherTimer.Stop();
            }
        }


        public void FillCellsBoard()
        {
            Cells = new Cell[sudokuStringPlayer.Length];


            for (int i = 0; i < sudokuStringPlayer.Length; i++)
            {
                Cells[i] = new Cell();
                Cells[i].OriginalValue = sudokuString[i].ToString();

                if (sudokuStringPlayer[i] == '0')
                {
                    Cells[i].CellValue = string.Empty;
                    Cells[i].IsValid = false;
                }
                else
                {
                    Cells[i].CellValue = sudokuStringPlayer[i].ToString();
                    
                }

            }
        }
    }
}
