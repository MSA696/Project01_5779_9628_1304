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

namespace PLWPF
{
    /// <summary>
    /// Interaction logic for traineeNotPass.xaml
    /// </summary>
    public partial class traineeNotPass : Window
    {
        BE.Trainee trainee;
        BL.IBL bl;
        public traineeNotPass()
        {
            InitializeComponent();
            bl = BL.factoryBL.BLGetInstance();
        }
        public traineeNotPass(BE.Trainee t)
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
