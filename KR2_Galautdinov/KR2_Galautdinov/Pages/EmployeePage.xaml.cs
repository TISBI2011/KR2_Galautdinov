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

namespace KR2_Galautdinov.Pages
{
    /// <summary>
    /// Логика взаимодействия для EmployeePage.xaml
    /// </summary>
    public partial class EmployeePage : Page
    {
        public EmployeePage()
        {
            InitializeComponent();
        }

        private void HelpB_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Help on the way, wait...");
        }

        private void ExitB_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void TasksB_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EmployeeTasksPage());
        }

        private void ProfileB_Click(object sender, RoutedEventArgs e)
        {
            EmployeeFrame.Navigate(new ProfilePage());
        }
    }
}
