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
using System.Windows.Shapes;

namespace WpfApp23
{
    /// <summary>
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow mw = new MainWindow();
            mw.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
            Window8 win8 = new Window8();
            win8.Show();
            

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow mw = new MainWindow();
            mw.Show();
        }
    }
}
