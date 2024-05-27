using System;
using System.Collections.Generic;
using System.Text;

namespace FINALPOE
{
    public class HomeLoanInstallment : Expense
    {

        public int months;
        public double PropetyPrice, TotDeposit, IntRate;

        // constructor
        public HomeLoanInstallment(double propety, double Deposit, double interest, int Months)
        {
            PropetyPrice = propety;
            TotDeposit = Deposit;
            IntRate = interest;
            months = Months;
        }
        public override double Intake()
        {
            double principl = PropetyPrice - TotDeposit;
            IntRate = IntRate / (12 * 100);

            double accum = (principl * IntRate * (double)Math.Pow(1 + IntRate, months))
            / (double)(Math.Pow(1 + IntRate, months) - 1);

            return accum;
        }
    }
}
