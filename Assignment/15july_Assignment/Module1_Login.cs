using System;

// ==================================================================
// Module 1: User Login
// ==================================================================
static class Module1_Login
{
    public static void Run()
    {
        Console.Write("Enter Employee Name: ");
        string employeeName = Console.ReadLine();

        Console.Write("Enter Employee ID: ");
        string employeeId = Console.ReadLine();

        Console.WriteLine("Welcome " + employeeName);
    }
}
