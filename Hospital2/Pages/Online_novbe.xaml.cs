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

namespace Hospital.Pages
{
    
    public partial class Online_novbe : Page
    {
        public static Online_novbe ?online_Novbe;
        public Online_novbe()
        {
            InitializeComponent();
            DataContext = new ClassOnlineNovbe();
            online_Novbe = this;
        }
    }
}
