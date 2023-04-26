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

namespace _4_прак_6_зад
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

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnOK_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(TbNumberA.Text);
                bool containsFive = false;
                while (n != 0)
                { 
                    int digit = n % 10;
                    if (digit == 5) 
                    { 
                        containsFive = true;
                        break; } n /= 10; 
                }
                TextBlockAnswer.Text=$"{containsFive}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Введены не корректные данные");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

            