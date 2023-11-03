using HOSBITAL.Commands;
using Hospital.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOSBITAL.ViewModel
{
    public class ClassLaboratoriya
    {
        public RealCommand? closeCommand { get; set; }

        private void Close(object? sender)
        {
            Pasientsexsikobinet.pasientsexsikobinet!.MainFrame.Navigate(null);
        }
        public ClassLaboratoriya()
        {
            closeCommand = new RealCommand(Close);
        }
    }
}
