using HOSBITAL.ViewModel;
using Hospital.Pasient;
using Hospital2.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital2.Models
{
    public class Hekimler : INotifyPropertyChanged
    {

        public ObservableCollection<XesteMuracieti> xesteMuracieti { get; set; } = new();
        public ObservableCollection<XesteSikayeti> xesteSikayeti { get; set; } = new();


        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
