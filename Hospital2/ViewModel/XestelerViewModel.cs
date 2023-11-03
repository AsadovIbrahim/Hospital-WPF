using HOSBITAL.Commands;
using Hospital.Pasient;
using Hospital.Views;
using Hospital2.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital2.ViewModel
{
    public class XestelerViewModel
    {
        public ObservableCollection<Pasients>? pasients { get; set; } = PasientlerDB.pasients;
        public RealCommand? closeCommand { get; set; }
        public void Close(object? sender)
        {
            Hekimsexsikobinet.hekimsexsikobinet!.MainFrame.Navigate(null);
        }
        public XestelerViewModel()
        {
            closeCommand = new RealCommand(Close);
        }
    }
}
