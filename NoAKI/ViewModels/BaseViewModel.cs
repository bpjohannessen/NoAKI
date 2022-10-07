using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace NoAKI.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
    
        public BaseViewModel()
        {
        }

        #region properties
        private bool _isBusy;
        private string _title;

        public bool IsBusy
        {
            get => _isBusy;
            set
            {
                IsBusy = value;
                OnPropertyChanged();
            }
        }

        public string Title
        {
            get => _title;
            set
            {
                Title = value;
                OnPropertyChanged();
            }
        }
        #endregion


        #region INotify

        public event PropertyChangedEventHandler PropertyChanged;


        public void OnPropertyChanged([CallerMemberName] string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        #endregion
    }
}