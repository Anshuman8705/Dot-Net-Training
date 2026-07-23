using System;

namespace ShopEaseApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("   WELCOME TO SHOPEASE CONSOLE APP");
            Console.WriteLine("=====================================");

            // Add a few sample products so the app is ready to test right away
            SeedSampleData();

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\n===== MAIN MENU =====");
                Console.WriteLine("1. Customer Menu");
                Console.WriteLine("2. Admin Menu");
                Console.WriteLine("3. Exit");
                Console.Write("Enter choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        CustomerMenu();
                        break;
                    case "2":
                        AdminMenu();
                        break;
                    case "3":
                        exit = true;
                        Console.WriteLine("Thank you for using ShopEase!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }

        static void SeedSampleData()
        {
            ProductManager.Products.Add(new Product(1001, "Laptop", "Electronics", "Dell Inspiron", 65000, 20, "Dell", 10, 4.6));
            ProductManager.Products.Add(new Product(1002, "Mouse", "Electronics", "Wireless Mouse", 500, 50, "Logitech", 5, 4.2));
            ProductManager.Products.Add(new Product(1003, "Keyboard", "Electronics", "Mechanical Keyboard", 1500, 30, "HP", 8, 4.4));
        }

        static void CustomerMenu()
        {
            bool back = false;
            while (!back)
            {
                Console.WriteLine("\n===== CUSTOMER MENU =====");
                Console.WriteLine("1. Register");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Logout");
                Console.WriteLine("4. Update Profile");
                Console.WriteLine("5. Change Password");
                Console.WriteLine("6. View Products");
                Console.WriteLine("7. Add to Cart");
                Console.WriteLine("8. Remove Item from Cart");
                Console.WriteLine("9. Update Cart Quantity");
                Console.WriteLine("10. Clear Cart");
                Console.WriteLine("11. View Cart Total");
                Console.WriteLine("12. Apply Coupon");
                Console.WriteLine("13. Checkout / Place Order");
                Console.WriteLine("14. View Previous Orders");
                Console.WriteLine("15. Search Order");
                Console.WriteLine("16. Cancel Order");
                Console.WriteLine("17. Download Invoice");
                Console.WriteLine("18. Back to Main Menu");
                Console.Write("Enter choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": AuthManager.Register(); break;
                    case "2": AuthManager.Login(); break;
                    case "3": AuthManager.Logout(); break;
                    case "4": AuthManager.UpdateProfile(); break;
                    case "5": AuthManager.ChangePassword(); break;
                    case "6": CartManager.ViewProducts(); break;
                    case "7": CartManager.AddToCart(); break;
                    case "8": CartManager.RemoveItem(); break;
                    case "9": CartManager.UpdateQuantity(); break;
                    case "10": CartManager.ClearCart(); break;
                    case "11": CartManager.ViewTotal(); break;
                    case "12": CartManager.ApplyCoupon(); break;
                    case "13": OrderManager.Checkout(); break;
                    case "14": OrderManager.ViewPreviousOrders(); break;
                    case "15": OrderManager.SearchOrder(); break;
                    case "16": OrderManager.CancelOrder(); break;
                    case "17": OrderManager.DownloadInvoice(); break;
                    case "18": back = true; break;
                    default: Console.WriteLine("Invalid choice. Try again."); break;
                }
            }
        }

        static void AdminMenu()
        {
            if (!AuthManager.IsAdminLoggedIn)
            {
                AuthManager.AdminLogin();
                if (!AuthManager.IsAdminLoggedIn)
                    return;
            }

            bool back = false;
            while (!back)
            {
                Console.WriteLine("\n===== ADMIN MENU =====");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Update Product");
                Console.WriteLine("3. Delete Product");
                Console.WriteLine("4. Search Product");
                Console.WriteLine("5. View All Products");
                Console.WriteLine("6. Add Category");
                Console.WriteLine("7. Update Category");
                Console.WriteLine("8. Delete Category");
                Console.WriteLine("9. View All Categories");
                Console.WriteLine("10. Logout");
                Console.WriteLine("11. Back to Main Menu");
                Console.Write("Enter choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": ProductManager.AddProduct(); break;
                    case "2": ProductManager.UpdateProduct(); break;
                    case "3": ProductManager.DeleteProduct(); break;
                    case "4": ProductManager.SearchProduct(); break;
                    case "5": ProductManager.ViewAllProducts(); break;
                    case "6": CategoryManager.AddCategory(); break;
                    case "7": CategoryManager.UpdateCategory(); break;
                    case "8": CategoryManager.DeleteCategory(); break;
                    case "9": CategoryManager.ViewAllCategories(); break;
                    case "10": AuthManager.AdminLogout(); back = true; break;
                    case "11": back = true; break;
                    default: Console.WriteLine("Invalid choice. Try again."); break;
                }
            }
        }
    }
}
