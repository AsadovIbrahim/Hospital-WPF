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
using HOSBITAL.Views;
using HOSBITAL.Pages;
using Hospital.Pages;
using HOSBITAL.ViewModel;
using Hospital.ViewModel;

namespace Hospital.Views
{
    
    public partial class Pasientsexsikobinet : Window
    {
        public static Pasientsexsikobinet ?pasientsexsikobinet;
        public Pasientsexsikobinet()
        {
            InitializeComponent();
            DataContext = new PasientClass();
            pasientsexsikobinet = this;       
        }

        
    }
}
