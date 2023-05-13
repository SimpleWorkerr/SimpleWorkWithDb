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
    /// Логика взаимодействия для ViewPostavleno.xaml
    /// </summary>
    public partial class ViewPostavleno : Window
    {
        private TestWorkDBEntities _testWorkDB = new TestWorkDBEntities();
        public ViewPostavleno()
        {
            InitializeComponent();

            dataPostavleno.ItemsSource = _testWorkDB.Поставлено.ToList();
        }
    }
}
