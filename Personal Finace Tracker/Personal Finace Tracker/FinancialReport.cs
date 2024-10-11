using System;
using System.Collections.Generic;

namespace Personal_Finance_Tracker
{
    class FinancialReport
    {
        private List<Expense> expenses;
        private Budget budget;

        public FinancialReport(List<Expense> expenses, Budget budget)
        {
            this.expenses = expenses;
            this.budget = budget;
        }

        public void GenerateReport()
        {
            double totalExpenses = CalculateTotalExpenses();

            Console.WriteLine("Financial Report:");
            for (int i = 0; i < expenses.Count; i++)
            {
                Console.WriteLine("Expense: " + expenses[i].Category + ", Amount: " + expenses[i].Amount.ToString("C"));
            }

            Console.WriteLine("Total Expenses: " + totalExpenses.ToString("C"));
            Console.WriteLine("Budget: " + budget.Amount.ToString("C"));
            Console.WriteLine("Remaining Budget: " + (budget.Amount - totalExpenses).ToString("C"));
        }

        private double CalculateTotalExpenses()
        {
            double total = 0;
            for (int i = 0; i < expenses.Count; i++)
            {
                total += expenses[i].Amount;
            }
            return total;
        }
    }
}
