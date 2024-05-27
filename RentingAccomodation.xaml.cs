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
    /// Interaction logic for RentingAccomodation.xaml
    /// </summary>
    public partial class RentingAccomodation : Window
    {
        public RentingAccomodation()
        {
            InitializeComponent();
        }

        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {
            Double rentalamount = 0;
            int months = 0;
            double det = 0;
            

            det = rentalamount * (months / 12);


            MessageBox.Show("Your rental amount for"+RentalAmount.Text+"Months is eqaul to"+det);


                    }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
