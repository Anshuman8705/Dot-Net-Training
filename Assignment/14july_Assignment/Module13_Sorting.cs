using System;
using System.Collections.Generic;

// ==================================================================
// Module 13: Sorting
// ==================================================================
static class Module13_Sorting
{
    public static void Run(List<StationeryItem> items)
    {
        if (items.Count == 0)
        {
            Console.WriteLine("No items to sort.");
            return;
        }

        Console.WriteLine("Sort by: 1-Price, 2-Name, 3-Quantity");
        int option = InputHelper.ReadInt();

        // List.Sort() needs a Comparison<T>, which is just a rule
        // telling the List HOW to compare two items.
        switch (option)
        {
            case 1:
                items.Sort((a, b) => a.Price.CompareTo(b.Price));
                break;
            case 2:
                items.Sort((a, b) => a.ItemName.CompareTo(b.ItemName));
                break;
            case 3:
                items.Sort((a, b) => a.Quantity.CompareTo(b.Quantity));
                break;
            default:
                Console.WriteLine("Invalid option.");
                return;
        }

        Module7_DisplayItems.Run(items);
    }
}
