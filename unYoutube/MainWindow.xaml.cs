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

namespace unYoutube
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Loaded += MainWindow_Loaded;
            InitializeComponent();
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                youtube.Navigate(new Uri("https://www.youtube.com"));
            }
            catch(Exception)
            {
                MessageBox.Show("Looks as if there is no Active internet connection");
            }

            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                youtube.GoBack();
            }
            catch (Exception)
            {
                MessageBox.Show("It Seems, that you are trying to go back from a Homepage");
            }
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                youtube.GoForward();
            }
            catch (Exception)
            {
                MessageBox.Show("You need to navigate Backword to use this function");
            }
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
