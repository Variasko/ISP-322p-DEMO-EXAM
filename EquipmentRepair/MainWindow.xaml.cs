using System;
using System.Net;
using System.Windows;

namespace EquipmentRepair
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private Utilities _utilities = new Utilities();
        // private EquipmentRepairEntities _db = new EquipmentRepairEntities();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void SignInButton_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginEnter.Text;
            string password = PasswordEnter.Password;

            int role = _utilities.Authorizaton(login, password);

            if (role == 0)
            {
                MessageBox.Show("Возникли проблема с проверкой логина или пароля!", "Ошибка!");
            } else if (role == 1)
            {
                // var client = _db.Client.Where(c => c.Surname == login && c.Phone == password).First();
                //new ClientOrderWindow(client).Show();
                this.Close();
            } else if (role == 2)
            {
                MessageBox.Show("Привет, сотрудник!", "Информация!");
            } else if (role == 3)
            {
                MessageBox.Show("Привет, администратор!", "Информация!");
            } else // в случае когда функция вернёт -1
            {
                MessageBox.Show("Возникли проблема с проверкой логина или пароля!", "Ошибка!");
            }
        }
    }
}
