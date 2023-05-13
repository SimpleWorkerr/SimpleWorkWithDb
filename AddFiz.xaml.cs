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
    /// Логика взаимодействия для AddFiz.xaml
    /// </summary>
    public partial class AddFiz : Window
    {
        private TestWorkDBEntities _testWorkDB = new TestWorkDBEntities();

        public AddFiz()
        {
            InitializeComponent();
        }

        public void AddFizButton(object sender, RoutedEventArgs e)
        {
            try
            {
                _testWorkDB.ФизическиеЛица.Add(new ФизическиеЛица()
                {
                    КодПоставщика = int.Parse(KodPostavshikaBox.Text),
                    Фамилия = SecondNameBox.Text,
                    Имя = NameBox.Text,
                    Отчество = FatherNameBox.Text,
                    НомерСвидетельства = NumberSvid.Text
                });

                _testWorkDB.SaveChanges();

                MessageBox.Show("Data has been added", "SUCCESS", MessageBoxButton.OK, MessageBoxImage.Information);

                SecondNameBox.Text = "";
                NameBox.Text = "";
                NumberSvid.Text = "";
                FatherNameBox.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
