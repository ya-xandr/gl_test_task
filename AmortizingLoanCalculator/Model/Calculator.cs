using System;
using System.ComponentModel;
using System.Windows;
using AmortizingLoanCalculator.Sources;

namespace AmortizingLoanCalculator.Model
{
    class Calculator : INotifyPropertyChanged
    {
        private double initialPrincipal;
        private double annualRate;
        private int investmentDuration;
        private DateTime calculationDate;
        private DateTime agreementDate;
        private double remainingInterestPayments;

        public double InitialPrincipal
        {
            get
            {
                return initialPrincipal;
            }
            set
            {
                initialPrincipal = value;
                OnPropertyChanged("InitialPrincipal");
            }
        }

        public double AnnualRate
        {
            get
            {
                return annualRate;
            }
            set
            {
                annualRate = value;
                OnPropertyChanged("AnnualRate");
            }
        }

        public int InvestmentDuration
        {
            get
            {
                return investmentDuration;
            }
            set
            {
                investmentDuration = value;
                OnPropertyChanged("InvestmentDuration");
            }
        }

        public DateTime CalculationDate
        {
            get
            {
                return calculationDate;
            }
            set
            {
                calculationDate = value;
                OnPropertyChanged("CalculationDate");
            }
        }

        public DateTime AgreementDate
        {
            get
            {
                return agreementDate;
            }
            set
            {
                agreementDate = value;
                OnPropertyChanged("AgreementDate");
            }
        }

        public double RemainingInterestPayments
        {
            get {
                return remainingInterestPayments;
            }
            set
            {
                remainingInterestPayments = value;
                OnPropertyChanged("RemainingInterestPayments");
            }
        }

        public void CalculateInterest(object parameter)
        {
            RemainingInterestPayments = AmortizingLoan.RemainingInterestSum(InitialPrincipal, AnnualRate, InvestmentDuration, CalculationDate, AgreementDate);
        }

        public bool ValidateForm(object parameter)
        {
            return true;
        }

        #region INotifyPropertyChanged Members  

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
