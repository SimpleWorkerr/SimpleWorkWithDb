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
    /// Логика взаимодействия для AddDogovor.xaml
    /// </summary>
    public partial class AddDogovor : Window
    {
        private TestWorkDBEntities _testWorkDB = new TestWorkDBEntities();
        public AddDogovor()
        {
            InitializeComponent();
        }

        public void AddDogovorButton(object sender, RoutedEventArgs e)
        {
            try
            {
                _testWorkDB.Договоры.Add(new Договоры()
                {
                    КодПоставщика = int.Parse(CodePostavshikBox.Text),
                    ДатаДоговора = DateTime.Parse(DateDogovorBox.Text),
                    Комментарий = CommentBox.Text
                });

                _testWorkDB.SaveChanges();

                MessageBox.Show("Data has been added", "SUCCESS", MessageBoxButton.OK, MessageBoxImage.Information);

                DateDogovorBox.Text = "";
                CodePostavshikBox.Text = "";
                CommentBox.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
