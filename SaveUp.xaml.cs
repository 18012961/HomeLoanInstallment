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
    /// Interaction logic for SaveUp.xaml
    /// </summary>
    public partial class SaveUp : Window
    {
        public SaveUp()
        {
            InitializeComponent();
        }

        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {
            double amounttosave = 0;
            int noOfMonths = 0;

            double total = amounttosave * noOfMonths * (12 / 100);
            double interestRate = 3.5;

            double Rate = 0;

            Rate = total + interestRate;


            MessageBox.Show("Welcome to our saving app"
                           +"The Total amount saved in the specified months which is: "
                           +Months.Text+"is"
                           +Rate
                           +"Including interest");


        }

        
        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
