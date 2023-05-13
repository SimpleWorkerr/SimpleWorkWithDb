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
    /// Логика взаимодействия для AddUyer.xaml
    /// </summary>
    public partial class AddUyer : Window
    {
        private TestWorkDBEntities _testWorkDB = new TestWorkDBEntities();

        public AddUyer()
        {
            InitializeComponent();
        }

        private void AddUyerButton(object sender, RoutedEventArgs e)
        {
            try
            {
                _testWorkDB.ЮридическиеЛица.Add(new ЮридическиеЛица()
                {
                    КодПоставщика = int.Parse(KodPostavshikaBox.Text),
                    Название = TovarNameBox.Text,
                    НалоговыйНомер = NalogNomerBox.Text,
                    НомерСвидетельства = NumberSvid.Text
                });

                _testWorkDB.SaveChanges();

                MessageBox.Show("Data has been added", "SUCCESS", MessageBoxButton.OK, MessageBoxImage.Information);

                KodPostavshikaBox.Text = "";
                TovarNameBox.Text = "";
                NalogNomerBox.Text = "";
                NumberSvid.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
