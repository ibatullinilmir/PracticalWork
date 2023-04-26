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


namespace _6_прак_2зад
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
       private double f(int n)
        {
            return Math.Sqrt(n) + n;
        }


        

       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double result = f(6 * 6) + f(13 * 13) + f(21 * 21);
            ResultTextBlock.Text=result.ToString();

        }
    }
}
