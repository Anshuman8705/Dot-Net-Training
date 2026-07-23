using System;
using System.Collections.Generic;
public class ContractEmployee : Employee
{
    public ContractEmployee(int employeeId, string name, string department)
        : base(employeeId, name, department) { }

    public override void SetLeaveBalance()
    {
        LeaveBalance = 12;
    }
}