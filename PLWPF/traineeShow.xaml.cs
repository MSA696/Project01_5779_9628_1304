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
using System.Text.RegularExpressions;

namespace PLWPF
{
    /// <summary>
    /// Interaction logic for traineeShow.xaml
    /// </summary>
    public partial class traineeShow : Window
    {
        BE.Trainee trainee;
        BL.IBL bl;
        public traineeShow()
        {
            InitializeComponent();
            trainee = new BE.Trainee();

            bl = BL.factoryBL.BLGetInstance();
            this.addGrid.DataContext = trainee;
            this.showGrid.DataContext = trainee;

            this.cityAddressShowLableB.Content = trainee.addr.city;
            this.streetAddressShowLableB.Content = trainee.addr.street;
            this.buildingNumShowLableB.Content = trainee.addr.building;
                
            this.comboBoxGender.ItemsSource = Enum.GetValues(typeof(BE._gender));
            this.comboBoxCarType.ItemsSource = Enum.GetValues(typeof(BE.car_Type));
            this.comboBoxGearType.ItemsSource = Enum.GetValues(typeof(BE.gear_Box));
        }
        public traineeShow(BE.Trainee t )
        {
            InitializeComponent();
            trainee = t;

            bl = BL.factoryBL.BLGetInstance();
            this.DataContext = t;
            //this.addGrid.DataContext = trainee;
            //this.showGrid.DataContext = trainee;

            this.comboBoxGender.ItemsSource = Enum.GetValues(typeof(BE._gender));
            this.comboBoxCarType.ItemsSource = Enum.GetValues(typeof(BE.car_Type));
            this.comboBoxGearType.ItemsSource = Enum.GetValues(typeof(BE.gear_Box));
            this.comboBoxTestHour.ItemsSource = Enum.GetValues(typeof(BE.hours));

            this.cityAddressShowLableB.Content = trainee.addr.city;
            this.streetAddressShowLableB.Content = trainee.addr.street;
            this.buildingNumShowLableB.Content = trainee.addr.building;

            this.cityAddressBox.Text = trainee.addr.city;
            this.streetAddressBox.Text = trainee.addr.street;
            this.numAddressBox.Text = trainee.addr.building.ToString();
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
            try
            {
                trainee.addr.city = this.cityAddressBox.Text;
                trainee.addr.street = this.streetAddressBox.Text;
                trainee.addr.building = Convert.ToInt32(this.numAddressBox.Text);

                BE.Test myTest = bl.findTest(trainee.myTestId);
                myTest.testDate = Convert.ToDateTime(this.testDateComboBox.SelectedDate);
                myTest.testDay = (BE.days)(this.comboBoxTestHour.SelectedItem);
                myTest.testHour = (BE.hours)(this.comboBoxTestHour.SelectedItem);
                
                if (this.birthDatePicker.SelectedDate > DateTime.Now.AddYears(-18)) throw new Exception("You must be over 18.");
                if (this.birthDatePicker.SelectedDate < DateTime.Now.AddYears(-70)) throw new Exception("You are to old.");
                if (this.testDateComboBox.SelectedDate <= DateTime.Now) throw new Exception("Your test day must be from today.");
                if (int.Parse(this.maxDisBox.Text) < 0) throw new Exception("Distance must be over 0.");
                int tmp = (int)myTest.testDate.DayOfWeek;
                trainee.testDay = (BE.days)tmp;
                if ((int)trainee.testDay > 4) throw new Exception("This is not work day.");
                Regex reg = new Regex(@"^[0-9]*$");
                if (!reg.IsMatch(this.numAddressBox.Text)) throw new Exception("Invalid building number.");
                reg = new Regex(@"^\d{10}$");
                if (!reg.IsMatch(this.phoneBox.Text)) throw new Exception("Invalid phone number.");
                if (int.Parse(this.phoneBox.Text) < 0500000000 || int.Parse(this.phoneBox.Text) > 0599999999) throw new Exception("Invalid phone number.");

                if (int.Parse(classNumBox.Text) < 28) throw new Exception("Less then 28 class.");
                bl.updateTest(myTest);
                bl.updateTrainee(trainee);
                addGrid.Visibility = Visibility.Collapsed;
                showGrid.Visibility = Visibility.Visible;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR. \n" + ex.Message);
            }
        }

        private void TextBlock_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            helpGrid.Visibility = Visibility.Collapsed;
            findGrid.Visibility = Visibility.Collapsed;
            this.Visibility = Visibility.Collapsed;
            new MainWindow.MainWindow().ShowDialog();
        }

        private void ListViewItem_Selected(object sender, RoutedEventArgs e)
        {
            helpGrid.Visibility = Visibility.Collapsed;
            findGrid.Visibility = Visibility.Collapsed;
            this.Visibility = Visibility.Collapsed;
            new MainWindow.MainWindow().ShowDialog();
        }

