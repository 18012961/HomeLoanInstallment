using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FINALPOE
{
    /// <summary>
    /// Interaction logic for VehiclePurchase.xaml
    /// </summary>
    public partial class VehiclePurchase : Window
    {
        public VehiclePurchase()
        {
            InitializeComponent();
        }

        public string make_mode;
        public double purchasePrice, totalDep, InttRate, premiumAmount;
        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {


            double qualification = 0;

            qualification = purchasePrice + totalDep + InttRate + premiumAmount;

            MainWindow cal = new MainWindow();



            if (qualification < cal.Gross)
            {

                MessageBox.Show("You do not qualify for a vehicle");


            }
            else
                if (qualification > cal.Gross) {

                MessageBox.Show("Congradulations you qualify for a vehicle.");

            }


            
        }

        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
