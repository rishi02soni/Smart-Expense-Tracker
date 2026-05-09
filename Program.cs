using System;

namespace SmartExpenseTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            ExpenseManager manager = new ExpenseManager();
            manager.LoadData();

            while (true)
            {
                Console.WriteLine("\n==== SMART EXPENSE TRACKER ====");
                Console.WriteLine("1. Add Expense");
                Console.WriteLine("2. View Expenses");
                Console.WriteLine("3. Search Category");
                Console.WriteLine("4. Monthly Report");
                Console.WriteLine("5. Save Data");
                Console.WriteLine("6. Exit");

                Console.Write("Choose Option: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        manager.AddExpense();
                        break;
                    case 2:
                        manager.ViewExpenses();
                        break;
                    case 3:
                        manager.SearchByCategory();
                        break;
                    case 4:
                        manager.MonthlyReport();
                        break;
                    case 5:
                        manager.SaveData();
                        break;
                    case 6:
                        manager.SaveData();
                        return;
                }
            }
        }
    }
}
