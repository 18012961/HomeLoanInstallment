using System;
using System.Collections.Generic;
using System.Text;

namespace FINALPOE
{
    public class VehicleInstallment : Expense
    {

        string make_mode;
        double purchasePrice, totalDep, InttRate, premiumAmount;

        //constructor 
        public VehicleInstallment(string make_mode_, double homePrice_, double totalDep_, double InttRate_, double premiumAmount_)
        {
            make_mode = make_mode_;
            purchasePrice = homePrice_;
            totalDep = totalDep_;
            InttRate = InttRate_;
            premiumAmount = premiumAmount_;

        }
        public override double Intake()
        {
            double principl = purchasePrice - totalDep;
            InttRate = InttRate / (12 * 100);

            double accum = (principl * InttRate * (double)Math.Pow(1 + InttRate, 5))
            / (double)(Math.Pow(1 + InttRate, 5) - 1);

            return (accum + premiumAmount);

        }
    }
}
