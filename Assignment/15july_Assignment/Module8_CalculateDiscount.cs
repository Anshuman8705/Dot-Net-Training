using System;
using System.Collections.Generic;
using System.Linq;

// ==================================================================
// Module 8: Calculate Discount
// Car -> 10%, Bike -> 5%, Truck -> 12%
// ==================================================================
static class Module8_CalculateDiscount
{
    public static void Run(List<Vehicle> vehicles)
    {
        Console.Write("Enter Vehicle ID: ");
        int id = InputHelper.ReadInt();

        Vehicle vehicle = vehicles.FirstOrDefault(v => v.VehicleId == id);

        if (vehicle == null)
        {
            Console.WriteLine("Vehicle not found.");
            return;
        }

        double discountPercent;

        switch (vehicle.VehicleType.ToLower())
        {
            case "car":
                discountPercent = 0.10;
                break;
            case "bike":
                discountPercent = 0.05;
                break;
            case "truck":
                discountPercent = 0.12;
                break;
            default:
                Console.WriteLine("No discount rule for this vehicle type.");
                return;
        }

        double discount = vehicle.Price * discountPercent;
        double finalPrice = vehicle.Price - discount;

        Console.WriteLine("Vehicle Price : " + vehicle.Price.ToString("0.00"));
        Console.WriteLine("Discount : " + discount.ToString("0.00"));
        Console.WriteLine("Final Price : " + finalPrice.ToString("0.00"));
    }
}
