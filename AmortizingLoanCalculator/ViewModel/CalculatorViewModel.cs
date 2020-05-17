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
                    mCalculator = new CalculateCommand(calculateParams.CalculateInterest, calculateParams.ValidateForm);
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
            Func<object, bool> _canExecuteMethod;

            public CalculateCommand(Action<object> execteMethod, Func<object, bool> canexecuteMethod)
            {
                _executeMethod = execteMethod;
                _canExecuteMethod = canexecuteMethod;
            }

            public bool CanExecute(object parameter)
            {
                if (_canExecuteMethod != null)
                {
                    return _canExecuteMethod(parameter);
                }
                else
                {
                    return false;
                }
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
