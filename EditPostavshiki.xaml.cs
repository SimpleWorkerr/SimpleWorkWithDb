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
    /// Логика взаимодействия для EditPostavshiki.xaml
    /// </summary>
    public partial class EditPostavshiki : Window
    {
        private TestWorkDBEntities _testWorkDB = new TestWorkDBEntities();

        public EditPostavshiki()
        {
            InitializeComponent();

            KodPostavBox.ItemsSource = _testWorkDB.Поставщики.ToList();
        }

        private void EditPostav(object sender, RoutedEventArgs e)
        {
            try
            {
                Поставщики post = KodPostavBox.SelectedItem as Поставщики;

                _testWorkDB.Поставщики.Find(post.КодПоставщика).Адрес = AdresBox.Text;
                _testWorkDB.Поставщики.Find(post.КодПоставщика).Примечание = CommentBox.Text;

                _testWorkDB.SaveChanges();

                MessageBox.Show("Data has been edited", "SUCCESS", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void ChangePostav(object sender, SelectionChangedEventArgs e)
        {
            Поставщики post = KodPostavBox.SelectedItem as Поставщики;

            AdresBox.Text = post.Адрес;
            CommentBox.Text = post.Примечание;
        }
    }
}
