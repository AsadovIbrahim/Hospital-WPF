using HOSBITAL.Commands;
using Hospital.Pages;
using Hospital.Pasient;
using Hospital.Views;
using Hospital2.Models;
using Hospital2.Pages;
using Hospital2.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace HOSBITAL.ViewModel
{
    public class ClassSualCavab : INotifyPropertyChanged
    {
        private Visibility status1;

        public event PropertyChangedEventHandler? PropertyChanged;


        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }
        public Visibility status { get => status1; set { status1 = value; OnPropertyChanged(); } }


        public XesteSikayeti? xesteSikayeti { get; set; } = new();

        public RealCommand? sendCommand { get; set; }
        public RealCommand? closeCommand { get; set; }

        public void Send(object? param)
        {
            if (xesteSikayeti!.content == "") { return; }
            status = Visibility.Visible;
            xesteSikayeti!.pasientSikayeti = PasientlerDB.CurrentPasient;
            

            SikayetlerViewModel.xesteSikayetleri.Add(xesteSikayeti);
            
            SikayetlerViewModel.WriteData(SikayetlerViewModel.xesteSikayetleri, "sikayetler");
        
        
        }

        private void Close(object? sender)
        {
            Pasientsexsikobinet.pasientsexsikobinet!.MainFrame.Navigate(null);
        }

        public ClassSualCavab()
        {
            SikayetlerViewModel.xesteSikayetleri = SikayetlerViewModel.ReadData<ObservableCollection<XesteSikayeti>>("sikayetler")!;
            status = Visibility.Collapsed;
            sendCommand = new RealCommand(Send);
            closeCommand = new RealCommand(Close);  
        }
    }
}
