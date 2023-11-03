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

    public partial class Laboratoriya : Page
    {
        public Laboratoriya()
        {
            InitializeComponent();
            DataContext = new ClassLaboratoriya();
        }

        private void plusBtnClick(object sender, RoutedEventArgs e)
        {
            
            if (sectionLab.Visibility == Visibility.Collapsed)
            {
                sectionLab.Visibility = Visibility.Visible;
                Button button=(Button)sender;
                button.Content = "-";
            }
            else if (sectionLab.Visibility == Visibility.Visible)
            {
                sectionLab.Visibility = Visibility.Collapsed;
                Button button = (Button)sender;
                button.Content = "+";
            }
          

        }
        private void plusBtnClick1(object sender, RoutedEventArgs e)
        {

            if (sectionLab1.Visibility == Visibility.Collapsed)
            {
                sectionLab1.Visibility = Visibility.Visible;
                Button button = (Button)sender;
                button.Content = "-";
            }
            else if (sectionLab1.Visibility == Visibility.Visible)
            {
                sectionLab1.Visibility = Visibility.Collapsed;
                Button button = (Button)sender;
                button.Content = "+";
            }
           

        }
        private void plusBtnClick2(object sender, RoutedEventArgs e)
        {

            if (sectionLab2.Visibility == Visibility.Collapsed)
            {
                sectionLab2.Visibility = Visibility.Visible;
                Button button = (Button)sender;
                button.Content = "-";
            }
            else if (sectionLab2.Visibility == Visibility.Visible)
            {
                sectionLab2.Visibility = Visibility.Collapsed;
                Button button = (Button)sender;
                button.Content = "+";
            }


        }
        private void plusBtnClick3(object sender, RoutedEventArgs e)
        {

            if (sectionLab3.Visibility == Visibility.Collapsed)
            {
                sectionLab3.Visibility = Visibility.Visible;
                Button button = (Button)sender;
                button.Content = "-";
            }
            else if (sectionLab3.Visibility == Visibility.Visible)
            {
                sectionLab3.Visibility = Visibility.Collapsed;
                Button button = (Button)sender;
                button.Content = "+";
            }
        }
        private void plusBtnClick4(object sender, RoutedEventArgs e)
        {

            if (sectionLab4.Visibility == Visibility.Collapsed)
            {
                sectionLab4.Visibility = Visibility.Visible;
                Button button = (Button)sender;
                button.Content = "-";
            }
            else if (sectionLab4.Visibility == Visibility.Visible)
            {
                sectionLab4.Visibility = Visibility.Collapsed;
                Button button = (Button)sender;
                button.Content = "+";
            }
           

        }
        private void plusBtnClick5(object sender, RoutedEventArgs e)
        {

            if (sectionLab5.Visibility == Visibility.Collapsed)
            {
                sectionLab5.Visibility = Visibility.Visible;
                Button button = (Button)sender;
                button.Content = "-";
            }
            else if (sectionLab5.Visibility == Visibility.Visible)
            {
                sectionLab5.Visibility = Visibility.Collapsed;
                Button button = (Button)sender;
                button.Content = "+";
            }
        }
        private void plusBtnClick6(object sender, RoutedEventArgs e)
        {

            if (sectionLab6.Visibility == Visibility.Collapsed)
            {
                sectionLab6.Visibility = Visibility.Visible;
                Button button = (Button)sender;
                button.Content = "-";
            }
            else if (sectionLab6.Visibility == Visibility.Visible)
            {
                sectionLab6.Visibility = Visibility.Collapsed;
                Button button = (Button)sender;
                button.Content = "+";
            }


        }
        private void plusBtnClick7(object sender, RoutedEventArgs e)
        {

            if (sectionLab7.Visibility == Visibility.Collapsed)
            {
                sectionLab7.Visibility = Visibility.Visible;
                Button button = (Button)sender;
                button.Content = "-";
            }
            else if (sectionLab7.Visibility == Visibility.Visible)
            {
                sectionLab7.Visibility = Visibility.Collapsed;
                Button button = (Button)sender;
                button.Content = "+";
            }


        }
    }
}
