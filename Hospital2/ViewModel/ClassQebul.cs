using HOSBITAL.Commands;
using Hospital.Views;
using Hospital2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOSBITAL.ViewModel
{
    public class ClassQebul
    {
       
        public RealCommand? tamamlandiButton { get; set; }
        public RealCommand? Close_command { get; set; }


        private void Tamamlandi(object? sender)
        {
            Pasientsexsikobinet.pasientsexsikobinet!.MainFrame.Navigate(null);
        }
        private void Close(object? sender)
        {
            Pasientsexsikobinet.pasientsexsikobinet!.MainFrame.Navigate(null);
        }

        public ClassQebul()
        {
            tamamlandiButton = new RealCommand(Tamamlandi);
            Close_command = new RealCommand(Close);
        }




    }
}
