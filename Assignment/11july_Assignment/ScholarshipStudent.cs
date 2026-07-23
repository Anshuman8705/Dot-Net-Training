using System;

public class ScholarshipStudent : Student
{
    // scholarship students get a 50% waiver on fees
    public const double ScholarshipDiscount = 0.5;

    public ScholarshipStudent(int id, string name, string department)
        : base(id, name, department)
    {
    }

    public override double CalculateFee()
    {
        return TotalCredits() * RatePerCredit * (1 - ScholarshipDiscount);
    }

    public override string StudentType()
    {
        return "Scholarship";
    }
}