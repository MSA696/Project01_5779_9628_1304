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
    /// Interaction logic for traineeIn.xaml
    /// </summary>
    public partial class traineeIn : Window
    {
        BE.Trainee trainee;
        BL.IBL bl = BL.factoryBL.BLGetInstance();
        public traineeIn()
        {
            InitializeComponent();
        }

        private void logIn_Click(object sender, RoutedEventArgs e)
        {
            trainee = bl.findTrainee(Convert.ToInt32(idBox.Text));
            if (trainee.firstName == nameBox.Text)
            {
                this.Visibility = Visibility.Collapsed;
                new traineeShow(trainee).ShowDialog();
            }
        }

        private void logIn_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
