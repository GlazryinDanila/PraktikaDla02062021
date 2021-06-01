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
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            WpfApp23.vxodDataSet1 vxodDataSet1 = ((WpfApp23.vxodDataSet1)(this.FindResource("vxodDataSet1")));
            // Загрузить данные в таблицу Info_o_biletax. Можно изменить этот код как требуется.
            WpfApp23.vxodDataSet1TableAdapters.Info_o_biletaxTableAdapter vxodDataSet1Info_o_biletaxTableAdapter = new WpfApp23.vxodDataSet1TableAdapters.Info_o_biletaxTableAdapter();
            vxodDataSet1Info_o_biletaxTableAdapter.Fill(vxodDataSet1.Info_o_biletax);
            System.Windows.Data.CollectionViewSource info_o_biletaxViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("info_o_biletaxViewSource")));
            info_o_biletaxViewSource.View.MoveCurrentToFirst();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow mw = new MainWindow();
            mw.Show();
        }
    }
}
