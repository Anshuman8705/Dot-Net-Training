using System;
using System.Collections.Generic;
using System.Linq;

namespace ShopEaseApp
{
    // Module 1 - User Authentication
    // Handles customer register/login/logout/update profile/change password
    // and admin login (fixed username/password)
    public static class AuthManager
    {
        private static List<Customer> customers = new List<Customer>();
        private static int nextCustomerId = 1;

        public static Customer LoggedInCustomer = null;
        public static bool IsAdminLoggedIn = false;

        private const string AdminUsername = "admin";
        private const string AdminPassword = "admin123";

        public static void Register()
        {
            Console.WriteLine("\n--- Customer Registration ---");
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your email: ");
            string email = Console.ReadLine();

            bool emailExists = customers.Any(c => c.Email == email);
            if (emailExists)
            {
                Console.WriteLine("This email is already registered. Please login instead.");
                return;
            }

            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            Console.Write("Enter your address: ");
            string address = Console.ReadLine();

            Customer newCustomer = new Customer(nextCustomerId, name, email, password, address);
            customers.Add(newCustomer);
            nextCustomerId++;

            Console.WriteLine("Registration successful! You can now login.");
        }

        public static void Login()
        {
            Console.WriteLine("\n--- Customer Login ---");
            Console.Write("Enter email: ");
            string email = Console.ReadLine();

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            Customer found = customers.FirstOrDefault(c => c.Email == email && c.Password == password);

            if (found != null)
            {
                LoggedInCustomer = found;
                Console.WriteLine("Login successful! Welcome " + found.Name);
            }
            else
            {
                Console.WriteLine("Invalid email or password.");
            }
        }

        public static void Logout()
        {
            if (LoggedInCustomer != null)
            {
                Console.WriteLine("Goodbye " + LoggedInCustomer.Name + "!");
                LoggedInCustomer = null;
            }
            else
            {
                Console.WriteLine("No customer is currently logged in.");
            }
        }

        public static void UpdateProfile()
        {
            if (LoggedInCustomer == null)
            {
                Console.WriteLine("Please login first.");
                return;
            }

            Console.WriteLine("\n--- Update Profile ---");
            Console.Write("Enter new name (leave blank to keep current): ");
            string name = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(name))
                LoggedInCustomer.Name = name;

            Console.Write("Enter new address (leave blank to keep current): ");
            string address = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(address))
                LoggedInCustomer.Address = address;

            Console.WriteLine("Profile updated successfully.");
        }

        public static void ChangePassword()
        {
            if (LoggedInCustomer == null)
            {
                Console.WriteLine("Please login first.");
                return;
            }

            Console.Write("Enter current password: ");
            string current = Console.ReadLine();

            if (current != LoggedInCustomer.Password)
            {
                Console.WriteLine("Current password is incorrect.");
                return;
            }

            Console.Write("Enter new password: ");
            string newPassword = Console.ReadLine();
            LoggedInCustomer.Password = newPassword;

            Console.WriteLine("Password changed successfully.");
        }

        public static void AdminLogin()
        {
            Console.WriteLine("\n--- Admin Login ---");
            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            if (username == AdminUsername && password == AdminPassword)
            {
                IsAdminLoggedIn = true;
                Console.WriteLine("Admin login successful!");
            }
            else
            {
                Console.WriteLine("Invalid admin credentials.");
            }
        }

        public static void AdminLogout()
        {
            IsAdminLoggedIn = false;
            Console.WriteLine("Admin logged out.");
        }
    }
}
