using System;

// ==================================================================
// StationeryItem is the PARENT class for Notebook, Pen and Marker.
// It inherits from Product, so it must provide CalculateDiscount()
// (even if here it just returns a default value of 0).
// ==================================================================
class StationeryItem : Product
{
    // ---------------- ENCAPSULATION ----------------
    // Fields are "private" so nobody outside this class can touch
    // them directly. The only way in/out is through the public
    // properties below, which can validate the value first.
    private int itemId;
    private string itemName;
    private string category;
    private double price;
    private int quantity;
    private string brand;

    public int ItemId
    {
        get { return itemId; }
        set { itemId = value; }
    }

    public string ItemName
    {
        get { return itemName; }
        set { itemName = value; }
    }

    public string Category
    {
        get { return category; }
        set { category = value; }
    }

    public string Brand
    {
        get { return brand; }
        set { brand = value; }
    }

    public double Price
    {
        get { return price; }
        set
        {
            if (value <= 0)
                throw new InvalidPriceException("Price must be greater than 0.");
            price = value;
        }
    }

    public int Quantity
    {
        get { return quantity; }
        set
        {
            if (value < 0)
                throw new InvalidQuantityException("Quantity cannot be negative.");
            quantity = value;
        }
    }

    // ---------------- POLYMORPHISM ----------------
    // "virtual" means child classes (Notebook, Pen, Marker) are
    // allowed to replace this method with their own version.
    public virtual void DisplayDetails()
    {
        Console.WriteLine(
            ItemId + "\t" + ItemName + "\t" + Category + "\t" +
            Brand + "\t" + Price.ToString("0.00") + "\t" + Quantity);
    }

    // Goes through the Quantity property above, so the validation
    // (no negative numbers) still runs.
    public void UpdateQuantity(int newQuantity)
    {
        Quantity = newQuantity;
    }

    // ---------------- ABSTRACTION ----------------
    // Default discount for a plain StationeryItem. Notebook, Pen and
    // Marker each override this with their own percentage.
    public override double CalculateDiscount()
    {
        return 0;
    }
}
