// encapsulation is the process of hiding the internal details of an object and exposing only the necessary information to the outside world. It is achieved by using access modifiers (like private, public) to restrict access to the internal state of an object and providing public methods or properties to interact with that state.

using System;
class Employee
{
    private string empName;
    private double salary;
    public string EmpName
    {
        get { return empName; }
        set
        {
            empName = value;
        }
    }
    public double Salary
    {
        get { return salary; }
        set
        {
            if (value >= 100)
            salary = value;
        }
    }
}