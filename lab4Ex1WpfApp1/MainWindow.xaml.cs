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

namespace lab4Ex1WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollar = Convert.ToDouble(sum.Text);
            double resDouble = rateDollar * sumDollar;
            resSum.Text = resDouble.ToString();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rate = Convert.ToDouble(rateEur.Text);
            double sum = Convert.ToDouble(sumEur.Text);
            double res = rate * sum;
            resSumEur.Text = res.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rate = Convert.ToDouble(rateUah.Text);
            double sum = Convert.ToDouble(sumUah.Text);
            double res = rate * sum;
            resSumUah.Text = res.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rate = Convert.ToDouble(rateAmd.Text);
            double sum = Convert.ToDouble(sumAmd.Text);
            double res = rate * sum;
            resSumAmd.Text = res.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double lenght = Convert.ToDouble(inch.Text);
            double res = lenght / 39.37;
            resInch.Text = res.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double lenght = Convert.ToDouble(ft.Text);
            double res = lenght / 3.281;
            resFt.Text = res.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double lenght = Convert.ToDouble(mile.Text);
            double res = lenght * 1609.34;
            resMile.Text = res.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double lenght = Convert.ToDouble(verst.Text);
            double res = lenght * 1066.8;
            resVerst.Text = res.ToString();
        }
    }
}
