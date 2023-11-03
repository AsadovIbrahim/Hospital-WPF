using HOSBITAL.Commands;
using HOSBITAL.Views;
using Hospital.Pages;
using Hospital.Views;
using Hospital2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HOSBITAL.ViewModel
{
    public class ClassOnlineNovbe
    {
        public RealCommand ?tamamlaCommand { get; set; }
        public RealCommand ?Close_command { get; set; }

        public XesteMuracieti xesteMuracieti { get; set; } = new();
        private void Tamamla(object? sender)
        {

            if (Online_novbe.online_Novbe!.analizNovu.SelectedItem!=null && 
                Online_novbe.online_Novbe.gun.SelectedItem!=null && Online_novbe.online_Novbe.saat.SelectedItem!=null
                && Online_novbe.online_Novbe.muaine.SelectedItem!=null && Online_novbe.online_Novbe.hekim.SelectedItem!=null)
            {
                Pasientsexsikobinet.pasientsexsikobinet!.MainFrame.Navigate(null);
                ClassMuracietler.hekimler.xesteMuracieti.Add(xesteMuracieti);
                ClassQeydiyyat.WriteData(ClassMuracietler.hekimler.xesteMuracieti, "muracietler");
            }
            else
            {
                MessageBox.Show("Melumatlari tam daxil edin!!");
            }

        }

        private void Close(object? sender)
        {
            Pasientsexsikobinet.pasientsexsikobinet!.MainFrame.Navigate(null);
        }

        public ClassOnlineNovbe()
        {
            tamamlaCommand = new RealCommand(Tamamla);
            Close_command = new RealCommand(Close);
        }
    }
}
