﻿using RPM.Model;
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
namespace RPM.View
{
    /// <summary>
    /// Логика взаимодействия для WindowNewRole.xaml
    /// </summary>
    
    public partial class WindowNewRole : Window
    {
        private void BtSave_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
        //vmRole.ListRole.Add(role);
        public WindowNewRole()
        {
            InitializeComponent();

        }
    }
}
