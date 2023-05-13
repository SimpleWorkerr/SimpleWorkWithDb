﻿using System;
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
    /// Логика взаимодействия для ViewDogovor.xaml
    /// </summary>
    public partial class ViewDogovor : Window
    {
        private TestWorkDBEntities _testWorkDB = new TestWorkDBEntities();

        public ViewDogovor()
        {
            InitializeComponent();
            dataDogovor.ItemsSource = _testWorkDB.Договоры.ToList();
        }
    }
}
