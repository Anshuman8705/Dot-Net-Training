using System;
using System.Collections.Generic;

public abstract class Employee
{
    public int EmployeeId { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public int LeaveBalance { get; set; }

    public Employee(int employeeId, string name, string department)
    {
        EmployeeId = employeeId;
        Name = name;
        Department = department;
        SetLeaveBalance(); // sets LeaveBalance based on employee type
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"ID: {EmployeeId} | Name: {Name} | Department: {Department} | " +
                           $"Type: {GetType().Name} | Leave Balance: {LeaveBalance} days");
    }

    public abstract void SetLeaveBalance(); // must be implemented by subclasses
}