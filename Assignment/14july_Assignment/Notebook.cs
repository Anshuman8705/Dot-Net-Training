using System;

// ==================================================================
// INHERITANCE: Notebook gets ItemId, ItemName, Price, Quantity, etc.
// from StationeryItem for free, and just adds its own extra details.
// ==================================================================
class Notebook : StationeryItem
{
    public int Pages { get; set; }
    public string PaperType { get; set; }

    // POLYMORPHISM: this replaces the parent's DisplayDetails().
    public override void DisplayDetails()
    {
        base.DisplayDetails(); // still print the common details first
        Console.WriteLine("   Pages: " + Pages + ", Paper Type: " + PaperType);
    }

    // ABSTRACTION: Notebook's own discount rule = 10%
    public override double CalculateDiscount()
    {
        return Price * 0.10;
    }
}
