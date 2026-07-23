using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    const int MaxLoginAttempts = 3;

    static void Main()
    {
        // ---------- Step 1 : Registration ----------
        Customer customer = RegisterCustomer();
        if (customer == null)
        {
            return;
        }

        // ---------- Step 2 : Login ----------
        bool loggedIn = Login(customer);
        if (!loggedIn)
        {
            return;
        }

        // ---------- Step 3 : Product Management ----------
        List<Product> products = AddProducts();
        DisplayAllProducts(products);

        // ---------- Step 4 : Search Product ----------
        SearchProduct(products);

        // ---------- Step 5 : Add to Cart ----------
        List<CartItem> cart = BuildCart(products);
        DisplayCart(cart);

        // ---------- Step 6 : Discount ----------
        double totalAmount = cart.Sum(item => item.Subtotal());
        double discount = CalculateDiscount(totalAmount);
        double finalAmount = totalAmount - discount;

        Console.WriteLine("\n===== Bill Summary =====");
        Console.WriteLine("Total Amount : " + totalAmount);
        Console.WriteLine("Discount : " + discount);
        Console.WriteLine("Final Amount : " + finalAmount);

        // ---------- Step 7 : Payment ----------
        ProcessPayment();
    }

    // ==================== Registration & Login ====================

    static Customer RegisterCustomer()
    {
        Console.WriteLine("===== Customer Registration =====");

        Console.Write("Enter Customer Id : ");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Name : ");
        string name = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("Name Cannot Be Empty.");
            return null;
        }

        name = name.ProperCase();

        Console.Write("Enter Email : ");
        string email = Console.ReadLine();

        if (!IsValidEmail(email))
        {
            Console.WriteLine("Invalid Email Format.");
            return null;
        }

        Console.Write("Enter Password : ");
        string password = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(password) || password.Length < 4)
        {
            Console.WriteLine("Password Must Be At Least 4 Characters Long.");
            return null;
        }

        Console.WriteLine("Registration Successful");

        return new Customer(id, name, email, password);
    }

    static bool Login(Customer customer)
    {
        Console.WriteLine("\n===== Login =====");

        int attemptsLeft = MaxLoginAttempts;

        while (attemptsLeft > 0)
        {
            Console.Write("Enter Email : ");
            string email = Console.ReadLine();

            Console.Write("Enter Password : ");
            string password = Console.ReadLine();

            if (email.Equals(customer.Email, StringComparison.OrdinalIgnoreCase) &&
                password == customer.Password)
            {
                Console.WriteLine("Welcome " + customer.Name);
                return true;
            }

            attemptsLeft--;

            if (attemptsLeft > 0)
            {
                Console.WriteLine("Incorrect Email or Password. Attempts Remaining : " + attemptsLeft);
            }
        }

        Console.WriteLine("Account Locked");
        return false;
    }

    static bool IsValidEmail(string email)
    {
        if (string.IsNullOrWhiteSpace(email))
        {
            return false;
        }

        int atIndex = email.IndexOf('@');
        int dotIndex = email.LastIndexOf('.');

        return atIndex > 0 && dotIndex > atIndex + 1 && dotIndex < email.Length - 1;
    }

    // ==================== Product Management ====================

    static List<Product> AddProducts()
    {
        List<Product> products = new List<Product>();

        Console.WriteLine("\n===== Add Products =====");
        Console.Write("How many products do you want to add? : ");
        int count = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= count; i++)
        {
            Console.WriteLine("\n--- Enter details for Product " + i + " ---");

            Console.Write("Enter Product Id : ");
            int id = Convert.ToInt32(Console.ReadLine());

            if (products.Any(p => p.ProductId == id))
            {
                Console.WriteLine("Product Id Already Exists. Skipping this product.");
                continue;
            }

            Console.Write("Enter Product Name : ");
            string name = Console.ReadLine();

            Console.Write("Enter Price : ");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Stock : ");
            int stock = Convert.ToInt32(Console.ReadLine());

            products.Add(new Product(id, name, price, stock));
        }

        return products;
    }

    static void DisplayAllProducts(List<Product> products)
    {
        Console.WriteLine("\n===== All Products =====");

        if (products.Count == 0)
        {
            Console.WriteLine("No Products Available.");
            return;
        }

        foreach (Product p in products)
        {
            p.Display();
        }
        Console.WriteLine("---------------------------");
    }

    // ==================== Search Product ====================

    static void SearchProduct(List<Product> products)
    {
        Console.WriteLine("\n===== Search Product =====");
        Console.Write("Enter product name to search : ");
        string searchName = Console.ReadLine();

        Product found = products.FirstOrDefault(
            p => p.ProductName.Equals(searchName, StringComparison.OrdinalIgnoreCase));

        if (found != null)
        {
            Console.WriteLine("Product Found");
            Console.WriteLine("Product Id : " + found.ProductId);
            Console.WriteLine("Product Name : " + found.ProductName);
            Console.WriteLine("Price : " + found.Price);
            Console.WriteLine("Stock : " + found.Stock);
        }
        else
        {
            Console.WriteLine("Product Not Found");
        }
    }

    // ==================== Cart ====================

    static List<CartItem> BuildCart(List<Product> products)
    {
        List<CartItem> cart = new List<CartItem>();

        Console.WriteLine("\n===== Add to Cart =====");

        if (products.Count == 0)
        {
            Console.WriteLine("No Products Available to Add to Cart.");
            return cart;
        }

        while (true)
        {
            DisplayAllProducts(products);

            Console.Write("Enter Product Id : ");
            int id = Convert.ToInt32(Console.ReadLine());

            Product product = products.FirstOrDefault(p => p.ProductId == id);

            if (product == null)
            {
                Console.WriteLine("Product Not Found.");
            }
            else
            {
                Console.Write("Enter Quantity : ");
                int quantity = Convert.ToInt32(Console.ReadLine());

                if (quantity <= 0)
                {
                    Console.WriteLine("Quantity Must Be Greater Than Zero.");
                }
                else if (quantity > product.Stock)
                {
                    Console.WriteLine("Insufficient Stock. Only " + product.Stock + " Available.");
                }
                else
                {
                    // reduce available stock and add (or merge) the item in the cart
                    product.Stock -= quantity;

                    CartItem existingItem = cart.FirstOrDefault(c => c.Product.ProductId == id);
                    if (existingItem != null)
                    {
                        existingItem.Quantity += quantity;
                    }
                    else
                    {
                        cart.Add(new CartItem(product, quantity));
                    }

                    Console.WriteLine("Added to cart.");
                }
            }

            Console.WriteLine("Do you want to add another product?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");
            Console.Write("Enter Choice : ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice != 1)
            {
                break;
            }
        }

        return cart;
    }

    static void DisplayCart(List<CartItem> cart)
    {
        Console.WriteLine("\n===== Cart =====");

        if (cart.Count == 0)
        {
            Console.WriteLine("Cart is Empty.");
            return;
        }

        foreach (CartItem item in cart)
        {
            item.Display();
        }
    }

    // ==================== Discount ====================

    static double CalculateDiscount(double totalAmount)
    {
        double discountPercent;

        if (totalAmount < 1000)
        {
            discountPercent = 0;
        }
        else if (totalAmount <= 4999)
        {
            discountPercent = 10;
        }
        else if (totalAmount <= 9999)
        {
            discountPercent = 20;
        }
        else
        {
            discountPercent = 30;
        }

        return totalAmount * discountPercent / 100;
    }

    // ==================== Payment ====================

    static void ProcessPayment()
    {
        Console.WriteLine("\n===== Choose Payment =====");
        Console.WriteLine("1. UPI");
        Console.WriteLine("2. Credit Card");
        Console.WriteLine("3. Debit Card");
        Console.WriteLine("4. Cash on Delivery");
        Console.Write("Enter Choice : ");

        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
            case 2:
            case 3:
            case 4:
                Console.WriteLine("Payment Successful");
                break;

            default:
                Console.WriteLine("Invalid Option");
                break;
        }
    }
}