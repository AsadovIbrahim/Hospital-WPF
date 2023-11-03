using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using Hospital2.Models;
using Hospital2.Pages;
using Hospital2.ViewModel;

namespace Hospital.Pages
{

    public partial class SualCavab : Page
    {
        public SualCavab()
        {
            InitializeComponent();
            DataContext = new ClassSualCavab();
        }

        

        private void textBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtBox.Focus();
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

            if (!string.IsNullOrEmpty(txtBox.Text) || txtBox.Text.Length >0)
            {
                textBlock.Visibility = Visibility.Collapsed;
            }
            else if (string.IsNullOrEmpty(txtBox.Text))
            {
                textBlock.Visibility = Visibility.Visible;
            }
            else
            {
                textBlock.Visibility=Visibility.Visible;
            }
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(txtBox.Text=="") {
                MessageBox.Show("Xeta");
            }
            else
            {
                border.Visibility=Visibility.Visible;
                chat.Visibility = Visibility.Visible;
            }
            txtBox.Text = "";

        }
    }
}
