using System;
using System.Collections.Generic;
using System.Linq;

// ==================================================================
// Module 9: Update Item
// ==================================================================
static class Module9_UpdateItem
{
    public static void Run(List<StationeryItem> items)
    {
        try
        {
            Console.Write("Enter Item Id to update: ");
            int id = InputHelper.ReadInt();

            StationeryItem item = items.FirstOrDefault(i => i.ItemId == id);
            if (item == null)
                throw new ItemNotFoundException("Item not found.");

            Console.Write("Enter New Price: ");
            item.Price = InputHelper.ReadDouble();

            Console.Write("Enter New Quantity: ");
            item.Quantity = InputHelper.ReadInt();

            Console.Write("Enter New Brand: ");
            item.Brand = Console.ReadLine();

            Console.WriteLine("Item updated successfully.");
        }
        catch (ItemNotFoundException ex) { Console.WriteLine("Error: " + ex.Message); }
        catch (InvalidPriceException ex) { Console.WriteLine("Error: " + ex.Message); }
        catch (InvalidQuantityException ex) { Console.WriteLine("Error: " + ex.Message); }
    }
}
