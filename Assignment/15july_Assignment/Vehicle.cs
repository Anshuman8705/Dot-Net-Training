using System;

// ==================================================================
// Vehicle
// Holds the details of one vehicle. This is the object we store
// inside the List<Vehicle> that Module 2 (Main Menu) owns.
// ==================================================================
class Vehicle
{
    public int VehicleId { get; set; }
    public string VehicleName { get; set; }
    public string VehicleType { get; set; }   // "Car", "Bike" or "Truck"
    public string Brand { get; set; }
    public double Price { get; set; }
    public int ManufacturingYear { get; set; }

    // Prints one row of the vehicle table.
    public void DisplayDetails()
    {
        Console.WriteLine(
            VehicleId + "\t" + VehicleName + "\t" + Brand + "\t" +
            VehicleType + "\t" + Price.ToString("0.00"));
    }
}
