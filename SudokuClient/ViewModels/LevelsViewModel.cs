﻿using SudokuClient.Commands;
using SudokuClient.Models;
using SudokuClient.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using System.Windows.Threading;

namespace SudokuClient.ViewModels
{
    public class LevelsViewModel : BaseViewModel
    {
        public ICommand BackToMenuCommand { get; }
        public ICommand SaveTheGameCommand { get; }

        public DispatcherTimer dispatcherTimer = null;

        private string _timerText;

        public int _totalSeconds = 0;

        public string sudokuString;

        public string sudokuStringPlayer;

        public Game _game;


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

        public LevelsViewModel(NavigationService MenuViewNavigationService)
        {
            _game = new Game();
            BackToMenuCommand = new NavigateCommand(MenuViewNavigationService);
            SaveTheGameCommand = new SaveTheGameCommand(_game);
            dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(DispatcherTimerTick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
        }

        public void DispatcherTimerTick(object sender, EventArgs e)
        {
            this._totalSeconds += 1;
            _game.Duraion = _totalSeconds;
            TimerText = string.Format("{0:hh\\:mm\\:ss}", TimeSpan.FromSeconds(this._totalSeconds).Duration());
            CommandManager.InvalidateRequerySuggested();
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
                }
                else
                {
                    Cells[i].CellValue = sudokuStringPlayer[i].ToString();
                }

            }
        }

    }
}
