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

namespace LabWork_8_1
{
    /// <summary>
    /// Логика взаимодействия для DeleteFiz.xaml
    /// </summary>
    public partial class DeleteFiz : Window
    {
        private TestWorkDBEntities _testWorkDB = new TestWorkDBEntities();
        public DeleteFiz()
        {
            InitializeComponent();

            KodPostavshikaBox.ItemsSource = _testWorkDB.ФизическиеЛица.ToList();
        }

        private void ChangeFiz(object sender, SelectionChangedEventArgs e)
        {
            ФизическиеЛица fiz = KodPostavshikaBox.SelectedItem as ФизическиеЛица;

            SecondNameBox.Text = fiz.Фамилия;
            NameBox.Text = fiz.Имя;
            FatherNameBox.Text = fiz.Отчество;
            NumberSvid.Text = fiz.НомерСвидетельства.ToString();
        }

        private void EditFize(object sender, RoutedEventArgs e)
        {
            try
            {
                ФизическиеЛица fiz = KodPostavshikaBox.SelectedItem as ФизическиеЛица;

                _testWorkDB.ФизическиеЛица.Remove(fiz);

                _testWorkDB.SaveChanges();

                MessageBox.Show("Data has been edited", "SUCCESS", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
