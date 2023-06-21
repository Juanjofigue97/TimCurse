using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestIsInteresting
{
    public static class SavingsAccount
    {
        public static float InterestRate(decimal balance)
        {
            var interestRate = balance switch
            {
                < 0 => 3.213f,
                < 1000 => 0.5f,
                < 5000 => 1.621f,
                >= 5000 => 2.475f,
            };

            return interestRate;
        }

        public static decimal Interest(decimal balance)
        {
            return balance * (decimal)InterestRate(balance) / 100;
        }

        public static decimal AnnualBalanceUpdate(decimal balance)
        {
            return Interest(balance) + balance;
        }

        public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
        {
            int years = 1;
            decimal TotalBalance = AnnualBalanceUpdate(balance);
            do
            {
                TotalBalance += Interest(TotalBalance);
                years++;

            } while (TotalBalance < targetBalance);
            return years;
        }
    }
}
