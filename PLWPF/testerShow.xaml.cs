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
            //add func
        }

        private void TextBlock_PreviewMouseDown_2(object sender, MouseButtonEventArgs e)
        {
            //add func
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
        
    }
}
