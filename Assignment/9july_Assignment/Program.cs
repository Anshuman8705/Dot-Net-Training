using System;
using System.Collections.Generic;
public class Program
{
    public static void Main(string[] args)
    {
        //Task 1: Create List<Employee> and add employees
        List<Employee> employees = new List<Employee>
        {
            new PermanentEmployee(101, "Amit Sharma", "IT"),
            new PermanentEmployee(102, "Priya Verma", "HR"),
            new ContractEmployee(103, "Rahul Deshmukh", "Finance"),
            new ContractEmployee(104, "Sneha Kulkarni", "Marketing"),
            new PermanentEmployee(105, "Anshuman Agrawal", "IT")
        };

        //Task 2: Display all employee details using foreach
        Console.WriteLine("Task 2: All Employee Details");
        foreach (Employee emp in employees)
        {
            emp.DisplayDetails();
        }

        //Task 3: Create List<LeaveRequest>
        List<LeaveRequest> leaveRequests = new List<LeaveRequest>
        {
            new LeaveRequest(1, 101, 3, "Medical"),
            new LeaveRequest(2, 102, 2, "Personal Work"),
            new LeaveRequest(3, 103, 5, "Family Function"),
            new LeaveRequest(4, 105, 1, "Sick Leave")
        };

        //Task 4: Display all leave requests
        Console.WriteLine("\nTask 4: All Leave Requests");
        foreach (LeaveRequest lr in leaveRequests)
        {
            lr.DisplayLeave();
        }

        //Task 5: Display only Permanent Employees
        Console.WriteLine("\nTask 5: Permanent Employees Only");
        foreach (Employee emp in employees)
        {
            if (emp is PermanentEmployee)
            {
                emp.DisplayDetails();
            }
        }

        //Task 6: Find employee with EmployeeId = 103
        Console.WriteLine("\nTask 6: Employee with Id 103");
        Employee? foundEmployee = employees.Find(e => e.EmployeeId == 103);
        if (foundEmployee != null)
        {
            foundEmployee.DisplayDetails();
        }
        else
        {
            Console.WriteLine("Employee not found.");
        }

        //Task 7: Total number of employees
        Console.WriteLine("\nTask 7: Total Employees");
        Console.WriteLine($"Total Employees: {employees.Count}");

        //Task 8: Total number of leave requests
        Console.WriteLine("\nTask 8: Total Leave Requests");
        Console.WriteLine($"Total Leave Requests: {leaveRequests.Count}");

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}