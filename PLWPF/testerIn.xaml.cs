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

namespace PLWPF
{
    /// <summary>
    /// Interaction logic for testerIn.xaml
    /// </summary>
    public partial class testerIn : Window
    {
        BE.Tester tester;
        BL.IBL bl;

        public testerIn()
        {
            tester = new BE.Tester();
            bl = BL.factoryBL.BLGetInstance();
            InitializeComponent();
        }

        private void logIn_Click(object sender, RoutedEventArgs e)
        {
            tester = bl.findTester(Convert.ToInt32(idBox.Text));
            if (tester.firstName == nameBox.Text)
            {
                this.Visibility = Visibility.Collapsed;
                new testerShow(tester).ShowDialog();
            }
        }
    }
}
