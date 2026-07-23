using System;

public class PartTimeStudent : Student
{
    // part-time students pay 75% of the regular per-credit rate,
    // plus a flat administrative charge
    public const double PartTimeRateFactor = 0.75;
    public const double AdminFee = 500;

    public PartTimeStudent(int id, string name, string department)
        : base(id, name, department)
    {
    }

    public override double CalculateFee()
    {
        return (TotalCredits() * RatePerCredit * PartTimeRateFactor) + AdminFee;
    }

    public override string StudentType()
    {
        return "Part-Time";
    }
}