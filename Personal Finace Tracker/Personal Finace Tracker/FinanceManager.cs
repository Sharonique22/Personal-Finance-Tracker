using System;
using System.Collections.Generic;

namespace Personal_Finance_Tracker
{
    class FinanceManager
    {
        private List<Expense> expenses;
        private Budget budget;
        private SavingsGoal savingsGoal;

        public FinanceManager()
        {
            expenses = new List<Expense>();
            budget = null;
            savingsGoal = null;
        }

        public void AddExpense()
        {
            Console.Write("Enter expense amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());
            if (amount > 0)
            {
                Console.Write("Enter expense category: ");
                string category = Console.ReadLine();
                Expense newExpense = new Expense { Amount = amount, Category = category };
                expenses.Add(newExpense);
                Console.WriteLine("Expense added successfully.");
            }
            else
            {
                Console.WriteLine("Invalid amount. Please enter a valid number greater than zero.");
            }
        }

        public void SetBudget()
        {
            Console.Write("Enter your budget amount: ");
            double amount;
            if (double.TryParse(Console.ReadLine(), out amount) && amount > 0)
            {
                budget = new Budget(amount);
                Console.WriteLine("Budget set successfully.");
            }
            else
            {
                Console.WriteLine("Invalid amount. Please enter a valid number greater than zero.");
            }
        }

        public void ViewFinancialReport()
        {
            if (budget == null)
            {
                Console.WriteLine("Budget not set. Please set a budget first.");
                return;
            }

            FinancialReport report = new FinancialReport(expenses, budget);
            report.GenerateReport();
        }

        public void SetSavingsGoal()
        {
            Console.Write("Enter your savings goal: ");
            double goal;
            if (double.TryParse(Console.ReadLine(), out goal) && goal > 0)
            {
                savingsGoal = new SavingsGoal(goal);
                Console.WriteLine("Savings goal set successfully.");

                double totalSavings = budget != null ? budget.Amount - CalculateTotalExpenses() : 0;
                Console.WriteLine("Current savings goal: " + savingsGoal.GoalAmount.ToString("C"));
                Console.WriteLine("Amount left to save: " + (savingsGoal.GoalAmount - totalSavings).ToString("C"));
            }
            else
            {
                Console.WriteLine("Invalid goal amount. Please enter a valid number greater than zero.");
            }
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
