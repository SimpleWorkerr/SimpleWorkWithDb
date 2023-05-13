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
    /// Логика взаимодействия для DeleteUyer.xaml
    /// </summary>
    public partial class DeleteUyer : Window
    {
        private TestWorkDBEntities _testWorkDB = new TestWorkDBEntities();

        public DeleteUyer()
        {
            InitializeComponent();
            KodPostavshikaBox.ItemsSource = _testWorkDB.ЮридическиеЛица.ToList();
        }

        private void EditUyerButton(object sender, RoutedEventArgs e)
        {
            try
            {
                ЮридическиеЛица uyer = KodPostavshikaBox.SelectedItem as ЮридическиеЛица;

                _testWorkDB.ЮридическиеЛица.Remove(uyer);

                _testWorkDB.SaveChanges();

                MessageBox.Show("Data has been deleted", "SUCCESS", MessageBoxButton.OK, MessageBoxImage.Information);

                TovarNameBox.Text = "";
                NalogNomerBox.Text = "";
                NumberSvid.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ChangeUyer(object sender, SelectionChangedEventArgs e)
        {
            ЮридическиеЛица uyer = KodPostavshikaBox.SelectedItem as ЮридическиеЛица;

            TovarNameBox.Text = uyer.Название;
            NalogNomerBox.Text = uyer.НалоговыйНомер;
            NumberSvid.Text = uyer.НомерСвидетельства.ToString();
        }
    }
}
