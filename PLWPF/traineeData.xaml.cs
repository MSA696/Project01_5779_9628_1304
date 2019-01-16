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
    /// Interaction logic for traineeData.xaml
    /// </summary>
    public partial class traineeData : Window
    {
        BE.Trainee trainee;
        BL.BL_imp bl;
        public traineeData()
        {
            InitializeComponent();
            trainee = new BE.Trainee();
            this.addGrid.DataContext = trainee;
            //bl = BL.FactoryBL.GetBL();
        }

        private void addTester_Click(object sender, RoutedEventArgs e)
        {
            bl.addTrainee(trainee);
            trainee = new BE.Trainee();
            this.addGrid.DataContext = trainee;
        }
    }
}