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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LabWork_8_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //Поставщики
        private void OpenViewPostavshiki(object sender, RoutedEventArgs e)
        {
            ViewPostavshiki viewPostavshiki = new ViewPostavshiki();
            viewPostavshiki.Show();
        }
        private void OpenAddPostavhiki(object sender, RoutedEventArgs e)
        {
            AddPostavhiki addPostavhiki = new AddPostavhiki();
            addPostavhiki.Show();
        }
        private void OpenEditPostavshiki(Object sender, RoutedEventArgs e)
        {
            EditPostavshiki editPostavshiki = new EditPostavshiki();
            editPostavshiki.Show();
        }
        private void OpenDeletePostavshiki(object sender, RoutedEventArgs e)
        {
            DeletePostavshiki deletePostavshiki = new DeletePostavshiki();
            deletePostavshiki.Show();
        }
        //~Поставщики

        //Договоры
        private void OpenViewDogovor(object sender, RoutedEventArgs e)
        {
            ViewDogovor viewDogovor = new ViewDogovor();
            viewDogovor.Show();
        }
        private void OpenEditDogovor(Object sender, RoutedEventArgs e)
        {
            EditDogovor editDogovor = new EditDogovor();
            editDogovor.Show();
        }
        private void OpenDeleteDogovor(Object sender, RoutedEventArgs e)
        {
            DeleteDogovor deleteDogovor = new DeleteDogovor();
            deleteDogovor.Show();
        }
        private void OpenAddDogovor(Object sender, RoutedEventArgs e)
        {
            AddDogovor addDogovor = new AddDogovor();
            addDogovor.Show();
        }
        //~Договоры

        //Поставлено
        private void OpenViewPostavleno(object sender, RoutedEventArgs e)
        {
            ViewPostavleno viewPostavleno = new ViewPostavleno();
            viewPostavleno.Show();
        }
        private void OpenAddPostavleno(Object sender, RoutedEventArgs e)
        {
            AddPostavleno addPostavleno = new AddPostavleno();
            addPostavleno.Show();
        }
        private void OpenEditPostaveno(Object sender, RoutedEventArgs e)
        {
            EditPostavleno editPostavleno = new EditPostavleno();
            editPostavleno.Show();
        }
        private void OpenDeletePostavleno(object sender, RoutedEventArgs e)
        {
            DeletePostavleno1 deletePostavleno = new DeletePostavleno1();
            deletePostavleno.Show();
        }
        //~Поставлено

        //Физические лица
        private void OpenViewFiz(object sender, RoutedEventArgs e)
        {
            ViewFiz viewFiz = new ViewFiz();
            viewFiz.Show();
        }
        private void OpenEditFiz(object sender, RoutedEventArgs e)
        {
            EditFiz editFiz = new EditFiz();
            editFiz.Show();
        }
        private void OpenDeleteFiz(object sender, RoutedEventArgs e)
        {
            DeleteFiz deleteFiz = new DeleteFiz();
            deleteFiz.Show();
        }
        private void OpenAddFiz(object sender, RoutedEventArgs e)
        {
            AddFiz addFiz = new AddFiz();
            addFiz.Show();
        }
        //~Физические лица

        //Юридические лица
        private void OpenViewUyer(object sender, RoutedEventArgs e)
        {
            ViewUyer viewUyer = new ViewUyer();
            viewUyer.Show();
        }
        private void OpenEditUyer(object sender, RoutedEventArgs e)
        {
            EditUyer editUyer = new EditUyer();
            editUyer.Show();
        }
        private void OpenDeleteUyer(object sender, RoutedEventArgs e)
        {
            DeleteUyer deleteUyer = new DeleteUyer();
            deleteUyer.Show();
        }
        private void OpenAddUyer(object sender, RoutedEventArgs e)
        {
            AddUyer addUyer = new AddUyer();
            addUyer.Show();
        }
        //~Юридические лица

        //Запросы
        private void OpenQuery_1(object sender, RoutedEventArgs e)
        {
            Query_1 query_1 = new Query_1();
            query_1.Show();
        }

        private void OpenQuery_2(object sender, RoutedEventArgs e)
        {
            Query_2 query_2 = new Query_2();
            query_2.Show();
        }

        private void OpenQuery_3(object sender, RoutedEventArgs e)
        {
            Query_3 query_3 = new Query_3();
            query_3.Show();
        }
        //~Запросы

    }
}
