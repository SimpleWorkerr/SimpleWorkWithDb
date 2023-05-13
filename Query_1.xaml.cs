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
    /// Логика взаимодействия для Query_1.xaml
    /// </summary>
    public partial class Query_1 : Window
    {
        private TestWorkDBEntities _testWorkDB = new TestWorkDBEntities();
        public Query_1()
        {
            InitializeComponent();

            var result = from postavleno in _testWorkDB.Поставлено where postavleno.Цена > 500 orderby postavleno.Цена select postavleno;

            dataPostavleno.ItemsSource = result.ToList();
        }


    }
}
