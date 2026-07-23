using System;
using System.Collections.Generic;
using System.Linq;

// ==================================================================
// Module 6: Add Item
// ==================================================================
static class Module6_AddItem
{
    public static void Run(List<StationeryItem> items)
    {
        try
        {
            Console.WriteLine("Choose item type: 1-Notebook, 2-Pen, 3-Marker");
            int type = InputHelper.ReadInt();

            Console.Write("Enter Item Id: ");
            int id = InputHelper.ReadInt();

            // Item Id must be unique
            if (items.Any(i => i.ItemId == id))
                throw new DuplicateItemException("Item Id already exists.");

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Category: ");
            string category = Console.ReadLine();

            Console.Write("Enter Brand: ");
            string brand = Console.ReadLine();

            Console.Write("Enter Price: ");
            double price = InputHelper.ReadDouble();
            if (price <= 0)
                throw new InvalidPriceException("Price must be greater than 0.");

            Console.Write("Enter Quantity: ");
            int qty = InputHelper.ReadInt();
            if (qty <= 0)
                throw new InvalidQuantityException("Quantity must be greater than 0.");

            StationeryItem newItem;

            if (type == 1)
            {
                Console.Write("Enter Pages: ");
                int pages = InputHelper.ReadInt();
                Console.Write("Enter Paper Type: ");
                string paperType = Console.ReadLine();

                newItem = new Notebook { Pages = pages, PaperType = paperType };
            }
            else if (type == 2)
            {
                Console.Write("Enter Ink Color: ");
                string inkColor = Console.ReadLine();
                Console.Write("Enter Pen Type: ");
                string penType = Console.ReadLine();

                newItem = new Pen { InkColor = inkColor, PenType = penType };
            }
            else if (type == 3)
            {
                Console.Write("Is it Permanent? (true/false): ");
                bool permanent = Convert.ToBoolean(Console.ReadLine());

                newItem = new Marker { Permanent = permanent };
            }
            else
            {
                Console.WriteLine("Invalid item type.");
                return;
            }

            // These go through the properties in StationeryItem, so the
            // validation there (Price > 0, Quantity >= 0) runs again too.
            newItem.ItemId = id;
            newItem.ItemName = name;
            newItem.Category = category;
            newItem.Brand = brand;
            newItem.Price = price;
            newItem.Quantity = qty;

            items.Add(newItem);
            Console.WriteLine("Item added successfully.");
        }
        catch (DuplicateItemException ex) { Console.WriteLine("Error: " + ex.Message); }
        catch (InvalidPriceException ex) { Console.WriteLine("Error: " + ex.Message); }
        catch (InvalidQuantityException ex) { Console.WriteLine("Error: " + ex.Message); }
    }
}
