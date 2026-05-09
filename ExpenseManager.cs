using System;
using System.Collections.Generic;
using System.Linq;

namespace SmartExpenseTracker
{
    class ExpenseManager
    {
        private List<Expense> expenses = new List<Expense>();
        private int nextId = 1;

        public void AddExpense()
        {
            Console.Write("Title: ");
            string title = Console.ReadLine();

            Console.Write("Category: ");
            string category = Console.ReadLine();

            Console.Write("Amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            expenses.Add(new Expense(nextId++, title, category, amount, DateTime.Now));

            Console.WriteLine("Expense Added!");
        }

        public void ViewExpenses()
        {
            foreach (var e in expenses)
                Console.WriteLine(e);
        }

        public void SearchByCategory()
        {
            Console.Write("Enter Category: ");
            string cat = Console.ReadLine();

            var result = expenses.Where(x => x.Category.ToLower() == cat.ToLower());

            foreach (var e in result)
                Console.WriteLine(e);
        }

        public void MonthlyReport()
        {
            var report = expenses.GroupBy(x => x.Date.Month)
                                 .Select(g => new
                                 {
                                     Month = g.Key,
                                     Total = g.Sum(x => x.Amount)
                                 });

            foreach (var item in report)
                Console.WriteLine($"Month {item.Month}: ₹{item.Total}");
        }

        public void SaveData()
        {
            FileManager.Save(expenses);
        }

        public void LoadData()
        {
            expenses = FileManager.Load();
            if (expenses.Count > 0)
                nextId = expenses.Max(x => x.Id) + 1;
        }
    }
}
