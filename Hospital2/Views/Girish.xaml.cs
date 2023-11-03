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
using System.Windows.Shapes;
using HOSBITAL.ViewModel;
using Microsoft.Maps.MapControl.WPF;

namespace HOSBITAL.Views
{
    public partial class Girish : Window
    {
        public static Girish? girish;
        public Girish()
        {
            InitializeComponent();
            DataContext = new ClassGiris();
           

            girish = this;
        }

        private void MainFrame_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {

        }
    }
}
