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
    /// Логика взаимодействия для Query_2.xaml
    /// </summary>
    public partial class Query_2 : Window
    {
        private TestWorkDBEntities _testWorkDB = new TestWorkDBEntities();
        public Query_2()
        {
            InitializeComponent();

            var result = from postavshiki
                         in _testWorkDB.Поставщики
                         join dogovori in _testWorkDB.Договоры on postavshiki.КодПоставщика
                         equals dogovori.КодПоставщика
                         join postavleno in _testWorkDB.Поставлено on dogovori.НомерДоговора
                         equals postavleno.НомерДоговора
                         where postavshiki.КодПоставщика == 1
                         orderby postavleno.Цена descending
                         select new 
                         {
                             КодПоставщика = postavshiki.КодПоставщика,
                             НомерДоговора = dogovori.НомерДоговора,
                             Товар = postavleno.Товар,
                             Цена = postavleno.Цена,
                             Количество = postavleno.Количество
                         };

            dataGrid.ItemsSource = result.ToList();
        }
    }
}
