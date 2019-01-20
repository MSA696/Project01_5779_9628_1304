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
        BL.IBL bl;
        public traineeShow()
        {
            InitializeComponent();
            trainee = new BE.Trainee();
            this.addGrid.DataContext = trainee;
            this.showGrid.DataContext = trainee;
            bl = BL.factoryBL.BLGetInstance();
        }
        public traineeShow(BE.Trainee t )
        {
            InitializeComponent();
            trainee = t;
            this.addGrid.DataContext = trainee;
            this.showGrid.DataContext = trainee;
            bl = BL.factoryBL.BLGetInstance();
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
            addGrid.Visibility = Visibility.Visible;
        }
        private void ListViewItem_Selected_1(object sender, RoutedEventArgs e)
        {
            showGrid.Visibility = Visibility.Collapsed;
            addGrid.Visibility = Visibility.Visible;
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
            addGrid.Visibility = Visibility.Collapsed;
            showGrid.Visibility = Visibility.Visible;
        }

        private void ListViewItem_Selected_3(object sender, RoutedEventArgs e)
        {
            addGrid.Visibility = Visibility.Collapsed;
            showGrid.Visibility = Visibility.Visible;
        }

    }
}
