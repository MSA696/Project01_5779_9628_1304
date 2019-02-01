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
using System.Text.RegularExpressions;

namespace PLWPF
{
    /// <summary>
    /// Interaction logic for traineePass.xaml
    /// </summary>
    public partial class traineePass : Window
    {
        BE.Trainee trainee;
        BL.IBL bl;
        public traineePass()
        {
            InitializeComponent();
            bl = BL.factoryBL.BLGetInstance();
        }
        public traineePass(BE.Trainee t)
        {
            InitializeComponent();
            trainee = t;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
            new traineeShow(trainee).ShowDialog();
        }
    }
}
