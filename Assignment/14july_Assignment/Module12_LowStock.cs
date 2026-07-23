using System;
using System.Collections.Generic;
using System.Linq;

// ==================================================================
// Module 12: Low Stock
// ==================================================================
static class Module12_LowStock
{
    public static void Run(List<StationeryItem> items)
    {
        List<StationeryItem> lowStock = items.Where(i => i.Quantity < 5).ToList();

        if (lowStock.Count == 0)
        {
            Console.WriteLine("No low stock items.");
            return;
        }

        Console.WriteLine("Low Stock Items (Quantity < 5):");
        foreach (StationeryItem item in lowStock)
        {
            item.DisplayDetails();
        }
    }
}
