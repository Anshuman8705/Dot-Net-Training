using System;
using System.Collections.Generic;

public class PermanentEmployee : Employee
{
    public PermanentEmployee(int employeeId, string name, string department)
        : base(employeeId, name, department) { }

    public override void SetLeaveBalance()
    {
        LeaveBalance = 24;
    }
}