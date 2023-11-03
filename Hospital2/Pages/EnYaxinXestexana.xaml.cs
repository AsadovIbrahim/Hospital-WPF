using Hospital2.ViewModel;
using Microsoft.Maps.MapControl.WPF;
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

namespace Hospital2.Pages
{
    public partial class EnYaxinXestexana : Page
    {
        public EnYaxinXestexana()
        {
            InitializeComponent();
            DataContext=new EnYaxinXestexanaViewModel();
            var mapKey = "atdthVyqDCYydLA26DCL~SC41f6rxsdjIXsNz3GllbQ~AikySlhq1Q5Y4OqPJM-hUITVvNbnChXfFFaAVq8hxDQWCuLGhDorrDI7RO7RzCVz";
            myMap.CredentialsProvider = new ApplicationIdCredentialsProvider(mapKey);
        
        
        }
    }
}
