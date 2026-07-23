using System;

class Marker : StationeryItem
{
    public bool Permanent { get; set; }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("   Permanent: " + Permanent);
    }

    // ABSTRACTION: Marker's own discount rule = 8%
    public override double CalculateDiscount()
    {
        return Price * 0.08;
    }
}
