using HOSBITAL.Commands;
using HOSBITAL.Pages;
using Hospital.Pages;
using Hospital.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.ViewModel
{
    public class PasientClass
    {
        public RealCommand? qebulCommand { get; set; }
        public RealCommand? onlineNovbeCommand { get; set; }
        public RealCommand? sualCavabCommand { get; set; }
        public RealCommand? laboratoriyaCommand { get; set; }

        private void Qebul(object? sender)
        {
            Pasientsexsikobinet.pasientsexsikobinet!.MainFrame.Content = new Qebul();
        }
        private void OnlineNovbe(object? sender)
        {
            Pasientsexsikobinet.pasientsexsikobinet!.MainFrame.Content = new Online_novbe();
        }

        private void SualCavab(object? sender)
        {
            Pasientsexsikobinet.pasientsexsikobinet!.MainFrame.Content = new SualCavab();
       
        }
        private void Laboratoriya(object? sender)
        {
            Pasientsexsikobinet.pasientsexsikobinet!.MainFrame.Content = new Laboratoriya();  
            
        }
        public PasientClass()
        {
            qebulCommand = new(Qebul);
            onlineNovbeCommand = new(OnlineNovbe);
            sualCavabCommand = new(SualCavab);
            laboratoriyaCommand = new(Laboratoriya);
        }
    }
}
