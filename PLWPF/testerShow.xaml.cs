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
    /// Interaction logic for testerShow.xaml
    /// </summary>
    public partial class testerShow : Window
    {
        BE.Tester tester;
        BL.IBL bl;

        public testerShow()
        {
            InitializeComponent();
            tester = new BE.Tester();
            this.saveGrid.DataContext = tester;
            this.showGrid.DataContext = tester;
            bl = BL.factoryBL.BLGetInstance();

            this.comboBoxGender.ItemsSource = Enum.GetValues(typeof(BE._gender));
            this.comboBoxCarType.ItemsSource = Enum.GetValues(typeof(BE.car_Type));
            this.comboBoxGearType.ItemsSource = Enum.GetValues(typeof(BE.gear_Box));


            this.cityAddressShowLableB.Content = tester.addr.city;
            this.streetAddressShowLableB.Content = tester.addr.street;
            this.buildingNumShowLableB.Content = tester.addr.building;


            //checkbox definition
            checkBox1_1.IsChecked = tester.workHour[0, 0];
            checkBox1_2.IsChecked = tester.workHour[0, 1];
            checkBox1_3.IsChecked = tester.workHour[0, 2];
            checkBox1_4.IsChecked = tester.workHour[0, 3];
            checkBox1_5.IsChecked = tester.workHour[0, 4];
            checkBox1_6.IsChecked = tester.workHour[0, 5];
            checkBox2_1.IsChecked = tester.workHour[1, 0];
            checkBox2_2.IsChecked = tester.workHour[1, 1];
            checkBox2_3.IsChecked = tester.workHour[1, 2];
            checkBox2_4.IsChecked = tester.workHour[1, 3];
            checkBox2_5.IsChecked = tester.workHour[1, 4];
            checkBox2_6.IsChecked = tester.workHour[1, 5];
            checkBox3_1.IsChecked = tester.workHour[2, 0];
            checkBox3_2.IsChecked = tester.workHour[2, 1];
            checkBox3_3.IsChecked = tester.workHour[2, 2];
            checkBox3_4.IsChecked = tester.workHour[2, 3];
            checkBox3_5.IsChecked = tester.workHour[2, 4];
            checkBox3_6.IsChecked = tester.workHour[2, 5];
            checkBox4_1.IsChecked = tester.workHour[3, 0];
            checkBox4_2.IsChecked = tester.workHour[3, 1];
            checkBox4_3.IsChecked = tester.workHour[3, 2];
            checkBox4_4.IsChecked = tester.workHour[3, 3];
            checkBox4_5.IsChecked = tester.workHour[3, 4];
            checkBox4_6.IsChecked = tester.workHour[3, 5];
            checkBox5_1.IsChecked = tester.workHour[4, 0];
            checkBox5_2.IsChecked = tester.workHour[4, 1];
            checkBox5_3.IsChecked = tester.workHour[4, 2];
            checkBox5_4.IsChecked = tester.workHour[4, 3];
            checkBox5_5.IsChecked = tester.workHour[4, 4];
            checkBox5_6.IsChecked = tester.workHour[4, 5];
            //
        }
        public testerShow(BE.Tester t)
        {
            InitializeComponent();
            tester = t;
            this.saveGrid.DataContext = tester;
            this.showGrid.DataContext = tester;
            bl = BL.factoryBL.BLGetInstance();

            this.comboBoxGender.ItemsSource = Enum.GetValues(typeof(BE._gender));
            this.comboBoxCarType.ItemsSource = Enum.GetValues(typeof(BE.car_Type));
            this.comboBoxGearType.ItemsSource = Enum.GetValues(typeof(BE.gear_Box));

            this.cityAddressShowLableB.Content = tester.addr.city;
            this.streetAddressShowLableB.Content = tester.addr.street;
            this.buildingNumShowLableB.Content = tester.addr.building;

            //checkbox definition
            checkBox1_1.IsChecked = tester.workHour[0, 0];
            checkBox1_2.IsChecked = tester.workHour[0, 1];
            checkBox1_3.IsChecked = tester.workHour[0, 2];
            checkBox1_4.IsChecked = tester.workHour[0, 3];
            checkBox1_5.IsChecked = tester.workHour[0, 4];
            checkBox1_6.IsChecked = tester.workHour[0, 5];
            checkBox2_1.IsChecked = tester.workHour[1, 0];
            checkBox2_2.IsChecked = tester.workHour[1, 1];
            checkBox2_3.IsChecked = tester.workHour[1, 2];
            checkBox2_4.IsChecked = tester.workHour[1, 3];
            checkBox2_5.IsChecked = tester.workHour[1, 4];
            checkBox2_6.IsChecked = tester.workHour[1, 5];
            checkBox3_1.IsChecked = tester.workHour[2, 0];
            checkBox3_2.IsChecked = tester.workHour[2, 1];
            checkBox3_3.IsChecked = tester.workHour[2, 2];
            checkBox3_4.IsChecked = tester.workHour[2, 3];
            checkBox3_5.IsChecked = tester.workHour[2, 4];
            checkBox3_6.IsChecked = tester.workHour[2, 5];
            checkBox4_1.IsChecked = tester.workHour[3, 0];
            checkBox4_2.IsChecked = tester.workHour[3, 1];
            checkBox4_3.IsChecked = tester.workHour[3, 2];
            checkBox4_4.IsChecked = tester.workHour[3, 3];
            checkBox4_5.IsChecked = tester.workHour[3, 4];
            checkBox4_6.IsChecked = tester.workHour[3, 5];
            checkBox5_1.IsChecked = tester.workHour[4, 0];
            checkBox5_2.IsChecked = tester.workHour[4, 1];
            checkBox5_3.IsChecked = tester.workHour[4, 2];
            checkBox5_4.IsChecked = tester.workHour[4, 3];
            checkBox5_5.IsChecked = tester.workHour[4, 4];
            checkBox5_6.IsChecked = tester.workHour[4, 5];

            ShowCheckBox1_1.IsChecked = tester.workHour[0, 0];
            ShowCheckBox1_2.IsChecked = tester.workHour[0, 1];
            ShowCheckBox1_3.IsChecked = tester.workHour[0, 2];
            ShowCheckBox1_4.IsChecked = tester.workHour[0, 3];
            ShowCheckBox1_5.IsChecked = tester.workHour[0, 4];
            ShowCheckBox1_6.IsChecked = tester.workHour[0, 5];
            ShowCheckBox2_1.IsChecked = tester.workHour[1, 0];
            ShowCheckBox2_2.IsChecked = tester.workHour[1, 1];
            ShowCheckBox2_3.IsChecked = tester.workHour[1, 2];
            ShowCheckBox2_4.IsChecked = tester.workHour[1, 3];
            ShowCheckBox2_5.IsChecked = tester.workHour[1, 4];
            ShowCheckBox2_6.IsChecked = tester.workHour[1, 5];
            ShowCheckBox3_1.IsChecked = tester.workHour[2, 0];
            ShowCheckBox3_2.IsChecked = tester.workHour[2, 1];
            ShowCheckBox3_3.IsChecked = tester.workHour[2, 2];
            ShowCheckBox3_4.IsChecked = tester.workHour[2, 3];
            ShowCheckBox3_5.IsChecked = tester.workHour[2, 4];
            ShowCheckBox3_6.IsChecked = tester.workHour[2, 5];
            ShowCheckBox4_1.IsChecked = tester.workHour[3, 0];
            ShowCheckBox4_2.IsChecked = tester.workHour[3, 1];
            ShowCheckBox4_3.IsChecked = tester.workHour[3, 2];
            ShowCheckBox4_4.IsChecked = tester.workHour[3, 3];
            ShowCheckBox4_5.IsChecked = tester.workHour[3, 4];
            ShowCheckBox4_6.IsChecked = tester.workHour[3, 5];
            ShowCheckBox5_1.IsChecked = tester.workHour[4, 0];
            ShowCheckBox5_2.IsChecked = tester.workHour[4, 1];
            ShowCheckBox5_3.IsChecked = tester.workHour[4, 2];
            ShowCheckBox5_4.IsChecked = tester.workHour[4, 3];
            ShowCheckBox5_5.IsChecked = tester.workHour[4, 4];
            ShowCheckBox5_6.IsChecked = tester.workHour[4, 5];
            //
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

        private void saveTester_Click(object sender, RoutedEventArgs e)
        {
            bl.updateTester(tester);
            saveGrid.Visibility = Visibility.Collapsed;
            showGrid.Visibility = Visibility.Visible;
            
        }

        private void TextBlock_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
            new MainWindow.MainWindow().ShowDialog();
        }

        private void ListViewItem_Selected(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
            new MainWindow.MainWindow().ShowDialog();
        }

        private void TextBlock_PreviewMouseDown_1(object sender, MouseButtonEventArgs e)
        {
            showGrid.Visibility = Visibility.Collapsed;
            saveGrid.Visibility = Visibility.Visible;
        }
        private void ListViewItem_Selected_1(object sender, RoutedEventArgs e)
        {
            showGrid.Visibility = Visibility.Collapsed;
            saveGrid.Visibility = Visibility.Visible;
        }

        private void ListViewItem_Selected_2(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
            new testerScore().ShowDialog();
        }

        private void TextBlock_PreviewMouseDown_2(object sender, MouseButtonEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
            new testerScore().ShowDialog();
        }
        private void TextBlock_PreviewMouseDown_3(object sender, MouseButtonEventArgs e)
        {
            saveGrid.Visibility = Visibility.Collapsed;
            showGrid.Visibility = Visibility.Visible;
        }

        private void ListViewItem_Selected_3(object sender, RoutedEventArgs e)
        {
            saveGrid.Visibility = Visibility.Collapsed;
            showGrid.Visibility = Visibility.Visible;
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

        private void deleteTester_Click(object sender, RoutedEventArgs e)
        {
            bl.deleteTester(tester);
        }
    }
}
