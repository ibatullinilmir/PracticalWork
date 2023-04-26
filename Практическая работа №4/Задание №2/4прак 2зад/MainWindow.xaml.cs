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

namespace _4прак_2зад
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
                string ageString;
                int last = a% 10;
                if (last == 1 && a != 11)
                {
                    ageString = a + "год";
                }
                else if (last >= 2 && last <= 4 && !(a >= 12 && a <= 14)) 
                {
                    ageString = a + "года";
                }
                else
                {
                    ageString = a + "лет";
                }
                TextBlockAnswer.Text = $"Ответ{ageString}";
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
