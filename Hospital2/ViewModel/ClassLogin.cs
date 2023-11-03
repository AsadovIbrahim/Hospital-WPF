using HOSBITAL.Commands;
using HOSBITAL.Pages;
using HOSBITAL.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HOSBITAL.Views;
using Hospital.Views;
using Hospital.Pages;
using System.ComponentModel;
using System.Windows.Controls;
using Hospital.Pasient;
using Hospital2.Models;
using Hospital.ViewModel;

namespace HOSBITAL.ViewModel
{
    public class ClassLogin
    {
        public RealCommand? qeydiyyatCommand { get; set; }
        public RealCommand? daxilOlCommand { get; set; }
        public RealCommand? closeCommand { get; set; }

        private string _seriyaID;
        private string _password;

        public string seriyaID
        {
            get { return _seriyaID; }
            set { _seriyaID = value;OnPropertyChanged(nameof(seriyaID)); }
        }

        public string password
        {
            get { return _password; }
            set { _password = value; OnPropertyChanged(nameof(password)); }
        }
        private void QeydiyyatButton(object? sender)
        {
            Qeydiyyat qeydiyyat = new Qeydiyyat();
            Girish.girish!.MainFrame.Content = qeydiyyat;
        }

        private void Close(object? sender)
        {
            Girish.girish.MainFrame.Navigate(null);
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public void DaxilOl(object? param)
        {

            Pasientsexsikobinet pasientsexsikobinet = new Pasientsexsikobinet(); 
            pasientsexsikobinet.ShowDialog();
        }
        Button button=new Button();
        public bool IsPasient(object? obj)
        {
            foreach(var pasient in PasientlerDB.pasients!)
            {
                if (pasient.seriyaID==seriyaID && pasient.Password==password)
                {
                    button.IsEnabled = true;
                    PasientlerDB.CurrentPasient = pasient;
                    return true;
                }
            }
            return false;
        }

        public ClassLogin(Button button) {
            this.button = button;
            this.button.IsEnabled = false;

            daxilOlCommand = new(DaxilOl,IsPasient);
            qeydiyyatCommand = new(QeydiyyatButton);
            closeCommand = new(Close);
        

        }
    }
}
