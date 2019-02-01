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
    /// Interaction logic for testAddr.xaml
    /// </summary>
    public partial class testAddr : Window
    {
        BE.Test myTest;
        BE.Trainee trainee;
        BL.IBL bl;
        public testAddr()
        {
            InitializeComponent();
        }
        public testAddr(BE.Trainee t)
        {
            bl = BL.factoryBL.BLGetInstance();
            myTest = bl.findTest(t.myTestId);
            trainee = t;
            InitializeComponent();
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            myTest.beginOfTestAdr.city = this.cityBox.Text;
            myTest.beginOfTestAdr.street = this.streetBox.Text;
            myTest.beginOfTestAdr.building = Convert.ToInt32(buildingNumBox.Text);
            bl.updateTest(myTest);
            this.Visibility = Visibility.Collapsed;
            new traineeShow(trainee).ShowDialog();
        }
    }
}
