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
                tester.addr.city = this.cityAddressBox.Text;
                tester.addr.street = this.streetAddressBox.Text;
                tester.addr.building = Convert.ToInt32(this.buildingNumBox.Text);
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

        private void WH00not(object sender, RoutedEventArgs e)
        {
            tester.workHour[0, 0] = false;
        }

        private void WH01(object sender, RoutedEventArgs e)
        {
            tester.workHour[0, 1] = true;
        }

        private void WH01not(object sender, RoutedEventArgs e)
        {
            tester.workHour[0, 1] = false;
        }

        private void WH02(object sender, RoutedEventArgs e)
        {
            tester.workHour[0, 2] = true;
        }

        private void WH02not(object sender, RoutedEventArgs e)
        {
            tester.workHour[0, 2] = false;
        }

        private void WH03(object sender, RoutedEventArgs e)
        {
            tester.workHour[0, 3] = true;
        }

        private void WH03not(object sender, RoutedEventArgs e)
        {
            tester.workHour[0, 3] = false;
        }

        private void WH04(object sender, RoutedEventArgs e)
        {
            tester.workHour[0, 4] = true;
        }

        private void WH04not(object sender, RoutedEventArgs e)
        {
            tester.workHour[0, 4] = false;
        }

        private void WH05(object sender, RoutedEventArgs e)
        {
            tester.workHour[0, 5] = true;
        }

        private void WH05not(object sender, RoutedEventArgs e)
        {
            tester.workHour[0, 5] = false;
        }

        private void WH10(object sender, RoutedEventArgs e)
        {
            tester.workHour[1, 0] = true;
        }

        private void WH10not(object sender, RoutedEventArgs e)
        {
            tester.workHour[1, 0] = false;
        }

        private void WH11(object sender, RoutedEventArgs e)
        {
            tester.workHour[1, 1] = true;
        }

        private void WH11not(object sender, RoutedEventArgs e)
        {
            tester.workHour[1, 1] = false;
        }

        private void WH12(object sender, RoutedEventArgs e)
        {
            tester.workHour[1, 2] = true;
        }

        private void WH12not(object sender, RoutedEventArgs e)
        {
            tester.workHour[1, 2] = false;
        }

        private void WH13(object sender, RoutedEventArgs e)
        {
            tester.workHour[1, 3] = true;
        }

        private void WH13not(object sender, RoutedEventArgs e)
        {
            tester.workHour[1, 3] = false;
        }

        private void WH14(object sender, RoutedEventArgs e)
        {
            tester.workHour[1, 4] = true;
        }

        private void WH14not(object sender, RoutedEventArgs e)
        {
            tester.workHour[1, 4] = false;
        }

        private void WH15(object sender, RoutedEventArgs e)
        {
            tester.workHour[1, 5] = true;
        }

        private void WH15not(object sender, RoutedEventArgs e)
        {
            tester.workHour[1, 5] = false;
        }

        private void WH20(object sender, RoutedEventArgs e)
        {
            tester.workHour[2, 0] = true;
        }

        private void WH20not(object sender, RoutedEventArgs e)
        {
            tester.workHour[2, 0] = false;
        }

        private void WH21(object sender, RoutedEventArgs e)
        {
            tester.workHour[2, 1] = true;
        }

        private void WH21not(object sender, RoutedEventArgs e)
        {
            tester.workHour[2, 1] = false;
        }

        private void WH22(object sender, RoutedEventArgs e)
        {
            tester.workHour[2, 2] = true;
        }

        private void WH22not(object sender, RoutedEventArgs e)
        {
            tester.workHour[2, 2] = false;
        }

        private void WH23(object sender, RoutedEventArgs e)
        {
            tester.workHour[2, 3] = true;
        }

        private void WH23not(object sender, RoutedEventArgs e)
        {
            tester.workHour[2, 3] = false;
        }

        private void WH24(object sender, RoutedEventArgs e)
        {
            tester.workHour[2, 4] = true;
        }

        private void WH24not(object sender, RoutedEventArgs e)
        {
            tester.workHour[2, 4] = false;
        }

        private void WH25(object sender, RoutedEventArgs e)
        {
            tester.workHour[2, 5] = true;
        }

        private void WH25not(object sender, RoutedEventArgs e)
        {
            tester.workHour[2, 5] = false;
        }

        private void WH30(object sender, RoutedEventArgs e)
        {
            tester.workHour[3, 0] = true;
        }

        private void WH30not(object sender, RoutedEventArgs e)
        {
            tester.workHour[3, 0] = false;
        }

        private void WH31(object sender, RoutedEventArgs e)
        {
            tester.workHour[3, 1] = true;
        }

        private void WH31not(object sender, RoutedEventArgs e)
        {
            tester.workHour[3, 1] = false;
        }

        private void WH32(object sender, RoutedEventArgs e)
        {
            tester.workHour[3, 2] = true;
        }

        private void WH32not(object sender, RoutedEventArgs e)
        {
            tester.workHour[3, 2] = false;
        }

        private void WH33(object sender, RoutedEventArgs e)
        {
            tester.workHour[3, 3] = true;
        }

        private void WH33not(object sender, RoutedEventArgs e)
        {
            tester.workHour[3, 3] = false;
        }

        private void WH34(object sender, RoutedEventArgs e)
        {
            tester.workHour[3, 4] = true;
        }

        private void WH34not(object sender, RoutedEventArgs e)
        {
            tester.workHour[3, 4] = false;
        }

        private void WH35(object sender, RoutedEventArgs e)
        {
            tester.workHour[3, 5] = true;
        }

        private void WH35not(object sender, RoutedEventArgs e)
        {
            tester.workHour[3, 5] = false;
        }

        private void WH40(object sender, RoutedEventArgs e)
        {
            tester.workHour[4, 0] = true;
        }

        private void WH40not(object sender, RoutedEventArgs e)
        {
            tester.workHour[4, 0] = false;
        }

        private void WH41(object sender, RoutedEventArgs e)
        {
            tester.workHour[4, 1] = true;
        }

        private void WH41not(object sender, RoutedEventArgs e)
        {
            tester.workHour[4, 1] = false;
        }

        private void WH42(object sender, RoutedEventArgs e)
        {
            tester.workHour[4, 2] = true;
        }

        private void WH42not(object sender, RoutedEventArgs e)
        {
            tester.workHour[4, 2] = false;
        }

        private void WH43(object sender, RoutedEventArgs e)
        {
            tester.workHour[4, 3] = true;
        }

        private void WH43not(object sender, RoutedEventArgs e)
        {
            tester.workHour[4, 3] = false;
        }

        private void WH44(object sender, RoutedEventArgs e)
        {
            tester.workHour[4, 4] = true;
        }

        private void WH44not(object sender, RoutedEventArgs e)
        {
            tester.workHour[4, 4] = false;
        }

        private void WH45(object sender, RoutedEventArgs e)
        {
            tester.workHour[4, 5] = true;
        }

        private void WH45not(object sender, RoutedEventArgs e)
        {
            tester.workHour[4, 5] = true;
        }
    }
}
