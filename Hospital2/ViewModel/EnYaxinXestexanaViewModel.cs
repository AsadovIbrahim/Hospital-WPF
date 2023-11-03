using HOSBITAL.Commands;
using HOSBITAL.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital2.ViewModel
{
    public class EnYaxinXestexanaViewModel
    {
        public RealCommand ?closeCommand { get; set; }

        private void Close(object? sender)
        {
            Girish.girish!.MainFrame.Navigate(null);
        }
        public EnYaxinXestexanaViewModel()
        {
            closeCommand=new RealCommand(Close);
        }
    }
}
