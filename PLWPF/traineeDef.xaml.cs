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
    /// Interaction logic for traineeDef.xaml
    /// </summary>
    public partial class traineeDef : Window
    {
        public traineeDef()
        {
            InitializeComponent();
        }

        private void addTrainee_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
            new traineeData().ShowDialog();
        }

        private void getIn_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
            new traineeIn().ShowDialog();
        }
    }
}
