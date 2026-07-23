using System;

class Pen : StationeryItem
{
    public string InkColor { get; set; }
    public string PenType { get; set; }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("   Ink Color: " + InkColor + ", Pen Type: " + PenType);
    }

    // ABSTRACTION: Pen's own discount rule = 5%
    public override double CalculateDiscount()
    {
        return Price * 0.05;
    }
}
