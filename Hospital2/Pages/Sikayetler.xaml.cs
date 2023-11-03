using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using HOSBITAL.ViewModel;
using Hospital2.ViewModel;

namespace Hospital2.Pages
{
    
    public partial class Sikayetler : Page
    {
        public Sikayetler()
        {
            InitializeComponent();
            DataContext = new SikayetlerViewModel();
        }
       
    }
}
