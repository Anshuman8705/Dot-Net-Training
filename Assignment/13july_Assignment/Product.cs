using System;

public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public double Price { get; set; }
    public int Stock { get; set; }

    public Product(int productId, string productName, double price, int stock)
    {
        ProductId = productId;
        ProductName = productName;
        Price = price;
        Stock = stock;
    }

    public void Display()
    {
        Console.WriteLine("---------------------------");
        Console.WriteLine("Product Id : " + ProductId);
        Console.WriteLine("Product Name : " + ProductName);
        Console.WriteLine("Price : " + Price);
        Console.WriteLine("Stock : " + Stock);
    }
}