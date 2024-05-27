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
    /// Interaction logic for PurchasingProperty.xaml
    /// </summary>
    public partial class PurchasingProperty : Window
    {
        public PurchasingProperty()
        {
            InitializeComponent();
        }
        public int months;
        public double PropetyPrice, TotDeposit, IntRate;

        private void ApplyButton1_Click(object sender, RoutedEventArgs e)
        {

            // MonthlyIncome.Text = Gross.ToString();

            Numberofmonths.Text = months.ToString();
            PriceofProperty.Text = PropetyPrice.ToString();
            TotalDeposit.Text = TotDeposit.ToString();
            Interest.Text = IntRate.ToString();



            MainWindow vel = new MainWindow();


            double totalQ = 0;

            totalQ = months + PropetyPrice + TotDeposit + IntRate;





            if (totalQ < vel.Gross)
            {
                MessageBox.Show("Sorry you do not qualify for a property purchase");



            }
            else {
                MessageBox.Show("Congradutions you qualify");
                MessageBox.Show("Number of months:" + months
                           + "\nPrice of property:" + PropetyPrice
                           + "\nTotal Deposit:" + TotDeposit
                           + "\nInterest Rate:" + IntRate);

            }
            
           

        }

        

        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {

            Numberofmonths.Clear();
            PriceofProperty.Clear();
            TotalDeposit.Clear();
            Interest.Clear();

        }
    }
}
