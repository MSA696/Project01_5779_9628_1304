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
    /// Interaction logic for traineeShow.xaml
    /// </summary>
    public partial class traineeShow : Window
    {
        BE.Trainee trainee;
        BE.Test test;
        BL.IBL bl;
        public traineeShow()
        {
            InitializeComponent();
            trainee = new BE.Trainee();

            bl = BL.factoryBL.BLGetInstance();
            this.addGrid.DataContext = trainee;
            this.showGrid.DataContext = trainee;
            this.findGrid.DataContext = bl.findTester(test.testerId);

            this.comboBoxGender.ItemsSource = Enum.GetValues(typeof(BE._gender));
            this.comboBoxCarType.ItemsSource = Enum.GetValues(typeof(BE.car_Type));
            this.comboBoxGearType.ItemsSource = Enum.GetValues(typeof(BE.gear_Box));
        }
        public traineeShow(BE.Trainee t )
        {
            InitializeComponent();
            trainee = t;

            bl = BL.factoryBL.BLGetInstance();
            this.addGrid.DataContext = trainee;
            this.showGrid.DataContext = trainee;
            this.findGrid.DataContext = bl.findTester(test.testerId);

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
            bl.updateTrainee(trainee);
            addGrid.Visibility = Visibility.Collapsed;
        }

        private void TextBlock_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            findGrid.Visibility = Visibility.Collapsed;
            this.Visibility = Visibility.Collapsed;
            new MainWindow.MainWindow().ShowDialog();
        }

        private void ListViewItem_Selected(object sender, RoutedEventArgs e)
        {
            findGrid.Visibility = Visibility.Collapsed;
            this.Visibility = Visibility.Collapsed;
            new MainWindow.MainWindow().ShowDialog();
        }

        private void TextBlock_PreviewMouseDown_1(object sender, MouseButtonEventArgs e)
        {
            findGrid.Visibility = Visibility.Collapsed;
            showGrid.Visibility = Visibility.Collapsed;
            addGrid.Visibility = Visibility.Visible;
        }
        private void ListViewItem_Selected_1(object sender, RoutedEventArgs e)
        {
            findGrid.Visibility = Visibility.Collapsed;
            showGrid.Visibility = Visibility.Collapsed;
            addGrid.Visibility = Visibility.Visible;
        }

        private void ListViewItem_Selected_2(object sender, RoutedEventArgs e)
        {

            test = new BE.Test();
            test.testerId = bl.TesterByDateandtime(test.testDate, test.testDey, test.testHour, bl.TesterByDistance(test.beginOfTestAdr, trainee.maxDis))[0].id;
            if (test.testerId!=0)
            {
                trainee.myTester = bl.findTester(test.testerId);
                trainee.myTester.trainees.Add(trainee);
                bl.updateTester(bl.findTester(trainee.myTester.id));
                bl.addTest(test);
            }


            findGrid.Visibility = Visibility.Visible;
            addGrid.Visibility = Visibility.Collapsed;
            showGrid.Visibility = Visibility.Collapsed;
        }

        private void TextBlock_PreviewMouseDown_2(object sender, MouseButtonEventArgs e)
        {
            test = new BE.Test();
            test.testerId = bl.TesterByDateandtime(test.testDate, test.testDey, test.testHour, bl.TesterByDistance(test.beginOfTestAdr, trainee.maxDis))[0].id;
            if (test.testerId != 0)
            {
                trainee.myTester = bl.findTester(test.testerId);
                trainee.myTester.trainees.Add(trainee);
                bl.updateTester(bl.findTester(trainee.myTester.id));
                bl.addTest(test);
            }


            findGrid.Visibility = Visibility.Visible;
            addGrid.Visibility = Visibility.Collapsed;
            showGrid.Visibility = Visibility.Collapsed;
        }
        private void TextBlock_PreviewMouseDown_3(object sender, MouseButtonEventArgs e)
        {
            findGrid.Visibility = Visibility.Collapsed;
            addGrid.Visibility = Visibility.Collapsed;
            showGrid.Visibility = Visibility.Visible;
        }

        private void ListViewItem_Selected_3(object sender, RoutedEventArgs e)
        {
            findGrid.Visibility = Visibility.Collapsed;
            addGrid.Visibility = Visibility.Collapsed;
            showGrid.Visibility = Visibility.Visible;
        }

        private void buttonLogOut_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
