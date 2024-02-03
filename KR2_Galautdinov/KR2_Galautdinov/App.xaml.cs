using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using KR2_Galautdinov.Models;
namespace KR2_Galautdinov
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static KR2_GalautdinovEntities DB = new KR2_GalautdinovEntities();
        public static Employee LoggedUser;
    }
}
