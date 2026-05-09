using System;
using System.Collections.Generic;
using System.IO;

namespace SmartExpenseTracker
{
    class FileManager
    {
        static string path = "expenses.txt";

        public static void Save(List<Expense> expenses)
        {
            StreamWriter sw = new StreamWriter(path);

            foreach (var e in expenses)
            {
                sw.WriteLine($"{e.Id},{e.Title},{e.Category},{e.Amount},{e.Date}");
            }

            sw.Close();
            Console.WriteLine("Saved Successfully!");
        }

        public static List<Expense> Load()
        {
            List<Expense> list = new List<Expense>();

            if (!File.Exists(path))
                return list;

            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
            {
                string[] d = line.Split(',');

                list.Add(new Expense(
                    Convert.ToInt32(d[0]),
                    d[1],
                    d[2],
                    Convert.ToDouble(d[3]),
                    Convert.ToDateTime(d[4])
                ));
            }

            return list;
        }
    }
}
