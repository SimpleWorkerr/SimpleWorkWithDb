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
    /// Логика взаимодействия для EditPostavleno.xaml
    /// </summary>
    public partial class EditPostavleno : Window
    {
        private TestWorkDBEntities _testWorkDB = new TestWorkDBEntities();

        public EditPostavleno()
        {
            InitializeComponent();

            NumberDogovorBox.ItemsSource = _testWorkDB.Поставлено.ToList();
        }

        private void ChangePostavleno(object sender, SelectionChangedEventArgs e)
        {
            Поставлено postavleno = NumberDogovorBox.SelectedItem as Поставлено;

            CountBox.Text = postavleno.Количество.ToString();
            PriceBox.Text = postavleno.Цена.ToString();
            TovarBox.Text = postavleno.Товар;
        }

        private void EditPostavlenoe(object sender, RoutedEventArgs e)
        {
            try
            {
                Поставлено postavleno = NumberDogovorBox.SelectedItem as Поставлено;

                _testWorkDB.Поставлено.Find(postavleno.НомерДоговора, postavleno.Товар).Количество = int.Parse(CountBox.Text);
                _testWorkDB.Поставлено.Find(postavleno.НомерДоговора, postavleno.Товар).Цена = decimal.Parse(PriceBox.Text);
                _testWorkDB.Поставлено.Find(postavleno.НомерДоговора, postavleno.Товар).Товар = TovarBox.Text;

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
