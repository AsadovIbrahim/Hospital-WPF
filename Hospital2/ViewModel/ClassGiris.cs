using HOSBITAL.Commands;
using HOSBITAL.Pages;
using HOSBITAL.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Hospital.Views;
using Hospital2.Pages;
using Hospital2.ViewModel;
using Hospital2.Views;
using Hospital.Pages;

namespace HOSBITAL.ViewModel
{
    public class ClassGiris
    { 
        public RealCommand? daxilOlCommand { get; set; }
        public RealCommand? hekimlerCommand { get; set; }
        public RealCommand? enYaxinXestexanaCommand { get; set; }
        public RealCommand? haqqimizdaCommand { get; set; }

        
        private void DaxilOl(object? sender)
        {
            Girish.girish!.MainFrame.Content = new Login();
        }

        private void Hekimler(object? sender)
        {
            Hekimsexsikobinet hekimsexsikobinet = new Hekimsexsikobinet();
            hekimsexsikobinet.ShowDialog();
        }

        private void EnYaxinXestexanaCommand(object? sender)
        {
            Girish.girish!.MainFrame.Content = new EnYaxinXestexana();

        }
        private void HaqqimizdaCommand(object? param)
        {
            Haqqimizda haqqimizda = new Haqqimizda();
            haqqimizda.ShowDialog();
        }

       
        public ClassGiris()
        {
            daxilOlCommand = new RealCommand(DaxilOl);
            hekimlerCommand = new RealCommand(Hekimler);
            enYaxinXestexanaCommand = new RealCommand(EnYaxinXestexanaCommand);
            haqqimizdaCommand = new RealCommand(HaqqimizdaCommand);
        }
    }
}
