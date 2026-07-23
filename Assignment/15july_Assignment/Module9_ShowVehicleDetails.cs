using System;

// ==================================================================
// Module 9: Show Vehicle Details
// Asks for a vehicle TYPE (not an ID) and prints a short description
// using a switch statement, as required by the spec.
// ==================================================================
static class Module9_ShowVehicleDetails
{
    public static void Run()
    {
        Console.Write("Enter Vehicle Type (Car/Bike/Truck): ");
        string type = Console.ReadLine();

        switch (type.ToLower())
        {
            case "car":
                Console.WriteLine("Car is a four wheeler.");
                Console.WriteLine("Suitable for family.");
                break;
            case "bike":
                Console.WriteLine("Bike is fuel efficient.");
                Console.WriteLine("Suitable for city rides.");
                break;
            case "truck":
                Console.WriteLine("Truck is used for transportation.");
                Console.WriteLine("Heavy load vehicle.");
                break;
            default:
                Console.WriteLine("Unknown vehicle type.");
                break;
        }
    }
}
