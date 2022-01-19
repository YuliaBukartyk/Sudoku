using SudokuClient.Commands;
using SudokuClient.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using System.Windows.Threading;
using SudokuClient.Models;
using System.Collections.ObjectModel;

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

        public Cell[] Cells { get; }


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
            string sudokuString = Utils.Utils.SendHttpGetRequest("http://localhost:5000/Board/getsudokuboard?");
            string sudokuStringPlayer = Utils.Utils.SendHttpGetRequest("http://localhost:5000/Board/getsudokuboard?");
            Cells = new Cell[sudokuStringPlayer.Length];


            for (int i = 0; i < sudokuStringPlayer.Length; i++)
            {
                Cells[i] = new Cell();

                if (sudokuStringPlayer[i] == '0')
                {
                    Cells[i].CellValue = string.Empty;
                }
                else
                {
                    Cells[i].CellValue = sudokuStringPlayer[i].ToString();
                }

            }
            //CheckIfValid(sudokuString);

            BackToMenuCommand = new NavigateCommand(MenuViewNavigationService);
            SaveTheGameCommand = new SaveTheGameCommand(_game);
            dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(DispatcherTimerTick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
        }

        private void CheckIfValid(string sudokuString)
        {
            for (int i = 0; i < sudokuString.Length; i++)
            {
                if (Cells[i].CellValue.Equals(sudokuString[i].ToString()))
                {
                    Cells[i].IsValid = true;
                }

                else
                {
                    Cells[i].IsValid = false;
                }
            }

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
