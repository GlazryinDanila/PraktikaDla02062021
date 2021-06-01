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
    /// Логика взаимодействия для Window7.xaml
    /// </summary>
    public partial class Window7 : Window
    {
        public Window7()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            WpfApp23.vxodDataSet vxodDataSet = ((WpfApp23.vxodDataSet)(this.FindResource("vxodDataSet")));
            // Загрузить данные в таблицу rasshet. Можно изменить этот код как требуется.
            WpfApp23.vxodDataSetTableAdapters.rasshetTableAdapter vxodDataSetrasshetTableAdapter = new WpfApp23.vxodDataSetTableAdapters.rasshetTableAdapter();
            vxodDataSetrasshetTableAdapter.Fill(vxodDataSet.rasshet);
            System.Windows.Data.CollectionViewSource rasshetViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("rasshetViewSource")));
            rasshetViewSource.View.MoveCurrentToFirst();
        }
       private void RasshetDataGrid_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}
