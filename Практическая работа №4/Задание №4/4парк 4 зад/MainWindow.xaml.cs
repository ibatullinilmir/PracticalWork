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

namespace _4парк_4_зад
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
                double res = 1.0;
                if (a % 2 == 0)
                {
                    for(int i = a; i >= 1; i -= 2)
                    {
                        res *= i;

                    }
                }
                else
                {
                    for(int i = a; i >= 1; i -= 2)
                    {
                        res *= i;
                    }
                }
                TextBlockAnswer.Text=$"{res}";
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
   

