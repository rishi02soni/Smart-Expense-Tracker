#  Smart Expense Tracker 

A powerful and beginner-friendly **Expense Management System** built using **C# and .NET**.  
This project helps users manage daily expenses, track spending habits, search expenses by category, generate monthly reports, and save records permanently using file handling.

---

#  Features
```
- Add New Expense  
- View All Expenses  
- Search Expense by Category  
- Monthly Expense Report  
- Save Data to File  
- Auto Load Previous Data  
- OOP Concepts Used  
- LINQ Queries Implemented  
- Real-World Console Project  
```
---

#  Technologies Used
```
- C#
- .NET 8.0
- Console Application
- File Handling
- LINQ
- Object Oriented Programming
```
---

#  Project Structure

```
SmartExpenseTracker/
│── Program.cs
│── Expense.cs
│── ExpenseManager.cs
│── FileManager.cs
│── SmartExpenseTracker.csproj
│── expenses.txt   (Auto Generated)
```
---
##  How It Works

> The system allows users to:
```
- Add daily expenses  
- Store title, category, amount, and date  
- View all records  
- Search expenses like Food, Travel, Shopping, Bills etc.  
- Generate monthly total expense report  
- Save all data in text file  
- Load previous saved data automatically  
```
---

##  Installation & Run

>  Clone Repository

```
git clone https://github.com/yourusername/SmartExpenseTracker.git
cd SmartExpenseTracker
```

>  Run Project

```
dotnet run
```

---

##  Menu Interface

```
==== SMART EXPENSE TRACKER ====

1. Add Expense
2. View Expenses
3. Search Category
4. Monthly Report
5. Save Data
6. Exit
```

---

##  Example Output

```
Choose Option: 1

Title: Pizza
Category: Food
Amount: 350

Expense Added!
```

```
Choose Option: 2

1 | Pizza | Food | ₹350 | 09/05/2026
2 | Petrol | Travel | ₹500 | 09/05/2026
```

```
Choose Option: 4

Month 5 : ₹850
```

---

##  OOP Concepts Used

###  Encapsulation

Data stored using properties inside `Expense.cs`

###  Classes & Objects

- Expense  
- ExpenseManager  
- FileManager  

###  Constructors

Used for initializing expense objects.

###  Abstraction

Manager handles complete business logic.

---

##  LINQ Used

```
expenses.Where(...)
expenses.GroupBy(...)
expenses.Sum(...)
expenses.Max(...)
```

---

##  File Handling Used

Data stored in:

```txt
expenses.txt
```

Auto loads every time project starts.

---

##  Why This Project?

This project is excellent for:

- Beginners learning C#  
- College Mini Projects  
- Resume Projects  
- OOP Practice  
- File Handling Practice  
- Real World Logic Building  

---

##  Future Improvements
```
- SQL Database Integration  
- ASP.NET Web Version  
- Login Authentication  
- Expense Charts  
- Export PDF Reports  
- Mobile App Version  
```
---

##  Contributing

Anyone can improve this project by adding:

- Better UI  
- Database  
- Authentication  
- Reports  

---

##  License

Free to use for learning and personal projects.

---

##  Developer

Made with  using C# and .NET

---

##  Support

If you like this project:
```
-  Star the repository  
-  Fork it  
-  Share with friends  
```
---

##  Final Note

This project demonstrates real-world coding skills like:
```
✔ Logic Building  
✔ OOP  
✔ LINQ  
✔ File Handling  
✔ Clean Code Structure  
```
Perfect for internships and placements.
