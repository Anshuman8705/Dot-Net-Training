using System;

public class CartItem
{
    public Product Product { get; set; }
    public int Quantity { get; set; }

    public CartItem(Product product, int quantity)
    {
        Product = product;
        Quantity = quantity;
    }

    public double Subtotal()
    {
        return Product.Price * Quantity;
    }

    public void Display()
    {
        Console.WriteLine(Product.ProductName + " x" + Quantity + "  (Rs. " + Subtotal() + ")");
    }
}