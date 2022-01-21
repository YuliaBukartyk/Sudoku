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
        private string _originalValue;
        
        public string CellValue
        {
            get
            {
                return _cellValue;
            }
            set
            {
                _cellValue = value;
                
                if (!CellValue.Equals(string.Empty) && !CellValue.Equals(OriginalValue))
                {
                    IsValid = false;
                }
                else
                {
                    IsValid = true;
                }
                OnPropertyChanged(nameof(CellValue));
            }
        }

        public string OriginalValue
        {
            get
            {
                return _originalValue;
            }
            set
            {
                _originalValue = value;
                OnPropertyChanged(nameof(OriginalValue));
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
