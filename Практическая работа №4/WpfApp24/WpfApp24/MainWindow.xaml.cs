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

namespace WpfApp24
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
                int a = Convert.ToInt32(TbNumberA.Text);
                int sum = (a / 10) + (a % 10);
                bool isEven = (sum % 2 ==0);
                if (isEven)
                {
                    MessageBox.Show("Сумма цифр является четной числом ");
                }
                else
                {
                    MessageBox.Show("Сумма цифр является нечетной числом ");
                }
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

                
                    

