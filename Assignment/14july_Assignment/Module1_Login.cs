using System;

// ==================================================================
// Module 1: User Login
// ==================================================================
static class Module1_Login
{
    public static void Run()
    {
        string correctUsername = "admin";
        string correctPassword = "admin123";
        int attemptsLeft = 3;

        while (attemptsLeft > 0)
        {
            Console.Write("Enter Username: ");
            string username = Console.ReadLine();

            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            if (username == correctUsername && password == correctPassword)
            {
                Console.WriteLine("Login Successful!");
                return; // logged in, so leave the method
            }

            attemptsLeft--;
            Console.WriteLine("Invalid Login");
            Console.WriteLine("Attempts Left : " + attemptsLeft);
        }

        // Ran out of attempts
        throw new LoginFailedException("Login failed after 3 attempts.");
    }
}
