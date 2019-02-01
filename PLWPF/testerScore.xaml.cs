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
    /// Interaction logic for testerScore.xaml
    /// </summary>
    public partial class testerScore : Window
    {
        BE.Test test;
        BL.IBL bl;
        public testerScore()
        {
            try
            {
                InitializeComponent();
                test = new BE.Test();
                bl = BL.factoryBL.BLGetInstance();
                test = bl.getTestsToCheck();
                this.DataContext = test;
                string traineeNameStr = bl.findTrainee(test.traineeId).firstName;
                this.traineeName.Content = traineeNameStr;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR. \n" + ex.Message);
            }
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                test.check = true;
                if (bl.testPass(test))
                    test.score = true;
                bl.updateTest(test);
                if (bl.boolGetTestsToCheck())
                {
                    test = bl.getTestsToCheck();
                    this.score.DataContext = test;
                    string traineeNameStr = bl.findTrainee(test.traineeId).firstName;
                    this.traineeName.Content = traineeNameStr;
                }
                else
                    MessageBox.Show("Ther is no more test to check.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR. \n" + ex.Message);
            }
        }
    }
}
