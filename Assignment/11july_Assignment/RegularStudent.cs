using System;

public class RegularStudent : Student
{
    public RegularStudent(int id, string name, string department)
        : base(id, name, department)
    {
    }
    public override double CalculateFee()
    {
        // regular students pay the full per-credit rate
        return TotalCredits() * RatePerCredit;
    }

    public override string StudentType()
    {
        return "Regular";
    }
}