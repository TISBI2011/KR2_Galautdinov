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
    /// Логика взаимодействия для GeneralPage.xaml
    /// </summary>
    public partial class GeneralPage : Page
    {
        public GeneralPage()
        {
            InitializeComponent();
        }

        private void EmployeesB_Click(object sender, RoutedEventArgs e)
        {
            GeneralFrame.Navigate(new EmpListPage());
        }

        private void TasksB_Click(object sender, RoutedEventArgs e)
        {
           NavigationService.Navigate(new TasksPage());
        }

        private void ExitB_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
