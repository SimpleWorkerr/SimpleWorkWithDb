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
    /// Логика взаимодействия для AddPostavleno.xaml
    /// </summary>
    public partial class AddPostavleno : Window
    {
        private TestWorkDBEntities _testWorkDB = new TestWorkDBEntities();
        public AddPostavleno()
        {
            InitializeComponent();
        }

        public void AddPostavlenoButton(object sender, RoutedEventArgs e)
        {
            try
            {
                _testWorkDB.Поставлено.Add(new Поставлено()
                {
                    НомерДоговора = int.Parse(NomerDogovoraBox.Text),
                    Товар = TovarName.Text,
                    Количество = int.Parse(CountTovar.Text),
                    Цена = Decimal.Parse(Price.Text),
                });
                _testWorkDB.SaveChanges();

                MessageBox.Show("Data has been added", "SUCCESS", MessageBoxButton.OK, MessageBoxImage.Information);

                NomerDogovoraBox.Text = "";
                TovarName.Text = "";
                CountTovar.Text = "";
                Price.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
