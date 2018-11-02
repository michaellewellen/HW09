using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HW09.ViewModels
{
    public class MainWindowViewModel : ViewModelBase , INotifyPropertyChanged
    {
        private void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
