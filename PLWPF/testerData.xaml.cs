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
    /// Interaction logic for testerData.xaml
    /// </summary>
    public partial class testerData : Window
    {
        BE.Tester tester;
        BL.BL_imp bl;

        public testerData()
        {
            InitializeComponent();
            tester = new BE.Tester();
            this.addGrid.DataContext = tester;
            //bl = BL.FactoryBL.GetBL();
        }

        private void buttonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            buttonOpenMenu.Visibility = Visibility.Collapsed;
            buttonCloseMenu.Visibility = Visibility.Visible;
        }

        private void buttonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            buttonOpenMenu.Visibility = Visibility.Visible;
            buttonCloseMenu.Visibility = Visibility.Collapsed;
        }

        private void addTester_Click(object sender, RoutedEventArgs e)
        {
            bl.addTester(tester);
            tester = new BE.Tester();
            this.addGrid.DataContext = tester;
        }
    }
}
