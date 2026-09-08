using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTrackerLogic
{
    public class ExpenseCalculator
    {
        private decimal _runningTotal = 0.00m;

        public decimal RunningTotal => _runningTotal;

        public decimal AddExpense(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Expense amount must be greater than zero.");
            }

            _runningTotal += amount;
            return _runningTotal;
        }

        public void Reset()
        {
            _runningTotal = 0.00m;
        }

        public string FormatEntry(string category, string description, decimal amount)
        {
            return $"[{category}] {description} - RM {amount:F2}";
        }
    }
}