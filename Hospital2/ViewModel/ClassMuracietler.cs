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

namespace HOSBITAL.ViewModel
{
    public class ClassMuracietler
    {
        public PasientlerDB pasientlerDBs { get; set; } = new();
        public RealCommand closeCommand { get; set; }
        public static Hekimler hekimler { get; set; } = new();

        public void Close(object? sender)
        {
            Hekimsexsikobinet.hekimsexsikobinet!.MainFrame.Navigate(null);
        }

        public ClassMuracietler()
        {
            hekimler.xesteMuracieti=ClassQeydiyyat.ReadData<ObservableCollection<XesteMuracieti>>("muracietler")!;
            closeCommand = new RealCommand(Close);
        }
    }
}
