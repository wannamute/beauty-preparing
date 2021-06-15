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

namespace BeautyCompany
{
    /// <summary>
    /// Логика взаимодействия для ServicePage.xaml
    /// Отображение списка клиентов
    /// Редактирование 
    /// Добавление
    /// удаление
    /// пиздец завтра нам
    /// да
    /// угу
    /// печаль
    /// </summary>
    public partial class ServicePage : Page
    {
        public ServicePage()
        {
            InitializeComponent();
            var services = DB.getServices();
            lvServices.ItemsSource = services;
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            lvServices.ItemsSource = DB.getFilteredServices(txtSearch.Text);
        }
    }
}
