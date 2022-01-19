using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SudokuClient.Models
{
    public class Cell : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string _cellValue;
        private bool _isValid = true;
        public string CellValue
        {
            get
            {
                return _cellValue;
            }
            set
            {
                _cellValue = value;
                OnPropertyChanged(nameof(CellValue));
            }
        }

        public bool IsValid
        {
            get
            {
                return _isValid;
            }
            set
            {
                _isValid = value;
                OnPropertyChanged(nameof(IsValid));
            }
        }
    }
}
