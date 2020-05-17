using System;
using System.Windows.Input;

namespace AmortizingLoanCalculator.ViewModel
{
    class CalculatorViewModel
    {
        private Model.Calculator calculateParams;

        public CalculatorViewModel()
        {
            calculateParams = new Model.Calculator {InitialPrincipal = 0.0, AnnualRate = 0.0, CalculationDate = DateTime.Now, AgreementDate = DateTime.Now, InvestmentDuration = 0 };
        }

        public Model.Calculator CalculateParams
        {
            get { return calculateParams; }
            set { calculateParams = value; }
        }

        private ICommand mCalculator;
        public ICommand CalculateEvent
        {
            get
            {
                if (mCalculator == null)
                    mCalculator = new CalculateCommand(calculateParams.CalculateInterest);
                return mCalculator;
            }
            set
            {
                mCalculator = value;
            }
        }

        private class CalculateCommand: ICommand
        {
            #region ICommand Members  

            Action<object> _executeMethod;

            public CalculateCommand(Action<object> execteMethod)
            {
                _executeMethod = execteMethod;
            }

            public bool CanExecute(object parameter)
            {
                return true;
            }

            public event EventHandler CanExecuteChanged {
                add
                {
                    CommandManager.RequerySuggested += value;
                }
                remove
                {
                    CommandManager.RequerySuggested -= value;
                }
            }

            public void Execute(object parameter)
            {
                _executeMethod(parameter);
            }

            #endregion
        }
    }
}
