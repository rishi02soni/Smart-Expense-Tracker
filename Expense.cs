using System;

namespace SmartExpenseTracker
{
    class Expense
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }

        public Expense(int id, string title, string category, double amount, DateTime date)
        {
            Id = id;
            Title = title;
            Category = category;
            Amount = amount;
            Date = date;
        }

        public override string ToString()
        {
            return $"{Id} | {Title} | {Category} | ₹{Amount} | {Date.ToShortDateString()}";
        }
    }
}
