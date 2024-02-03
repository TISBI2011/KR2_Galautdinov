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
using KR2_Galautdinov.Models;

namespace KR2_Galautdinov.Pages
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginB_Click(object sender, RoutedEventArgs e)
        {
            App.LoggedUser = App.DB.Employee.FirstOrDefault(x => x.Login == LoginTB.Text && x.Password == PasswordTB.Text);
            if (App.LoggedUser == null)
            {
                MessageBox.Show("Error, try again");
                return;
            }
            else
            {   
                if (App.LoggedUser.RoleID == 1)
                {
                    NavigationService.Navigate(new GeneralPage());
                }
                else
                {
                    NavigationService.Navigate(new EmployeePage());
                }

            }
        }
    }
}
