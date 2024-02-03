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
    public partial class AddEmployeePage : Page
    {
        Employee contextEmployee;
        public AddEmployeePage()
        {
            InitializeComponent();
            DepartamentCB.ItemsSource = App.DB.Departament.ToList();
            RoleCB.ItemsSource = App.DB.Role.ToList();
            PlatformCB.ItemsSource = App.DB.Platform.ToList();
        }

        private void AddEmployeeB_Click(object sender, RoutedEventArgs e)
        {
            Employee employee = new Employee();
            employee.FullName = FullNameTB.Text;
            employee.Birthday = DateTime.Parse(BirthTB.Text);
            employee.PhoneNumber = PhoneNumTB.Text;
            employee.Salary = int.Parse(SalaryTB.Text);
            employee.Passport = PassportTB.Text;
            employee.Login = LoginTB.Text;
            employee.Password = PasswordTB.Text;
            var selectedDepartament = DepartamentCB.SelectedItem as Departament;
            var selectedRole = RoleCB.SelectedItem as Role;
            var selectedPlatform = PlatformCB.SelectedItem as Platform;
            var newEmployee = new Employee();
            newEmployee.Departament = selectedDepartament;
            newEmployee.Role = selectedRole;
            newEmployee.Platform = selectedPlatform;
            contextEmployee.Platform.Employee.Add(newEmployee) ;
            contextEmployee.Departament.Employee.Add(newEmployee);
            contextEmployee.Role.Employee.Add(newEmployee);
            App.DB.Employee.Add(contextEmployee);
            App.DB.SaveChanges();
            NavigationService.GoBack();
        }

        private void ExitB_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
