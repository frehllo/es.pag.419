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

namespace Operazioni
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_000M(object sender, RoutedEventArgs e)
        {
            double n = double.Parse(txt_variabile.Text);
            double r = n * 0.001;
            txt_variabile.Text = r.ToString();
        }

        private void Button_Click_00M(object sender, RoutedEventArgs e)
        {
            double n = double.Parse(txt_variabile.Text);
            double r = n * 0.01;
            txt_variabile.Text = r.ToString();
        }
        private void Button_Click_0M(object sender, RoutedEventArgs e)
        {
            double n = double.Parse(txt_variabile.Text);
            double r = n * 0.1;
            txt_variabile.Text = r.ToString();
        }        
        private void Button_Click_1S(object sender, RoutedEventArgs e)
        {
            double n = double.Parse(txt_variabile.Text);
            double r = n + 1;
            txt_variabile.Text = r.ToString();
        }

        private void Button_Click_01S(object sender, RoutedEventArgs e)
        {
            double n = double.Parse(txt_variabile.Text);
            double r = n + 0.1;
            txt_variabile.Text = r.ToString();
        }

        private void Button_Click_001S(object sender, RoutedEventArgs e)
        {
            double n = double.Parse(txt_variabile.Text);
            double r = n + 0.01;
            txt_variabile.Text = r.ToString();
        }

        private void Button_Click_01D(object sender, RoutedEventArgs e)
        {
            double n = double.Parse(txt_variabile.Text);
            double r = n / 0.1;
            txt_variabile.Text = r.ToString();
        }

        private void Button_Click_001D(object sender, RoutedEventArgs e)
        {
            double n = double.Parse(txt_variabile.Text);
            double r = n / 0.01;
            txt_variabile.Text = r.ToString();
        }

        private void Button_Click_0001D(object sender, RoutedEventArgs e)
        {
            double n = double.Parse(txt_variabile.Text);
            double r = n / 0.001;
            txt_variabile.Text = r.ToString();
        }

        private void Button_Click_1Diff(object sender, RoutedEventArgs e)
        {
            double n = double.Parse(txt_variabile.Text);
            double r = n - 1;
            txt_variabile.Text = r.ToString();
        }
        private void Button_Click_01Diff(object sender, RoutedEventArgs e)
        {
            double n = double.Parse(txt_variabile.Text);
            double r = n - 0.1;
            txt_variabile.Text = r.ToString();
        }

        private void Button_Click_001Diff(object sender, RoutedEventArgs e)
        {
            double n = double.Parse(txt_variabile.Text);
            double r = n - 0.01;
            txt_variabile.Text = r.ToString();
        }
    }
}
