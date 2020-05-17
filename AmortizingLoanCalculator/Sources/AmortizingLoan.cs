using System;
using System.Windows;

namespace AmortizingLoanCalculator.Sources
{
    class AmortizingLoan
    {
        public static double RemainingInterestSum(double initialPrincipal, double annualRate, int durationYears, DateTime calculationDate, DateTime agreementDate)
        {
            int duration = durationYears * 12;
            double monthlyRate = annualRate / 100 / 12;
            int dateDiff = ((calculationDate.Year - agreementDate.Year) * 12) + calculationDate.Month - agreementDate.Month - (calculationDate.Day < agreementDate.Day ? 1:0);
            double monthlyPayment = MonthlyPayment(initialPrincipal, monthlyRate, duration);

            double interest;
            double principal;
            double remainingInterest = 0;
            for(int i = 0; i < duration; i++)
            {
                interest = initialPrincipal * monthlyRate;
                principal = monthlyPayment - interest;
                initialPrincipal -= principal;
                if(dateDiff > 0)
                {
                    dateDiff--;
                }
                else
                {
                    remainingInterest += interest;
                }
            }

            remainingInterest = Math.Ceiling(remainingInterest * 100) / 100;
            return remainingInterest;

        }

        private static double MonthlyPayment(double initialPrincipal, double monthlyRate, int duration)
        {
            return initialPrincipal * (monthlyRate * Math.Pow(1 + monthlyRate, duration) / (Math.Pow(1 + monthlyRate, duration) - 1));
        }
    }
}
