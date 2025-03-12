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

namespace EquipmentRepair
{
    /// <summary>
    /// Логика взаимодействия для ClientOrderWindow.xaml
    /// </summary>
    public partial class ClientOrderWindow : Window
    {

        // private EqipmentRepairEntities _db = new EqipmentRepairEntities();
        /* 
         * ВОТ ТУТ ДОЛЖНО БЫТЬ ЭТО 
            
        Client existingClient
         
         */
        public ClientOrderWindow(/* ВОТ ТУТ ДОЛЖНО БЫТЬ ЭТО */)
        {
            InitializeComponent();

            // MainDataGrid.ItemsSource = _db.Order.Where(o => o.ClientId == existingClient.ClientId).ToList();
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            this.Close();
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
