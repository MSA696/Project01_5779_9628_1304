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
