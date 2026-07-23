using System;
using System.Collections.Generic;

// ==================================================================
// Module 7: Display Items
// ==================================================================
static class Module7_DisplayItems
{
    public static void Run(List<StationeryItem> items)
    {
        if (items.Count == 0)
        {
            Console.WriteLine("No items found.");
            return;
        }

        Console.WriteLine("ID\tName\tCategory\tBrand\tPrice\tQuantity");
        foreach (StationeryItem item in items)
        {
            item.DisplayDetails(); // Polymorphism picks the right version
        }
    }
}
