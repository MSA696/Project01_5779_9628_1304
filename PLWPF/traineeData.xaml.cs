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
    /// Interaction logic for traineeData.xaml
    /// </summary>
    public partial class traineeData : Window
    {
        BE.Trainee trainee;
        BL.IBL bl;
        public traineeData()
        {
            InitializeComponent();
            trainee = new BE.Trainee();
            this.addGrid.DataContext = trainee;
            bl = BL.factoryBL.BLGetInstance();
            
            this.comboBoxGender.ItemsSource = Enum.GetValues(typeof(BE._gender));
            this.comboBoxCarType.ItemsSource = Enum.GetValues(typeof(BE.car_Type));
            this.comboBoxGearType.ItemsSource = Enum.GetValues(typeof(BE.gear_Box));
            this.comboBoxTestHour.ItemsSource = Enum.GetValues(typeof(BE.hours));
            
        }

        private void addTrainee_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                BE.Test myTest = new BE.Test();
                
                trainee.addr.city = this.cityAddressBox.Text;
                trainee.addr.street = this.streetAddressBox.Text;
                trainee.addr.building = int.Parse(this.numAddressBox.Text);

                
                int tmp = (int)trainee.testDate.DayOfWeek;
                trainee.testDay = (BE.days)(tmp + 1);

                trainee.testDate = (DateTime)(this.dateTestPicker.SelectedDate);
                trainee.testHour = (BE.hours)(this.comboBoxTestHour.SelectedItem);
                trainee.myTestId = BE.Configuration.firstNum;

                myTest.testDay = trainee.testDay;
                myTest.testHour = trainee.testHour;
                myTest.testDate = trainee.testDate;
                myTest.traineeId = trainee.id;

                if (this.datePicker.SelectedDate > DateTime.Now.AddYears(-18)) throw new Exception("You must be over 18.");
                if (this.dateTestPicker.SelectedDate < DateTime.Now) throw new Exception("Your test day must be from today.");
                if (int.Parse(this.phoneBox.Text) < 0500000000 || int.Parse(this.phoneBox.Text) > 0599999999) throw new Exception("Phone number is not valid.");
                if (int.Parse(this.maxDisBox.Text) < 0) throw new Exception("Distance must be over 0.");
                if ((int)trainee.testDay > 4) throw new Exception("This is not work day.");
                Regex reg = new Regex(@"^[0-9]*$");
                if (!reg.IsMatch(this.numAddressBox.Text)) throw new Exception("Invalid building number.");
                trainee.addr.building = Convert.ToInt32(this.numAddressBox.Text);
                reg = new Regex(@"^\d{9}$");
                if (!reg.IsMatch(this.idBox.Text)) throw new Exception("Invalid ID.");
                if (int.Parse(classNumBox.Text) < 28) throw new Exception("Less then 28 class.");

                
                bl.addTrainee(trainee);
                bl.addTest(myTest);
                this.Visibility = Visibility.Collapsed;
                new traineeShow(trainee).ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR. \n" + ex.Message);
            }

        }

        private void buttonLogOut_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void contact_Click(object sender, RoutedEventArgs e)
        {
            addGrid.Visibility = Visibility.Collapsed;
            helpGrid.Visibility = Visibility.Visible;
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            addGrid.Visibility = Visibility.Visible;
            helpGrid.Visibility = Visibility.Collapsed;
        }
    }
}
