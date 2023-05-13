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
    /// Логика взаимодействия для EditDogovor.xaml
    /// </summary>
    public partial class EditDogovor : Window
    {
        private TestWorkDBEntities _testWorkDB = new TestWorkDBEntities();
        public EditDogovor()
        {
            InitializeComponent();
            NomerDogovorBox.ItemsSource = _testWorkDB.Договоры.ToList();
        }

        private void EditDogovore(object sender, RoutedEventArgs e)
        {
            try
            {
                Договоры dogovor = NomerDogovorBox.SelectedItem as Договоры;

                _testWorkDB.Договоры.Find(dogovor.НомерДоговора).ДатаДоговора = DateTime.Parse(DateDogovorBox.Text);
                _testWorkDB.Договоры.Find(dogovor.НомерДоговора).КодПоставщика = int.Parse(CodePostavshikBox.Text);
                _testWorkDB.Договоры.Find(dogovor.НомерДоговора).Комментарий = CommentBox.Text;

                _testWorkDB.SaveChanges();

                MessageBox.Show("Data has been edited", "SUCCESS", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ChangeDogovor(object sender, SelectionChangedEventArgs e)
        {
            Договоры dogovor = NomerDogovorBox.SelectedItem as Договоры;

            DateDogovorBox.Text = dogovor.ДатаДоговора.ToString();
            CodePostavshikBox.Text = dogovor.КодПоставщика.ToString();
            CommentBox.Text = dogovor.Комментарий;
        }
    }
}
