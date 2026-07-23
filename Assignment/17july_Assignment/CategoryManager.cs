using System;
using System.Collections.Generic;
using System.Linq;

namespace ShopEaseApp
{
    // Module 3 - Category Management (Admin)
    // Handles add/update/delete/view categories
    public static class CategoryManager
    {
        public static List<Category> Categories = new List<Category>();
        private static int nextCategoryId = 1;

        // Static constructor runs once, preloads the 6 default categories
        static CategoryManager()
        {
            Categories.Add(new Category(nextCategoryId++, "Electronics"));
            Categories.Add(new Category(nextCategoryId++, "Books"));
            Categories.Add(new Category(nextCategoryId++, "Fashion"));
            Categories.Add(new Category(nextCategoryId++, "Sports"));
            Categories.Add(new Category(nextCategoryId++, "Furniture"));
            Categories.Add(new Category(nextCategoryId++, "Groceries"));
        }

        public static void AddCategory()
        {
            Console.Write("\nEnter new category name: ");
            string name = Console.ReadLine();

            Categories.Add(new Category(nextCategoryId, name));
            nextCategoryId++;

            Console.WriteLine("Category added successfully.");
        }

        public static void UpdateCategory()
        {
            ViewAllCategories();
            Console.Write("\nEnter Category Id to update: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Category category = Categories.FirstOrDefault(c => c.CategoryId == id);
            if (category == null)
            {
                Console.WriteLine("Category not found.");
                return;
            }

            Console.Write("Enter new name: ");
            category.Name = Console.ReadLine();

            Console.WriteLine("Category updated successfully.");
        }

        public static void DeleteCategory()
        {
            ViewAllCategories();
            Console.Write("\nEnter Category Id to delete: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Category category = Categories.FirstOrDefault(c => c.CategoryId == id);
            if (category == null)
            {
                Console.WriteLine("Category not found.");
                return;
            }

            Categories.Remove(category);
            Console.WriteLine("Category deleted successfully.");
        }

        public static void ViewAllCategories()
        {
            Console.WriteLine("\n--- Categories ---");
            foreach (Category c in Categories)
                Console.WriteLine(c.CategoryId + ". " + c.Name);
        }
    }
}
