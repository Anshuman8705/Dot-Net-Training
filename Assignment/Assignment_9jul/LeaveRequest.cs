using System;
using System.Collections.Generic;

public class LeaveRequest
{
    public int LeaveId { get; set; }
    public int EmployeeId { get; set; }
    public int NumberOfDays { get; set; }
    public string Reason { get; set; }

    public LeaveRequest(int leaveId, int employeeId, int numberOfDays, string reason)
    {
        LeaveId = leaveId;
        EmployeeId = employeeId;
        NumberOfDays = numberOfDays;
        Reason = reason;
    }

    public void DisplayLeave()
    {
        Console.WriteLine($"LeaveId: {LeaveId} | EmployeeId: {EmployeeId} | " +
                           $"Days: {NumberOfDays} | Reason: {Reason}");
    }
}