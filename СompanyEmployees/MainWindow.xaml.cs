using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace СompanyEmployees
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Employee> items = new ObservableCollection<Employee>(); 
        void FillList()
        {
            ibEmployee.ItemsSource = items;
            items.Add(new Employee() { Id = 1, Name = "Василий", Age = 22, Salary = 3000 });
            items.Add(new Employee() { Id = 2, Name = "Пётр", Age = 35, Salary = 6000 });
            items.Add(new Employee() { Id = 3, Name = "Николай", Age = 28, Salary = 8000 });
        }

        private void ibEmployee_SelectedChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            MessageBox.Show(e.AddedItems[0].ToString());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            items.Add(new Employee() { Id = 1, Name = "Сергей", Age = 26, Salary = 7000 });
        }

        public MainWindow()
        {
            InitializeComponent();
            FillList();
        }

        private void ibEmployee_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show(e.Source.ToString());
        }
    }
}
