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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FINALPOE
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            
        }

       

        // monthly salary of user 
        public double Gross;

        // TAX CALCULATED BEFORE DEDUCTION 
        public double Estimated_Monthly_tax;

        // TOTAL AM
        public double grocerie;
        public double water_Lights;
        public double travel;
        public double Cellphone_Telephone;
        public double other;

        public object LengthText { get; private set; }

        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {

            


            if (BuyProperty.IsChecked.Value)
            {
                PurchasingProperty Buy = new PurchasingProperty();
                Buy.ShowDialog();



            }
            else
                  if (RentAccomodation.IsChecked.Value)
            {

                RentingAccomodation hello = new RentingAccomodation();
                hello.ShowDialog();

            }
            else
                if (BuyVehicle.IsChecked.Value)
            {
                VehiclePurchase vehicle = new VehiclePurchase();
                vehicle.ShowDialog();


            }
            else
                if (SaveUp.IsChecked.Value) {

                SaveUp save = new SaveUp();
                save.ShowDialog();
        
            }





            MonthlyIncome.Text = Gross.ToString();
            Groceries.Text = grocerie.ToString();
            MonthlyTaxDeducted.Text = Estimated_Monthly_tax.ToString();
            WaterandLights.Text = water_Lights.ToString();
            TelephoneandCellphone.Text = Cellphone_Telephone.ToString();
            TravelCost.Text = travel.ToString();
            OtherExpenses.Text = other.ToString();


            MessageBox.Show("Thank You for applying");
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            //Resetting
            this.BuyProperty.IsChecked = this.RentAccomodation.IsChecked = this.BuyVehicle.IsChecked = this.SaveUp.IsChecked;  
        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            MonthlyIncome.Clear();
            Groceries.Clear();
            MonthlyTaxDeducted.Clear();
            WaterandLights.Clear();
            TelephoneandCellphone.Clear();
            TravelCost.Clear();
            OtherExpenses.Clear();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            this.LengthText+= (string)((CheckBox)sender).Content;
        }
    }
}
