using System;

namespace Personal_Finance_Tracker
{
    class Program
    {
        static void Main(string[] args)
        {
            FinanceManager financeManager = new FinanceManager();
            int choice;

            do
            {
                Console.Clear();
                Console.WriteLine("Personal Finance Tracker");
                Console.WriteLine("1. Add Expense");
                Console.WriteLine("2. Set Budget");
                Console.WriteLine("3. View Financial Report");
                Console.WriteLine("4. Set Savings Goal");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            financeManager.AddExpense();
                            break;
                        case 2:
                            financeManager.SetBudget();
                            break;
                        case 3:
                            financeManager.ViewFinancialReport();
                            break;
                        case 4:
                            financeManager.SetSavingsGoal();
                            break;
                        case 5:
                            Console.WriteLine("Exiting...");
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }

                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            } while (choice != 5);
        }
    }
}
