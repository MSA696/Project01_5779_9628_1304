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
        BL.IBL bl;

        public testerData()
        {
            InitializeComponent();
            tester = new BE.Tester();
            this.addGrid.DataContext = tester;
            bl = BL.factoryBL.BLGetInstance();

            this.comboBoxGender.ItemsSource = Enum.GetValues(typeof(BE._gender));
            this.comboBoxCarType.ItemsSource = Enum.GetValues(typeof(BE.car_Type));
            this.comboBoxGearType.ItemsSource = Enum.GetValues(typeof(BE.gear_Box));
        }
        
        private void addTester_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bl.addTester(tester);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Visibility = Visibility.Collapsed;
            new testerShow(tester).ShowDialog();
        }
        private void buttonLogOut_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        

        private void WH00(object sender, RoutedEventArgs e)
        {
            tester.workHour[0, 0] = true;
        }

        private void WH01(object sender, RoutedEventArgs e)
        {
            tester.workHour[0, 1] = true;
        }

        private void WH02(object sender, RoutedEventArgs e)
        {
            tester.workHour[0, 2] = true;
        }

        private void WH03(object sender, RoutedEventArgs e)
        {
            tester.workHour[0, 3] = true;
        }

        private void WH04(object sender, RoutedEventArgs e)
        {
            tester.workHour[0, 4] = true;
        }

        private void WH05(object sender, RoutedEventArgs e)
        {
            tester.workHour[0, 5] = true;
        }
    }
}
