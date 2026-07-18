/*
Scenario list:
A library stores the names of available books in a List. Display all books, add one new book, remove one old book, and display the updated list along with the total number of books.

*/


using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a list of books
        List<string> books = new List<string>();

        // Add books to the list
        books.Add("C Programming");
        books.Add("Java Programming");
        books.Add("Python Programming");
        books.Add("Data Structures");
        books.Add("Operating System");

        // Display all books
        Console.WriteLine("Available Books:");
        for (int i = 0; i < books.Count; i++)
        {
            Console.WriteLine(books[i]);
        }

        // Add a new book
        books.Add("C# Programming");

        // Remove an old book
        books.Remove("Java Programming");

        // Display updated list
        Console.WriteLine("\nUpdated Book List:");
        for (int i = 0; i < books.Count; i++)
        {
            Console.WriteLine(books[i]);
        }

        // Display total number of books
        Console.WriteLine("\nTotal Number of Books = " + books.Count);
    }
}