        private void TextBlock_PreviewMouseDown_1(object sender, MouseButtonEventArgs e)
        {
            helpGrid.Visibility = Visibility.Collapsed;
            findGrid.Visibility = Visibility.Collapsed;
            showGrid.Visibility = Visibility.Collapsed;
            addGrid.Visibility = Visibility.Visible;
        }
        private void ListViewItem_Selected_1(object sender, RoutedEventArgs e)
        {
            helpGrid.Visibility = Visibility.Collapsed;
            findGrid.Visibility = Visibility.Collapsed;
            showGrid.Visibility = Visibility.Collapsed;
            addGrid.Visibility = Visibility.Visible;
        }

        private void ListViewItem_Selected_2(object sender, RoutedEventArgs e)
        {

            BE.Test myTest = bl.findTest(trainee.myTestId);
            myTest.testerId = bl.findTester(myTest.beginOfTestAdr, trainee.maxDis, myTest.testDate, myTest.testDay, myTest.testHour,trainee.id, trainee.carType).id;
            if (myTest.testerId!=0)
            {
                trainee.myTesterId = bl.findTester(myTest.testerId).id;
                trainee.testsNum += 1;
                bl.updateTest(myTest);
            }
            this.findGrid.DataContext = bl.findTester(myTest.testerId);
            this.testFindDateLableB.Content = myTest.testDate.ToString("dd/MM/yyyy");//
            this.testFindHourLableB.Content = myTest.testHour.ToString();//
            

            helpGrid.Visibility = Visibility.Collapsed;
            findGrid.Visibility = Visibility.Visible;
            addGrid.Visibility = Visibility.Collapsed;
            showGrid.Visibility = Visibility.Collapsed;
        }

        private void TextBlock_PreviewMouseDown_2(object sender, MouseButtonEventArgs e)
        {
            try
            {
                BE.Test myTest = bl.findTest(trainee.myTestId);
                myTest.testerId = bl.findTester(myTest.beginOfTestAdr, trainee.maxDis, myTest.testDate, myTest.testDay, myTest.testHour, trainee.id, trainee.carType).id;
                if (myTest.testerId != 0)
                {
                    trainee.myTesterId = bl.findTester(myTest.testerId).id;
                    trainee.testsNum += 1;
                    bl.addTest(myTest);
                }
                this.findGrid.DataContext = bl.findTester(myTest.testerId);

                this.testFindDateLableB.Content = myTest.testDate.ToString();//
                this.testFindHourLableB.Content = myTest.testHour.ToString();//

                helpGrid.Visibility = Visibility.Collapsed;
                findGrid.Visibility = Visibility.Visible;
                addGrid.Visibility = Visibility.Collapsed;
                showGrid.Visibility = Visibility.Collapsed;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR. \n" + ex.Message);
            }
        }
        private void TextBlock_PreviewMouseDown_3(object sender, MouseButtonEventArgs e)
        {
            helpGrid.Visibility = Visibility.Collapsed;
            findGrid.Visibility = Visibility.Collapsed;
            addGrid.Visibility = Visibility.Collapsed;
            showGrid.Visibility = Visibility.Visible;
        }

        private void ListViewItem_Selected_3(object sender, RoutedEventArgs e)
        {
            helpGrid.Visibility = Visibility.Collapsed;
            findGrid.Visibility = Visibility.Collapsed;
            addGrid.Visibility = Visibility.Collapsed;
            showGrid.Visibility = Visibility.Visible;
        }

        private void buttonLogOut_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void deleteTester_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bl.deleteTrainee(trainee);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR. \n" + ex.Message);
            }
        }

        private void ListViewItem_Selected_4(object sender, RoutedEventArgs e)
        {
            helpGrid.Visibility = Visibility.Collapsed;
            this.Visibility = Visibility.Collapsed;
            new testAddr(trainee).ShowDialog();
        }

        private void TextBlock_PreviewMouseDown_4(object sender, MouseButtonEventArgs e)
        {
            helpGrid.Visibility = Visibility.Collapsed;
            this.Visibility = Visibility.Collapsed;
            new testAddr(trainee).ShowDialog();
        }
        
        private void Help_Click(object sender, RoutedEventArgs e)
        {
            helpGrid.Visibility = Visibility.Visible;
            findGrid.Visibility = Visibility.Collapsed;
            addGrid.Visibility = Visibility.Collapsed;
            showGrid.Visibility = Visibility.Collapsed;
        }

        private void ListViewItem_Selected_5(object sender, RoutedEventArgs e)
        {
            BE.Test test = bl.findTest(trainee.myTestId);
            if (test.score)
            {
                this.Visibility = Visibility.Collapsed;
                new traineePass(trainee).ShowDialog();
            }
            else
            {
                this.Visibility = Visibility.Collapsed;
                new traineeNotPass(trainee).ShowDialog();
            }
        }

        private void TextBlock_PreviewMouseDown_5(object sender, MouseButtonEventArgs e)
        {
            BE.Test test = bl.findTest(trainee.myTestId);
            if (test.score)
            {
                this.Visibility = Visibility.Collapsed;
                new traineePass(trainee).ShowDialog();
            }
            else
            {
                this.Visibility = Visibility.Collapsed;
                new traineeNotPass(trainee).ShowDialog();
            }
        }
    }
}
