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
    /// Логика взаимодействия для AddPostavhiki.xaml
    /// </summary>
    public partial class AddPostavhiki : Window
    {
        private TestWorkDBEntities _testWorkDB = new TestWorkDBEntities();

        public AddPostavhiki()
        {
            InitializeComponent();
        }

        public void AddPostavhikiButton(object sender, RoutedEventArgs e)
        {
            try
            {

                _testWorkDB.Поставщики.Add(new Поставщики()
                {
                    КодПоставщика = int.Parse(KodPostavBox.Text),
                    Адрес = AdresBox.Text,
                    Примечание = CommentBox.Text
                });

                _testWorkDB.SaveChanges();

                MessageBox.Show("Data has been added", "SUCCESS", MessageBoxButton.OK, MessageBoxImage.Information);

                KodPostavBox.Text = "";
                AdresBox.Text = "";
                CommentBox.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
