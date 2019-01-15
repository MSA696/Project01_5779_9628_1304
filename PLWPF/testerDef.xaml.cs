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
    /// Interaction logic for testerDef.xaml
    /// </summary>
    public partial class testerDef : Window
    {
        public testerDef()
        {
            InitializeComponent();
        }

        private void addTrainee_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
            new testerIn().ShowDialog();
        }

        private void getIn_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
            new testerIn().ShowDialog();
        }
    }
}
